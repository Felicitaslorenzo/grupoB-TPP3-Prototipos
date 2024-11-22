using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.ConsultaStock
{
    public partial class ConsultaStockForm : Form
    {
        private ConsultaStockModel modelo = new();

        public ConsultaStockForm()
        {
            InitializeComponent();
        }

        private void listProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Comprobar si se ha seleccionado algún ítem
            if (listProducto.SelectedItems.Count > 0)
            {
                var selectedItem = listProducto.SelectedItems[0]; // Obtener el ítem seleccionado

                // Obtener el SKU del producto seleccionado
                string skuSeleccionado = selectedItem.Text;

                // Buscar el producto correspondiente
                var productoSeleccionado = modelo.BuscarProducto(new Producto { SKUProducto = skuSeleccionado }).FirstOrDefault();

                // Limpiar el ListView de inventario antes de agregar nuevos elementos
                listDetalle.Items.Clear();

                // Verificar si el producto existe
                if (productoSeleccionado != null)
                {
                    // Mostrar el inventario del producto seleccionado en el ListView de inventario
                    foreach (var inventario in productoSeleccionado.Inventario)
                    {
                        var listItem = new ListViewItem(inventario.IdDeposito); // ID del depósito
                        listItem.SubItems.Add(inventario.Ubicacion); // Ubicación
                        listItem.SubItems.Add(inventario.Cantidad.ToString()); // Cantidad
                        listDetalle.Items.Add(listItem);
                    }
                }
                else
                {
                    // Si el producto no existe
                    MessageBox.Show("Producto no encontrado.");
                }
            }
        }

        private void ConsultaStockForm_Load(object sender, EventArgs e)
        {
            // Crear un objeto Producto vacío para pasar al método (sin filtro)
            Producto productoBuscado = new Producto();

            // Llamar al método BuscarProducto pasando el objeto vacío
            var productos = modelo.BuscarProducto(productoBuscado);

            // Limpiar el ListView antes de agregar nuevos elementos
            listProducto.Items.Clear();

            // Crear listas para almacenar los valores únicos de cada campo
            var skuProductos = productos.Select(p => p.SKUProducto).Distinct().ToList();
            var descripciones = productos.Select(p => p.DescripcionProducto).Distinct().ToList();
            var clientes = productos.Select(p => p.IdCliente).Distinct().ToList();

            // Limpiar los ComboBox antes de agregar nuevos elementos
            comboSKUProducto.Items.Clear();
            comboDescripcionProducto.Items.Clear();
            comboCliente.Items.Clear();

            // Cargar los ComboBox con los valores únicos
            comboSKUProducto.Items.AddRange(skuProductos.ToArray());
            comboDescripcionProducto.Items.AddRange(descripciones.ToArray());
            comboCliente.Items.AddRange(clientes.ToArray());

            // Mostrar los productos en el ListView
            foreach (var producto in productos)
            {
                // Agregar los productos al ListView
                var listItem = new ListViewItem(producto.SKUProducto); // SKU en la primera columna
                listItem.SubItems.Add(producto.DescripcionProducto); // Descripción en la segunda columna
                listItem.SubItems.Add(producto.IdCliente); // Cliente en la tercera columna
                listItem.SubItems.Add(producto.TotalCantidad.ToString()); // TotalCantidad en la cuarta columna
                listProducto.Items.Add(listItem);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // Validar si se ha seleccionado algún filtro
            if (string.IsNullOrEmpty(comboSKUProducto.Text) &&
                string.IsNullOrEmpty(comboDescripcionProducto.Text) &&
                string.IsNullOrEmpty(comboCliente.Text))
            {
                MessageBox.Show("No se ha seleccionado ningún filtro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un objeto Producto con los filtros
            Producto productoFiltro = new Producto
            {
                SKUProducto = comboSKUProducto.Text,
                DescripcionProducto = comboDescripcionProducto.Text,
                IdCliente = comboCliente.Text
            };

            // Filtrar las órdenes usando el modelo, pasando el objeto productoFiltro
            var ordenesFiltradas = modelo.BuscarProducto(productoFiltro)
                .Where(o =>
                    (string.IsNullOrEmpty(productoFiltro.SKUProducto) || o.SKUProducto == productoFiltro.SKUProducto) &&
                    (string.IsNullOrEmpty(productoFiltro.DescripcionProducto) || o.DescripcionProducto == productoFiltro.DescripcionProducto) &&
                    (string.IsNullOrEmpty(productoFiltro.IdCliente) || o.IdCliente == productoFiltro.IdCliente))
                .ToList();

            // Limpiar el ListView antes de agregar los elementos filtrados
            listProducto.Items.Clear();

            // Mostrar los productos filtrados en el ListView
            foreach (var item in ordenesFiltradas)
            {
                // Agregar los productos al ListView
                var listItem = new ListViewItem(item.SKUProducto); // SKU en la primera columna
                listItem.SubItems.Add(item.DescripcionProducto); // Descripción en la segunda columna
                listItem.SubItems.Add(item.IdCliente); // Cliente en la tercera columna
                listItem.SubItems.Add(item.TotalCantidad.ToString()); // TotalCantidad en la cuarta columna
                listProducto.Items.Add(listItem);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            comboSKUProducto.SelectedIndex = -1;
            comboDescripcionProducto.SelectedIndex = -1;
            comboCliente.SelectedIndex = -1;

            // Recargar el ListView con todos los productos (sin filtros)
            Producto productoBuscado = new Producto(); // Objeto vacío para obtener todos los productos
            var productos = modelo.BuscarProducto(productoBuscado); // Buscar todos los productos

            // Limpiar el ListView antes de agregar nuevos elementos
            listProducto.Items.Clear();

            // Mostrar todos los productos en el ListView
            foreach (var producto in productos)
            {
                // Agregar los productos al ListView
                var listItem = new ListViewItem(producto.SKUProducto); // SKU en la primera columna
                listItem.SubItems.Add(producto.DescripcionProducto); // Descripción en la segunda columna
                listItem.SubItems.Add(producto.IdCliente); // Cliente en la tercera columna
                listItem.SubItems.Add(producto.TotalCantidad.ToString()); // TotalCantidad en la cuarta columna
                listProducto.Items.Add(listItem);
            }

            listDetalle.Items.Clear();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
