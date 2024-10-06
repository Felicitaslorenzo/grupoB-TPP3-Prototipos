using System;
using System.Reflection;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion
{
    public partial class GenerarOrdenPreparacionForm : Form
    {
        private GenerarOrdenPreparacionModel modelo = new GenerarOrdenPreparacionModel();
        private List<OrdenPreparacion> Ordenes { get; set; }

        public GenerarOrdenPreparacionForm()
        {
            InitializeComponent();
            CargarOrdenes();
        }

        private void CargarOrdenes()
        {
            foreach (var orden in modelo.ordenes)
            {
                ListViewItem item = new ListViewItem(orden.IDOrdenPreparacion);
                item.SubItems.Add(orden.IdCliente);
                item.SubItems.Add(orden.Prioridad);
                item.SubItems.Add(orden.Transportista);
                // Puedes agregar más subitems según sea necesario
                ProductosListView.Items.Add(item); // Asegúrate de que "OrdenesListView" sea el nombre correcto de tu ListView
            }
        }


        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la orden seleccionada (puede ser de un ComboBox, TextBox, etc.)
            string idOrdenPreparacion = "ORD001"; // Cambia esto según tu lógica para obtener la orden correcta

            // Encuentra la orden correspondiente
            var ordenActual = Ordenes.FirstOrDefault(o => o.IDOrdenPreparacion == idOrdenPreparacion);
            if (ordenActual != null)
            {
                // Crea un nuevo producto a partir de los datos ingresados
                var nuevoProducto = new ProductoOrden
                {
                    IDProducto = ProductoCombo.SelectedItem.ToString(), // Asumiendo que el ComboBox tiene el ID del producto
                    DescripcionProducto = "Descripción del Producto", // Puede obtenerse de otro lugar
                    Cantidad = int.Parse(CantidadTextBox.Text), // Asegúrate de manejar excepciones si no es un número
                    Ubicacion = "Ubicación del Producto" // También puede obtenerse de otro lugar
                };

                // Agrega el nuevo producto a la lista de productos de la orden
                ordenActual.Productos.Add(nuevoProducto);

                // Actualiza el ListView para reflejar el cambio
                ActualizarListView(idOrdenPreparacion);
            }
            else
            {
                MessageBox.Show("Orden no encontrada.");
            }
        }

        private void ActualizarListView(string idOrdenPreparacion)
        {
            // Limpia los items actuales en el ListView
            ProductosListView.Items.Clear();

            // Busca la orden correspondiente
            var ordenActual = Ordenes.FirstOrDefault(o => o.IDOrdenPreparacion == idOrdenPreparacion);
            if (ordenActual != null)
            {
                // Agrega cada producto a la lista de vista
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

        }

        private void GenerarOrdenButton_Click(object sender, EventArgs e)
        {

        }

        private void ProductosListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

