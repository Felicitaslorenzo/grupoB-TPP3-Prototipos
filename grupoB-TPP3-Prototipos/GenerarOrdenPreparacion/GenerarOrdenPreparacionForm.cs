using System;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;
using System.Linq; // Asegúrate de tener esta directiva


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
            // Obtener los valores de los controles
            string idProducto = ProductoCombo.Text; // Asumiendo que este ComboBox tiene los IDs de productos
            int cantidad;

            // Verificar que la cantidad es un número válido
            if (int.TryParse(CantidadTextBox.Text, out cantidad))
            {
                // Buscar el producto en las órdenes de preparación
                bool productoEncontrado = false;
                string ubicacionProducto = string.Empty;
                string descripcionProducto = string.Empty; // Variable para la descripción

                // Iterar sobre las órdenes de preparación
                foreach (var orden in modelo.ordenes)
                {
                    foreach (var producto in orden.Productos)
                    {
                        if (producto.IDProducto == idProducto)
                        {
                            ubicacionProducto = producto.Ubicacion;
                            descripcionProducto = producto.DescripcionProducto; // Obtener la descripción real
                            productoEncontrado = true;
                            break; // Salir del bucle interno si se encuentra el producto
                        }
                    }

                    if (productoEncontrado) break; // Salir del bucle externo si se encuentra el producto
                }

                // Verificar si el producto se encontró
                if (productoEncontrado)
                {
                    // Crear un nuevo producto para agregar al ListView
                    var nuevoProducto = new ProductoOrden
                    {
                        IDProducto = idProducto,
                        Cantidad = cantidad,
                        DescripcionProducto = descripcionProducto, // Usar la descripción encontrada
                        Ubicacion = ubicacionProducto // Usar la ubicación encontrada
                    };

                    // Crear el ListViewItem
                    var item = new ListViewItem(nuevoProducto.IDProducto);
                    item.SubItems.Add(nuevoProducto.DescripcionProducto);
                    item.SubItems.Add(nuevoProducto.Cantidad.ToString());
                    item.SubItems.Add(nuevoProducto.Ubicacion);

                    // Agregar el nuevo producto al ListView
                    ProductosListView.Items.Add(item);

                    // Limpiar los campos de entrada
                    CantidadTextBox.Clear();
                    ProductoCombo.SelectedIndex = -1; // Resetea el ComboBox si es necesario

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
            if (ProductosListView.Items.Count == 0)
            {
                MessageBox.Show("No hay productos disponibles para crear una orden.");
                return; // Salir si no hay productos
            }

            // Obtener el último ID de orden
            string nuevoIDOrden = GenerarNuevoIDOrden();

            // Crear una lista para almacenar los productos de la nueva orden
            List<ProductoOrden> productosOrden = new List<ProductoOrden>();

            // Recorrer los elementos del ListView y agregar los productos a la lista
            foreach (ListViewItem productoItem in ProductosListView.Items)
            {
                var producto = new ProductoOrden
                {
                    IDProducto = productoItem.SubItems[0].Text, // Suponiendo que el ID del producto está en la primera columna
                    DescripcionProducto = productoItem.SubItems[1].Text, // Suponiendo que la descripción está en la segunda columna
                    Cantidad = int.Parse(productoItem.SubItems[2].Text), // Suponiendo que la cantidad está en la tercera columna
                    Ubicacion = productoItem.SubItems[3].Text // Suponiendo que la ubicación está en la cuarta columna
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
                        IdCliente = "CLIENTE009", // Cambia esto según sea necesario
                        Prioridad = "Baja", // Cambia esto según sea necesario
                        Transportista = "Transportista I" // Cambia esto según sea necesario
                    }
                },
                Productos = productosOrden // Asignar la lista de productos extraída
            };

            // Agregar la nueva orden al modelo
            modelo.ordenes.Add(nuevaOrden);

            // Mostrar un mensaje de que la orden ha sido creada
            MessageBox.Show($"Orden {nuevoIDOrden} creada exitosamente.");
        }

        // Método para generar un nuevo ID de orden
        private string GenerarNuevoIDOrden()
        {
            int nuevoId = 1; // Valor por defecto para la primera orden

            // Verificar si ya hay órdenes en el modelo
            if (modelo.ordenes.Count > 0)
            {
                // Obtener el último ID de orden existente
                var ultimaOrden = modelo.ordenes.Last();
                string ultimoIdOrden = ultimaOrden.IDOrdenPreparacion; // Suponiendo que el ID es de la forma "ORD00X"
                nuevoId = int.Parse(ultimoIdOrden.Substring(3)) + 1; // Asumiendo que el ID es de la forma "ORD00X"
            }

            return "ORD00" + nuevoId.ToString(); // Formato del nuevo ID
        }

        private void ProductosListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

