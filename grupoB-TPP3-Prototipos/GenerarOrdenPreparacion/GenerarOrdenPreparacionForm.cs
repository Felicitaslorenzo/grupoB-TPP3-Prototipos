using System;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;


namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion
{
    public partial class GenerarOrdenPreparacionForm : Form
    {
        private GenerarOrdenPreparacionModel modelo = new GenerarOrdenPreparacionModel();
        private List<OrdenPreparacion> Ordenes { get; set; }
        private List<ProductoOrden> productosOrden = new List<ProductoOrden>();


        public GenerarOrdenPreparacionForm()
        {
            InitializeComponent();
        }

        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            string idProducto = ProductoCombo.Text;
            int cantidad;

            // Verificar que la cantidad es un número válido
            if (int.TryParse(CantidadTextBox.Text, out cantidad))
            {
                // busco el producto en las órdenes de preparación
                bool productoEncontrado = false;
                string ubicacionProducto = string.Empty;
                string descripcionProducto = string.Empty;

                foreach (var orden in modelo.ordenes)
                {
                    foreach (var producto in orden.Productos)
                    {
                        if (producto.IDProducto == idProducto)
                        {
                            ubicacionProducto = producto.Ubicacion;
                            descripcionProducto = producto.DescripcionProducto; 
                            productoEncontrado = true;
                            break; 
                        }
                    }

                    if (productoEncontrado) break; 
                }

                // Verificar si el producto se encontró
                if (productoEncontrado)
                {
                    var nuevoProducto = new ProductoOrden
                    {
                        IDProducto = idProducto,
                        Cantidad = cantidad,
                        DescripcionProducto = descripcionProducto, 
                        Ubicacion = ubicacionProducto 
                    };

                    // crear lista de productos
                    var item = new ListViewItem(nuevoProducto.IDProducto);
                    item.SubItems.Add(nuevoProducto.DescripcionProducto);
                    item.SubItems.Add(nuevoProducto.Cantidad.ToString());
                    item.SubItems.Add(nuevoProducto.Ubicacion);

                    // agregar el nuevo producto a la lista
                    ProductosListView.Items.Add(item);

                    CantidadTextBox.Clear();
                    ProductoCombo.SelectedIndex = -1; 

                    MessageBox.Show($"El producto {nuevoProducto.DescripcionProducto} se ha agregado a la lista.");
                }
                else
                {
                    MessageBox.Show("El producto no se encontró en las órdenes de preparación.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida.");
            }
        }

        private void ActualizarListView(string idOrdenPreparacion)
        {
            ProductosListView.Items.Clear();

            // Busca la orden correspondiente
            var ordenActual = Ordenes.FirstOrDefault(o => o.IDOrdenPreparacion == idOrdenPreparacion);
            if (ordenActual != null)
            {
                // Agrega cada producto a la lista
                foreach (var producto in ordenActual.Productos)
                {
                    ListViewItem item = new ListViewItem(producto.IDProducto);
                    item.SubItems.Add(producto.DescripcionProducto);
                    item.SubItems.Add(producto.Cantidad.ToString());
                    item.SubItems.Add(producto.Ubicacion);
                    ProductosListView.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Orden no encontrada.");
            }
        }


        private void EliminarProductoButton_Click(object sender, EventArgs e)
        {
            // Verifica si hay algún elemento seleccionado
            if (ProductosListView.SelectedItems.Count > 0)
            {
                // Obtiene el producto seleccionado
                ListViewItem itemSeleccionado = ProductosListView.SelectedItems[0];

                ProductosListView.Items.Remove(itemSeleccionado);

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GenerarOrdenButton_Click(object sender, EventArgs e)
        {
            // Verificar si hay productos disponibles
            if (ProductosListView.Items.Count == 0)
            {
                MessageBox.Show("No hay productos disponibles para crear una orden.");
                return; 
            }

            // Verificar que se haya seleccionado un cliente, prioridad y transportista
            if (string.IsNullOrWhiteSpace(IdClienteCombo.Text) ||
                string.IsNullOrWhiteSpace(PrioridadComboBox.Text) ||
                string.IsNullOrWhiteSpace(TransportistaComboBox.Text))
            {
                MessageBox.Show("Por favor, selecciona un cliente, su prioridad y un transportista.");
                return; 
            }

           
            string nuevoIDOrden = GenerarNuevoIDOrden();

            List<ProductoOrden> productosOrden = new List<ProductoOrden>();

            foreach (ListViewItem productoItem in ProductosListView.Items)
            {
                var producto = new ProductoOrden
                {
                    IDProducto = productoItem.SubItems[0].Text, 
                    DescripcionProducto = productoItem.SubItems[1].Text, 
                    Cantidad = int.Parse(productoItem.SubItems[2].Text), 
                    Ubicacion = productoItem.SubItems[3].Text 
                };
                productosOrden.Add(producto);
            }

            // Crear la nueva orden
            var nuevaOrden = new OrdenPreparacion
            {
                IDOrdenPreparacion = nuevoIDOrden,
                Clientes = new List<Clientes>
        {
            new Clientes
            {
                IdCliente = IdClienteCombo.Text, 
                Prioridad = PrioridadComboBox.Text, 
                Transportista = TransportistaComboBox.Text 
            }
        },
                Productos = productosOrden 
            };

            // Agregar la nueva orden al modelo
            modelo.ordenes.Add(nuevaOrden);

            MessageBox.Show($"Orden {nuevoIDOrden} creada exitosamente.");

            ProductosListView.Items.Clear();

            // Limpiar los controles de selección
            IdClienteCombo.SelectedIndex = -1; 
            PrioridadComboBox.SelectedIndex = -1; 
            TransportistaComboBox.SelectedIndex = -1; 
        }

        // método para generar un nuevo ID de orden
        private string GenerarNuevoIDOrden()
        {
            int nuevoId = 1; // valor para la primera orden

            if (modelo.ordenes.Count > 0)
            {
                // obtener el último ID de orden existente
                var ultimaOrden = modelo.ordenes.Last();
                string ultimoIdOrden = ultimaOrden.IDOrdenPreparacion; 
                nuevoId = int.Parse(ultimoIdOrden.Substring(3)) + 1; 
            }

            return "ORD00" + nuevoId.ToString(); 
        }

        private void ProductosListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string clienteSeleccionado = ""; // almacena el cliente seleccionado

        private void ClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nuevoCliente = IdClienteCombo.SelectedItem.ToString();

            // si ya hay productos en la lista, verificar si el cliente ha cambiado
            if (ProductosListView.Items.Count > 0)
            {
                if (!string.IsNullOrEmpty(clienteSeleccionado) && clienteSeleccionado != nuevoCliente)
                {
                    ProductosListView.Items.Clear();
                    productosOrden.Clear(); 

                    MessageBox.Show("El cliente ha sido cambiado. Se han eliminado los productos agregados.");

                    CantidadTextBox.Clear();
                    ProductoCombo.SelectedIndex = -1;
                }
            }

            clienteSeleccionado = nuevoCliente;
        }


    }
}

