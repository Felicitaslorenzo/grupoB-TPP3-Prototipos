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

        public string GenerarNuevaOrden(string idCliente, string prioridad, string transportista, ListView productosListView)
        {
            // Generar un nuevo ID de orden basado en la lógica de ordenación
            string nuevoIDOrden = GenerarNuevoIDOrden();
            List<Producto> productosOrden = new List<Producto>();

            // Iterar sobre los productos seleccionados en el ListView
            foreach (ListViewItem productoItem in productosListView.Items)
            {
                if (int.TryParse(productoItem.SubItems[2].Text, out int cantidad))
                {
                    productosOrden.Add(new Producto
                    {
                        IDProducto = productoItem.SubItems[0].Text,
                        DescripcionProducto = productoItem.SubItems[1].Text,
                        Cantidad = cantidad,
                        // Ubicacion = productoItem.SubItems[3].Text // Si es necesario, puedes agregar más datos como la ubicación
                    });
                }
                else
                {
                    return $"Error: La cantidad para el producto {productoItem.SubItems[1].Text} no es válida.";
                }
            }

            // Crear la nueva orden
            OrdenPreparacion nuevaOrden = new OrdenPreparacion
            {
                IDOrdenPreparacion = nuevoIDOrden,
                Clientes = new List<Cliente>
        {
            new Cliente { IdCliente = idCliente, Prioridad = prioridad, Transportistas = new List<string> { transportista }}
        },
                Productos = productosOrden
            };

            // Convertir la nueva orden de tipo OrdenPreparacion a OrdenPreparacionEnt
            OrdenPreparacionEnt nuevaOrdenEnt = new OrdenPreparacionEnt
            {
                IdOrdenPreparacion = nuevaOrden.IDOrdenPreparacion,
                // Asignar el primer cliente, o lo que sea adecuado en tu caso
                IdCliente = nuevaOrden.Clientes.FirstOrDefault()?.IdCliente,
                FechaEmision = DateTime.Now,
                FechaEntrega = DateTime.Now.AddDays(7), // O la lógica de fecha que prefieras
                Estado = EstadoOrdenPrepEnum.Pendiente,
                Prioridad = (PrioridadEnum)Enum.Parse(typeof(PrioridadEnum), prioridad), // Asumiendo que Prioridad es un enum
                IdTransportista = transportista
            };

            // Agregar los productos a la propiedad Detalle de OrdenPreparacionEnt
            foreach (var producto in nuevaOrden.Productos)
            {
                nuevaOrdenEnt.Detalle.Add(new OrdenPreparacionDetalle
                {
                    SKUProducto = producto.IDProducto,
                    DescripcionProducto = producto.DescripcionProducto,
                    Cantidad = producto.Cantidad
                });
            }

            // Agregar la nueva orden al almacenamiento
            OrdenPreparacionAlmacen.AgregarOrdenPreparacion(nuevaOrdenEnt);

            // Agregar la nueva orden a la lista global de órdenes
            ordenes.Add(nuevaOrden);

            return $"Orden {nuevoIDOrden} creada exitosamente.";
        }

        private string GenerarNuevoIDOrden()
        {
            // Leer las órdenes desde el archivo (simulamos que ya tienes la lógica para leer desde un almacenamiento)
            OrdenPreparacionAlmacen.Leer();

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

        internal void CargarCliente(ComboBox IdClienteCombo, ComboBox TransportistaCombo, ComboBox ProductosCombo)
        {
            var clientes = ObtenerCliente();

            // Carga de los clientes en el ComboBox
            foreach (var cliente in clientes)
            {
                IdClienteCombo.Items.Add(cliente);
            }

            IdClienteCombo.DisplayMember = "IdCliente";

            // Evento cuando se selecciona un cliente
            IdClienteCombo.SelectedIndexChanged += (s, e) =>
            {
                if (IdClienteCombo.SelectedItem is Cliente selectedCliente)
                {
                    // Cargar transportistas y productos al seleccionar un cliente

                    CargarTransportistas(selectedCliente, TransportistaCombo);
                    CargarProductos(selectedCliente, ProductosCombo);
                }
            };
        }

        internal void CargarTransportistas(Cliente cliente, ComboBox TransportistaCombo)
        {
            TransportistaCombo.Items.Clear();

            // Cargar todos los transportistas del cliente seleccionado
            foreach (var transportista in cliente.Transportistas)
            {
                TransportistaCombo.Items.Add(transportista);
            }

            // No establecer ninguna opción seleccionada, dejar el combo vacío
            TransportistaCombo.SelectedIndex = -1;
        }

        internal void CargarProductos(Cliente cliente, ComboBox ProductosCombo)
        {

            ProductosCombo.Items.Clear();

            // Carga los productos devueltos por la función BuscarProductoCliente
            var productos = BuscarProductoCliente(cliente);
            foreach (var producto in productos)
            {
                ProductosCombo.Items.Add(producto);
            }

            ProductosCombo.DisplayMember = "IDProducto";
        }

        /*
        internal List<Producto> BuscarProductoCliente(Cliente cliente, List<Producto> productosSolicitados)
        {
            // Filtra los productos asociados al cliente y enlaza con InventarioMercaderiaEnt para obtener la cantidad disponible
            var productosCliente = ProductoAlmacen.Productos
                .Where(productoEntidad => productoEntidad.IdCliente == cliente.IdCliente)
                .Select(producto => new Producto
                {
                    IDProducto = producto.SKUProducto,
                    DescripcionProducto = producto.DescripcionProducto,
                    Cantidad = ObtenerCantidadDisponible(producto.SKUProducto) // Obtener cantidad de InventarioMercaderiaEnt
                }).ToList();

            // Verificación de inventario
            foreach (var productoSolicitado in productosSolicitados)
            {
                var productoEnInventario = productosCliente
                    .FirstOrDefault(p => p.IDProducto == productoSolicitado.IDProducto);

                if (productoEnInventario != null && productoSolicitado.Cantidad > productoEnInventario.Cantidad)
                {
                    throw new InvalidOperationException(
                        $"Error: No hay suficiente inventario para el producto {productoSolicitado.DescripcionProducto}. Disponible: {productoEnInventario.Cantidad}, Solicitado: {productoSolicitado.Cantidad}");
                }
            }

            return productosCliente;
        }

        private int ObtenerCantidadDisponible(string skuProducto)
        {
            // Busca en InventarioMercaderiaEnt la cantidad disponible para el SKUProducto específico
            var inventario = InventarioMercaderiaAlmacen.InventarioMercaderias
                .FirstOrDefault(inv => inv.SKUProducto == skuProducto);

            return inventario?.Cantidad ?? 0; // Devuelve 0 si no se encuentra el SKUProducto en el inventario
        }

        */

        internal List<Producto> BuscarProductoCliente(Cliente cliente)
        {
            return ProductoAlmacen.Productos.Where(productoEntidad => productoEntidad.IdCliente == cliente.IdCliente)
                .Select(producto => new Producto
                {
                    IDProducto = producto.SKUProducto,
                    DescripcionProducto = producto.DescripcionProducto
                }).ToList();
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