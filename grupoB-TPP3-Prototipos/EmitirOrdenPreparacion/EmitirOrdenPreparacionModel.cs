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
            string nuevoIDOrden = GenerarNuevoIDOrden();
            List<Producto> productosOrden = new List<Producto>();

            foreach (ListViewItem productoItem in productosListView.Items)
            {
                if (int.TryParse(productoItem.SubItems[2].Text, out int cantidad))
                {
                    productosOrden.Add(new Producto
                    {
                        IDProducto = productoItem.SubItems[0].Text,
                        DescripcionProducto = productoItem.SubItems[1].Text,
                        Cantidad = cantidad,
                        // Ubicacion = productoItem.SubItems[3].Text
                    });
                }
                else
                {
                    return $"Error: La cantidad para el producto {productoItem.SubItems[1].Text} no es válida.";
                }
            }

            OrdenPreparacion nuevaOrden = new OrdenPreparacion
            {
                IDOrdenPreparacion = nuevoIDOrden,
                Clientes = new List<Cliente>
        {
            new Cliente { IdCliente = idCliente, Prioridad = prioridad, Transportistas = new List<string> { transportista }}
        },
                Productos = productosOrden
            };

            ordenes.Add(nuevaOrden);
            return $"Orden {nuevoIDOrden} creada exitosamente.";
        }

        private string GenerarNuevoIDOrden() // actualice para que tome en cuenta el OrdenPreparacionAlmacen
        {
            int nuevoId = 1; // Valor predeterminado si no hay ordenes.

            // Acceder a las ordenes cargadas desde el archivo JSON
            var ordenesExistentes = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(o => o != null && o.IdOrdenPreparacion != null && o.IdOrdenPreparacion.Length >= 6) // Verificar que el objeto y la propiedad no sean nulos
                .Select(o => o.IdOrdenPreparacion) // Obtener los IDs completos (ej. OP030)
                .ToList();

            // Verificar si hay IDs existentes y calcular el nuevo ID
            if (ordenesExistentes.Count > 0)
            {
                // Extraer la parte numérica de los IDs (después de 'OP')
                var idsNumericos = ordenesExistentes
                    .Select(id => int.Parse(id.Substring(2))) // Obtener la parte numérica del ID (ej. 030)
                    .ToList();

                // Obtener el máximo valor y sumarle 1 para generar el siguiente ID
                nuevoId = idsNumericos.Max() + 1; // Sumar 1 al valor máximo encontrado
            }

            // Devolver el nuevo ID con formato OP000
            return "OP" + nuevoId.ToString("D3");
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

        public Cliente ClienteAnterior { get; set; }
    }
}