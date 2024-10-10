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
        private Cliente clienteAnterior;

        public GenerarOrdenPreparacionForm()
        {
            InitializeComponent();
            modelo.CargarCliente(IdClienteCombo, TransportistaCombo, ProductoCombo);
            clienteAnterior = (Cliente)IdClienteCombo.SelectedItem;
            this.IdClienteCombo.SelectedIndexChanged += IdClienteCombo_SelectedIndexChanged;

            FechaOPPicker.MinDate = DateTime.Today.AddDays(1);

            //TODO: foreach cliente in clientes bla bla...
            //IdClienteCombo.Items.Add(cliente); //un objeto cliente.
        }

        private void FechaOPPicker_ValueChanged(object sender, EventArgs e)
        {

            //Validación de fecha

            DateTime fechaSeleccionada = FechaOPPicker.Value;
            DateTime fechaMinima = DateTime.Today.AddDays(1);

            if (fechaSeleccionada < fechaMinima)
            {
                MessageBox.Show("Por favor, selecciona una fecha a partir de mañana.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FechaOPPicker.Value = fechaMinima;
            }
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
                    if(cantidad<=0)
                    {
                        MessageBox.Show("La cantidad tiene que ser mayor a 0");
                    }
                    else
                    {
                        var nuevoProducto = new Producto
                        {
                            IDProducto = idProducto,
                            Cantidad = cantidad,
                            DescripcionProducto = resultadoProducto.Item2,
                            // Ubicacion = resultadoProducto.Item3
                        };


                        var item = new ListViewItem(nuevoProducto.IDProducto);
                        item.SubItems.Add(nuevoProducto.DescripcionProducto);
                        item.SubItems.Add(nuevoProducto.Cantidad.ToString());
                        // item.SubItems.Add(nuevoProducto.Ubicacion);
                        ProductosListView.Items.Add(item);

                        // Limpiar campos de entrada
                        CantidadTextBox.Clear();
                        ProductoCombo.SelectedIndex = -1;

                        MessageBox.Show($"El producto {nuevoProducto.DescripcionProducto} se ha agregado a la lista.");

                    }
                    
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

        private void IdClienteCombo_SelectedIndexChanged(object? sender, EventArgs e)
        {

            if (IdClienteCombo.SelectedItem == clienteAnterior) return;

            if (ProductosListView.Items.Count > 0)
            {
                var confirmacion = MessageBox.Show("El cliente ha sido cambiado. Se eliminarán los datos ingresados. ¿Está usted seguro?",
                                                    "Pampazon", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.No)
                {
                    IdClienteCombo.SelectedIndexChanged -= IdClienteCombo_SelectedIndexChanged;
                    IdClienteCombo.SelectedItem = clienteAnterior;
                    IdClienteCombo.SelectedIndexChanged += IdClienteCombo_SelectedIndexChanged;
                    return;
                }

                // si el usuario confirma, sen eliminan los productos
                ProductoCombo.Items.Clear();
                ProductosListView.Items.Clear();
            }

            // guarda el cliente recién seleccionado como el clienteAnterior
            if (IdClienteCombo.SelectedItem is Cliente nuevoCliente)
            {
                clienteAnterior = nuevoCliente;

                // carga los transportistas y productos del nuevo cliente
                modelo.CargarTransportistas(nuevoCliente, TransportistaCombo);

                var productosCliente = modelo.BuscarProductoCliente(nuevoCliente);

                // llenar el desplegable con los productos
                ProductoCombo.Items.Clear();
                foreach (var producto in productosCliente)
                {
                    ProductoCombo.Items.Add(producto);
                }
            }
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

