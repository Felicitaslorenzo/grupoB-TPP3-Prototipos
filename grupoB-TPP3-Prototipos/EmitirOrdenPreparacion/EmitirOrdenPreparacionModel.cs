using grupoB_TPP3_Prototipos.Almacenes;
using grupoB_TPP3_Prototipos.ListarOrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion
{
    internal class EmitirOrdenPreparacionModel
    {
        public List<OrdenPreparacion> ordenes = new List<OrdenPreparacion>
        {
            new OrdenPreparacion
            {
                Productos = ProductoAlmacen.Productos.Select(p => new Producto
                {
                    IDProducto = p.SKUProducto, DescripcionProducto = p.DescripcionProducto
                }).ToList()
            }
        };

        public (bool, string) BuscarProductoEnOrdenes(string idProducto)
        {
            foreach (var orden in ordenes)
            {
                foreach (var producto in orden.Productos)
                {
                    if (producto.IDProducto == idProducto)
                    {
                        return (true, producto.DescripcionProducto);
                    }
                }
            }
            return (false, string.Empty);
        }

        public OrdenPreparacion CrearOrdenPreparacion(string idCliente, string prioridad, string transportista, List<Producto> productosOrden)
        {
            // Crear y configurar la nueva orden
            return new OrdenPreparacion
            {
                IDOrdenPreparacion = GenerarNuevoIDOrden(),
                Clientes = new List<Cliente>
            {
                new Cliente
                {
                    IdCliente = idCliente,
                    Prioridad = prioridad,
                    Transportistas = new List<string> { transportista }
                }
            },
                Productos = productosOrden
            };
        }

        public OrdenPreparacionEnt ConvertirOrdenPreparacionEnt(OrdenPreparacion nuevaOrden, string transportista, string prioridad)
        {
            // Convertir la orden en el tipo Entidad
            OrdenPreparacionEnt nuevaOrdenEnt = new OrdenPreparacionEnt
            {
                IdOrdenPreparacion = nuevaOrden.IDOrdenPreparacion,
                IdCliente = nuevaOrden.Clientes.FirstOrDefault()?.IdCliente,
                FechaEmision = DateTime.Now,
                FechaEntrega = DateTime.Now.AddDays(7),
                Estado = EstadoOrdenPrepEnum.Pendiente,
                Prioridad = (PrioridadEnum)Enum.Parse(typeof(PrioridadEnum), prioridad),
                IdTransportista = transportista
            };

            // Agregar los detalles de cada producto
            foreach (var producto in nuevaOrden.Productos)
            {
                nuevaOrdenEnt.Detalle.Add(new OrdenPreparacionDetalle
                {
                    SKUProducto = producto.IDProducto,
                    Cantidad = producto.Cantidad
                });
            }

            return nuevaOrdenEnt;
        }

        public void GuardarOrdenPreparacion(OrdenPreparacionEnt orden)
        {
            // Guardar la orden en el almacenamiento
            OrdenPreparacionAlmacen.AgregarOrdenPreparacion(orden);
        }

        private string GenerarNuevoIDOrden()
        {
            // Leer las órdenes desde el archivo (simulamos que ya tienes la lógica para leer desde un almacenamiento)


            // Obtener el último ID de las órdenes
            var ultimoId = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Select(o => o.IdOrdenPreparacion)
                .OrderByDescending(id => id)
                .FirstOrDefault();

            // Si no existe ninguna orden, empezamos con "OP-001"
            if (string.IsNullOrEmpty(ultimoId))
            {
                return "OP-001";
            }

            // Extraemos el número al final del ID, en el formato "OP-###"
            var numero = int.Parse(ultimoId.Substring(3));  // Asumimos que el ID tiene el formato "OP-###"

            // Incrementamos el número
            numero++;

            // Generamos el nuevo ID en el formato "OP-###"
            return $"OP-{numero:D3}";  // El ":D3" asegura que el número tenga 3 dígitos
        }



        internal List<Producto> BuscarProductoCliente(Cliente cliente)
        {
            // Filtra los productos asociados al cliente y enlaza con InventarioMercaderia para obtener la cantidad disponible
            var productosCliente = ProductoAlmacen.Productos
                .Where(productoEntidad => productoEntidad.IdCliente == cliente.IdCliente)
                .Select(producto => new Producto
                {
                    IDProducto = producto.SKUProducto,
                    DescripcionProducto = producto.DescripcionProducto,
                    Cantidad = ObtenerCantidadDisponible(producto.SKUProducto) // Obtener cantidad de InventarioMercaderiaEnt
                }).ToList();



            return productosCliente;
        }


        public int ObtenerCantidadDisponible(string skuProducto)
        {
            // Busca en InventarioMercaderia la cantidad disponible para el SKUProducto específico

            //TODO: hay que restar la cantidad de producto que esté en ordenes en un estado previo
            //a "retirar ordenes de seleccion" (que es cuando se da de baja de stock)

            var depositoActual = DepositoAlmacen.DepositoActual.IdDeposito;
            var producto = ProductoAlmacen.Productos.First(p => p.SKUProducto == skuProducto);

            int cantidadDisponible = producto.Inventario.Where(d => d.IdDeposito == depositoActual).Sum(d => d.Cantidad);

            int cantidadComprometida = OrdenPreparacionAlmacen.OrdenesPreparacion
                   .Where(o => o.IdDeposito == depositoActual &&
                               (o.Estado == EstadoOrdenPrepEnum.Pendiente ||
                                o.Estado == EstadoOrdenPrepEnum.EnSeleccion)) //   Comprometemos las canitdades en estado 0 y 1 ya que en estado 2 se restan de inventario
                   .SelectMany(o => o.Detalle)
                   .Where(d => d.SKUProducto == skuProducto)
                   .Sum(o => o.Cantidad);

            int cantidadRestante = cantidadDisponible - cantidadComprometida;
            return cantidadRestante;
        }

        public (bool exito, string mensaje) ValidarCantidadEnOrdenActual(List<Producto> productosOrden, string skuProducto, int cantidadSolicitada)
        {
            // Obtener la cantidad disponible global desde el inventario
            int cantidadDisponibleGlobal = ObtenerCantidadDisponible(skuProducto);

            // Sumar la cantidad de producto ya solicitada en la orden actual
            int cantidadEnOrdenActual = productosOrden
                .Where(p => p.IDProducto == skuProducto)
                .Sum(p => p.Cantidad);

            // Calcular la cantidad total que el cliente intenta solicitar
            int cantidadTotalSolicitada = cantidadEnOrdenActual + cantidadSolicitada;

            // Verificar si la cantidad total solicitada excede la cantidad disponible
            if (cantidadTotalSolicitada > cantidadDisponibleGlobal)
            {
                return (false, $"Error: No hay suficiente stock disponible para {skuProducto}. Cantidad disponible: {cantidadDisponibleGlobal}, cantidad solicitada: {cantidadTotalSolicitada}.");
            }

            return (true, "La cantidad solicitada es válida y se puede agregar a la orden.");
        }


        public List<Cliente> ObtenerCliente()
        {
            // Obtenemos los clientes de ClienteAlmacen y sus transportistas correspondientes de TransportistaAlmacen
            return ClienteAlmacen.Clientes.Select(cliente => new Cliente
            {
                IdCliente = cliente.IdCliente,
                Transportistas = TransportistaAlmacen.Transportistas
                    .Where(transportista => transportista.IdCliente == cliente.IdCliente)
                    .Select(transportista => transportista.IdTransportista)
                    .ToList()
            }).ToList();
        }
        public List<string> ObtenerPrioridad()
        {
            // Devuelve los nombres de los valores definidos en el enum
            return Enum.GetValues(typeof(PrioridadEnum))
                .Cast<PrioridadEnum>()
                .Select(p => p.ToString()) // Devolver el nombre del enum como string
                .ToList();
        }

        public Cliente ClienteAnterior { get; set; }
    }
}