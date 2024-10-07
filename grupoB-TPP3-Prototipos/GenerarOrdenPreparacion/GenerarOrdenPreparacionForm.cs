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

        public GenerarOrdenPreparacionForm()
        {
            InitializeComponent();
            //TODO: cargar el combo de clientes.
            modelo.CargarCliente(IdClienteCombo, TransportistaCombo, ProductoCombo);
            //TODO: foreach cliente in clientes bla bla...
            //IdClienteCombo.Items.Add(cliente); //un objeto cliente.
        }

        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            string idProducto = ProductoCombo.Text;
            int cantidad;

            // Validación de cantidad
            if (int.TryParse(CantidadTextBox.Text, out cantidad))
            {
                // Llamada al modelo para verificar si el producto existe en las órdenes
                var resultadoProducto = modelo.BuscarProductoEnOrdenes(idProducto);

                if (resultadoProducto.Item1)
                {
                    var nuevoProducto = new Producto
                    {
                        IDProducto = idProducto,
                        Cantidad = cantidad,
                        DescripcionProducto = resultadoProducto.Item2,
                        Ubicacion = resultadoProducto.Item3
                    };


                    var item = new ListViewItem(nuevoProducto.IDProducto);
                    item.SubItems.Add(nuevoProducto.DescripcionProducto);
                    item.SubItems.Add(nuevoProducto.Cantidad.ToString());
                    item.SubItems.Add(nuevoProducto.Ubicacion);
                    ProductosListView.Items.Add(item);

                    // Limpiar campos de entrada
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

        private void EliminarProductoButton_Click(object sender, EventArgs e)
        {
            if (ProductosListView.SelectedItems.Count > 0)
            {
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

            if (ProductosListView.Items.Count == 0)
            {
                MessageBox.Show("No hay productos disponibles para crear una orden.");
                return;
            }

            if (string.IsNullOrWhiteSpace(IdClienteCombo.Text) ||
                string.IsNullOrWhiteSpace(PrioridadComboBox.Text) ||
                string.IsNullOrWhiteSpace(TransportistaCombo.Text))
            {
                MessageBox.Show("Por favor, selecciona un cliente, su prioridad y un transportista.");
                return;
            }


            var resultado = modelo.GenerarNuevaOrden(IdClienteCombo.Text, PrioridadComboBox.Text, TransportistaCombo.Text, ProductosListView);

            MessageBox.Show(resultado);

            // limpiar controles después de crear la orden
            ProductosListView.Items.Clear();
            IdClienteCombo.SelectedIndex = -1;
            PrioridadComboBox.SelectedIndex = -1;
            TransportistaCombo.SelectedIndex = -1;
        }

        private void ClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: confirmar y dar la posibilidad de cancelar.
            var confirmacion = MessageBox.Show("El cliente ha sido cambiado. Se eliminar los datos ingresados. ¿Está ud. seguro?", "Pampazon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.No)
            {
                return;
            }

            ProductoCombo.Items.Clear();
            ProductosListView.Items.Clear();

            if (IdClienteCombo.SelectedItem == null) return;

            Cliente nuevoCliente = (Cliente)IdClienteCombo.SelectedItem;
            var productosCliente = modelo.BuscarProductoCliente(nuevoCliente);

            foreach (var producto in productosCliente)
            {
                ProductoCombo.Items.Add(producto);
            }

            //ejemplo: ver producto seleccionado:
            //var prodSel = (Producto)ProductoCombo.SelectedItem;
        }

        private void ProductosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si hay algún elemento seleccionado
            if (ProductosListView.SelectedItems.Count > 0)
            {
                var selectedItem = ProductosListView.SelectedItems[0];
                string productoId = selectedItem.SubItems[0].Text;
                MessageBox.Show($"Producto seleccionado: {productoId}");
            }
        }

        private void GenerarOrdenPreparacionForm_Load(object sender, EventArgs e)
        {

        }
    }
}

