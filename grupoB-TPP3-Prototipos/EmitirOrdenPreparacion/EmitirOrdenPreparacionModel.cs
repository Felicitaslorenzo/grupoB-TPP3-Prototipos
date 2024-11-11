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

        // Función para generar una nueva orden a partir de los productos seleccionados en el ListView
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

            // Agregar la nueva orden a la lista de órdenes (supongo que la lista "ordenes" está definida en el contexto)
            ordenes.Add(nuevaOrden);

            // Llamamos a CambiarEstadoOrden para cambiar el estado de la orden recién creada
            // Suponemos que la nueva orden que acabamos de crear es la que queremos cambiar de estado
            var ordenItem = new ListViewItem(nuevaOrden.IDOrdenPreparacion); // Asumimos que IDOrdenPreparacion es el identificador de la orden
            CambiarEstadoOrden(ordenItem);

            return $"Orden {nuevoIDOrden} creada exitosamente.";
        }

        // Función para cambiar el estado de una orden basada en su número de orden
        public void CambiarEstadoOrden(ListViewItem item)
        {
            var partes = item.Text.Split(' '); // Asumimos que el texto contiene un número de orden en algún formato
            if (partes.Length > 1)
            {
                var ordenNum = int.Parse(partes[1]);

                // Buscar la orden pendiente en el almacenamiento de órdenes
                var orden = OrdenPreparacionAlmacen.OrdenesPreparacion
    .FirstOrDefault(o =>
    {
        int idOrden;
        return o.Estado == EstadoOrdenPrepEnum.Pendiente && int.TryParse(o.IdOrdenPreparacion, out idOrden) && idOrden == ordenNum;
    });

                // Si encontramos la orden, cambiamos su estado
                if (orden != null)
                {
                    orden.Estado = EstadoOrdenPrepEnum.EnSeleccion;
                }
            }
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