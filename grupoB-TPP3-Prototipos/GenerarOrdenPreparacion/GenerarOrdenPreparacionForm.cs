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
            CargarProductos();
        }

        private void CargarProductos()
        {
            // Limpiar el ListView antes de cargar nuevos productos
            ProductosListView.Items.Clear();

            // Iterar sobre cada orden en el modelo
            foreach (var orden in modelo.ordenes)
            {
                // Iterar sobre cada producto en la orden
                foreach (var producto in orden.Productos)
                {
                    ListViewItem item = new ListViewItem(producto.IDProducto);
                    item.SubItems.Add(producto.DescripcionProducto);
                    item.SubItems.Add(producto.Cantidad.ToString());
                    item.SubItems.Add(producto.Ubicacion);
                    // Agregar el item al ListView
                    ProductosListView.Items.Add(item);
                }
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
            // Verifica si hay algún elemento seleccionado
            if (ProductosListView.SelectedItems.Count > 0)
            {
                // Obtiene el elemento seleccionado
                ListViewItem itemSeleccionado = ProductosListView.SelectedItems[0];

                // Elimina el elemento del ListView
                ProductosListView.Items.Remove(itemSeleccionado);

                // Opcional: Aquí podrías realizar alguna acción adicional, como
                // actualizar el modelo de datos, si es necesario.
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GenerarOrdenButton_Click(object sender, EventArgs e)
        {

        }

        private void ProductosListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

