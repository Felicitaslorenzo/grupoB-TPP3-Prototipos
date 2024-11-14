using System;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using grupoB_TPP3_Prototipos.MenuOrdenesPreparacion;
using grupoB_TPP3_Prototipos.Almacenes;


namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion
{
    public partial class EmitirOrdenPreparacionForm : Form
    {
        private EmitirOrdenPreparacionModel modelo = new EmitirOrdenPreparacionModel();

        public EmitirOrdenPreparacionForm()
        {
            InitializeComponent();
            CargarCliente(IdClienteCombo, TransportistaCombo, ProductoCombo);
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
                    int cantidadDisponible = modelo.ObtenerCantidadDisponible(idProducto); 

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
                    MessageBox.Show("Seleccione un producto.");
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
            // Validaciones iniciales
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

            // Extraer los productos del ListView y convertirlos en una lista de productos
            List<Producto> productosOrden = new List<Producto>();
            foreach (ListViewItem productoItem in ProductosListView.Items)
            {
                if (int.TryParse(productoItem.SubItems[2].Text, out int cantidad))
                {
                    productosOrden.Add(new Producto
                    {
                        IDProducto = productoItem.SubItems[0].Text,
                        DescripcionProducto = productoItem.SubItems[1].Text,
                        Cantidad = cantidad
                    });
                }
                else
                {
                    MessageBox.Show($"Error: La cantidad para el producto {productoItem.SubItems[1].Text} no es válida.");
                    return;
                }
            }

            // Crear la orden con ayuda del modelo
            OrdenPreparacion nuevaOrden = modelo.CrearOrdenPreparacion(
                IdClienteCombo.Text,
                PrioridadComboBox.Text,
                TransportistaCombo.Text,
                productosOrden
            );

            // Asegurarse de que la fecha seleccionada es válida
            DateTime fechaEntregaSeleccionada = FechaOPPicker.Value; // Obtener la fecha seleccionada del DateTimePicker

            // Convertirla a OrdenPreparacionEnt
            OrdenPreparacionEnt nuevaOrdenEnt = modelo.ConvertirOrdenPreparacionEnt(
                nuevaOrden,
                TransportistaCombo.Text,
                PrioridadComboBox.Text,
                fechaEntregaSeleccionada // Pasar la fecha seleccionada
            );

            // Guardar la orden usando el modelo
            modelo.GuardarOrdenPreparacion(nuevaOrdenEnt);

            // Mostrar mensaje de éxito
            MessageBox.Show($"Orden {nuevaOrden.IDOrdenPreparacion} creada exitosamente.");

            // Limpiar controles
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
                CargarTransportistas(nuevoCliente, TransportistaCombo);

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

        // Método que carga los clientes en el ComboBox
        internal void CargarCliente(ComboBox IdClienteCombo, ComboBox TransportistaCombo, ComboBox ProductosCombo)
        {
            var clientes = modelo.ObtenerCliente();

            // Verifica si los clientes están siendo obtenidos correctamente
            if (clientes == null || clientes.Count == 0)
            {
                MessageBox.Show("No se encontraron clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                    // CargarTransportistas(selectedCliente, TransportistaCombo);
                    CargarProductos(selectedCliente, ProductosCombo);
                }
            };
        }


        // Método que carga los transportistas del cliente seleccionado
        internal void CargarTransportistas(Cliente cliente, ComboBox TransportistaCombo)
        {
            TransportistaCombo.Items.Clear();

            // Cargar todos los transportistas del cliente seleccionado
            foreach (var transportista in cliente.Transportistas)
            {
                TransportistaCombo.Items.Add(transportista);
            }

            // No establecer ninguna opción seleccionada, dejar el combo vacío
            // TransportistaCombo.SelectedIndex = -1;
        }

        // Método que carga los productos del cliente seleccionado
        internal void CargarProductos(Cliente cliente, ComboBox ProductosCombo)
        {
            ProductosCombo.Items.Clear();

            // Carga los productos devueltos por la función BuscarProductoCliente
            var productos = modelo.BuscarProductoCliente(cliente);
            foreach (var producto in productos)
            {
                ProductosCombo.Items.Add(producto);
            }

            ProductosCombo.DisplayMember = "IDProducto";  // Mostrar el ID del producto
        }
    }
}

