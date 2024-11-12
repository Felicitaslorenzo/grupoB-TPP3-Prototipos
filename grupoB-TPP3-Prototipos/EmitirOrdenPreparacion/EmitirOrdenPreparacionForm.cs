using System;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using grupoB_TPP3_Prototipos.MenuOrdenesPreparacion;


namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion
{
    public partial class EmitirOrdenPreparacionForm : Form
    {
        private EmitirOrdenPreparacionModel modelo = new EmitirOrdenPreparacionModel();

        public EmitirOrdenPreparacionForm()
        {
            InitializeComponent();
            modelo.CargarCliente(IdClienteCombo, TransportistaCombo, ProductoCombo);
            PrioridadComboBox.Items.AddRange(modelo.ObtenerPrioridad().ToArray());
            // clienteAnterior = (Cliente)IdClienteCombo.SelectedItem;
            this.IdClienteCombo.SelectedIndexChanged += IdClienteCombo_SelectedIndexChanged;

            FechaOPPicker.MinDate = DateTime.Today.AddDays(1);

            //TODO: foreach cliente in clientes bla bla...
            //IdClienteCombo.Items.Add(cliente); //un objeto cliente.
        }

        private void FechaOPPicker_ValueChanged(object sender, EventArgs e)
        {
           
            DateTime fechaSeleccionada = FechaOPPicker.Value;
            DateTime fechaMinima = DateTime.Today.AddDays(1);

            //if (fechaSeleccionada < fechaMinima)
            //{
            //    MessageBox.Show("Por favor, selecciona una fecha a partir de mañana.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    FechaOPPicker.Value = fechaMinima;
            //}
        }

        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            if (!FechaOPPicker.Checked)
            {
                MessageBox.Show("Debe seleccionar una fecha de entrega.", "Fecha de entrega requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idProducto = ProductoCombo.Text;
            int cantidad;

            if (int.TryParse(CantidadTextBox.Text, out cantidad))
            {
                var resultadoProducto = modelo.BuscarProductoEnOrdenes(idProducto);

                if (resultadoProducto.Item1)
                {
                    if (cantidad <= 0)
                    {
                        MessageBox.Show("La cantidad tiene que ser mayor a 0");
                        return;
                    }

                    // Obtener la cantidad total que ya se ha solicitado para este producto en la orden
                    int cantidadTotalEnOrden = ObtenerCantidadTotalEnOrden(idProducto);
                    int cantidadDisponible = modelo.ObtenerCantidadDisponible(idProducto); // Asegúrate de que este método exista y funcione como se espera

                    if (cantidadTotalEnOrden + cantidad > cantidadDisponible)
                    {
                        MessageBox.Show(
                             $"Error: No hay suficiente stock disponible \nCantidad solicitada: {cantidad} \nCantidad disponible: {cantidadDisponible - cantidadTotalEnOrden}",
                                 "Cantidad excedida",
                                 MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                         );
                        return;
                    }

                    // Si la cantidad es válida, agregar el producto a la orden
                    var nuevoProducto = new Producto
                    {
                        IDProducto = idProducto,
                        Cantidad = cantidad,
                        DescripcionProducto = resultadoProducto.Item2,
                    };

                    var item = new ListViewItem(nuevoProducto.IDProducto);
                    item.SubItems.Add(nuevoProducto.DescripcionProducto);
                    item.SubItems.Add(nuevoProducto.Cantidad.ToString());
                    ProductosListView.Items.Add(item);

                    CantidadTextBox.Clear();
                    ProductoCombo.SelectedIndex = -1;
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

        private int ObtenerCantidadTotalEnOrden(string idProducto)
        {
            int cantidadTotal = 0;
            foreach (ListViewItem item in ProductosListView.Items)
            {
                if (item.SubItems[0].Text == idProducto)
                {
                    cantidadTotal += int.Parse(item.SubItems[2].Text); // SubItem[2] es donde se almacena la cantidad
                }
            }
            return cantidadTotal;
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
            // Verifica si hay productos en el ListView
            if (ProductosListView.Items.Count == 0)
            {
                MessageBox.Show("No hay productos disponibles para crear una orden.");
                return;
            }

            // Verifica si se han seleccionado un cliente, prioridad y transportista
            if (string.IsNullOrWhiteSpace(IdClienteCombo.Text) ||
                string.IsNullOrWhiteSpace(PrioridadComboBox.Text) ||
                string.IsNullOrWhiteSpace(TransportistaCombo.Text))
            {
                MessageBox.Show("Por favor, selecciona un cliente, su prioridad y un transportista.");
                return;
            }

            // Llama al método GenerarNuevaOrden del modelo para generar una nueva orden
            var resultado = modelo.GenerarNuevaOrden(
                IdClienteCombo.Text,
                PrioridadComboBox.Text,  // Pasa la prioridad seleccionada
                TransportistaCombo.Text,
                ProductosListView
            );

            // Muestra un mensaje con el resultado de la operación
            MessageBox.Show(resultado);

            // Limpia los controles después de generar la orden
            ProductosListView.Items.Clear();
            IdClienteCombo.SelectedIndex = -1;
            PrioridadComboBox.SelectedIndex = -1;
            TransportistaCombo.SelectedIndex = -1;
            FechaOPPicker.Value = DateTime.Today.AddDays(1);
            FechaOPPicker.Checked = false;
        }

        private void IdClienteCombo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (IdClienteCombo.SelectedItem == modelo.ClienteAnterior) return;

            if (ProductosListView.Items.Count > 0)
            {
                var confirmacion = MessageBox.Show("El cliente ha sido cambiado. Se eliminarán los datos ingresados. ¿Está usted seguro?",
                                                    "Pampazon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.No)
                {
                    IdClienteCombo.SelectedIndexChanged -= IdClienteCombo_SelectedIndexChanged;
                    IdClienteCombo.SelectedItem = modelo.ClienteAnterior;
                    IdClienteCombo.SelectedIndexChanged += IdClienteCombo_SelectedIndexChanged;
                    return;
                }

                // si el usuario confirma, se eliminan los productos
                ProductoCombo.Items.Clear();
                ProductosListView.Items.Clear();

                // Limpiar campos "Prioridad" y "Fecha de entrega"
                PrioridadComboBox.SelectedIndex = -1;
                FechaOPPicker.Value = DateTime.Today.AddDays(1);
                FechaOPPicker.Checked = false;
            }

            // guarda el cliente recién seleccionado como el clienteAnterior
            if (IdClienteCombo.SelectedItem is Cliente nuevoCliente)
            {
                modelo.ClienteAnterior = nuevoCliente;

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
                //MessageBox.Show($"Producto seleccionado: {productoId}");
            }
        }

        private void EmitirOrdenPreparacionForm_Load(object sender, EventArgs e)
        {

        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

