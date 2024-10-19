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

namespace grupoB_TPP3_Prototipos.ListarOrdenSeleccion
{
    public partial class ListarOrdenSeleccionForm : Form
    {
        private ListarOrdenSeleccionModel modelo = new();

        public ListarOrdenSeleccionForm()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            // Obtener los valores seleccionados
            string idOrdenSeleccionada = IdOrdenSeleccionCombo.Text;
            DateTime fechaSeleccionada = FechaDesdeOSPicker.Value.Date;
            DateTime fechaHSeleccionada = FechaHastaOSPicker.Value.Date;

            // Validar si al menos un filtro está activo
            if (string.IsNullOrEmpty(idOrdenSeleccionada) && !FechaDesdeOSPicker.Checked)
            {
                MessageBox.Show("Por favor, selecciona al menos un filtro.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Filtrar OrdenesSeleccionadasList basado en los valores seleccionados
            var ordenesFiltradas = modelo.OrdenesSeleccionadas.Where(o =>
                (string.IsNullOrEmpty(idOrdenSeleccionada) || o.IdOrdenSeleccion == idOrdenSeleccionada) &&
                (!FechaDesdeOSPicker.Checked || o.FechaEmision.Date >= fechaSeleccionada &&
                (!FechaHastaOSPicker.Checked || o.FechaEstado.Date >= fechaHSeleccionada)) // Ajusta aquí según tu lógica
            ).ToList();

            // Limpiar la lista antes de agregar los elementos filtrados
            ListarOrdenSeleccionList.Items.Clear();

            // Verificar si no se encontraron resultados
            if (ordenesFiltradas.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados con los filtros seleccionados.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Agregar los elementos filtrados a la lista
            foreach (var ordenSeleccion in ordenesFiltradas)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ordenSeleccion.IdOrdenSeleccion;
                item.SubItems.Add(ordenSeleccion.FechaEmision.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ordenSeleccion.FechaEstado.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ordenSeleccion.Estado);

                ListarOrdenSeleccionList.Items.Add(item);
            }
        }

        private void ListarOrdenSeleccionForm_Load(object sender, EventArgs e)
        {
            var ordenesSeleccion = modelo.OrdenesSeleccionadas;

            // Extraer datos para cada ComboBox sin duplicados
            var idOrdenesSeleccion = ordenesSeleccion.Select(o => o.IdOrdenSeleccion).Distinct();
            var fechasEmision = ordenesSeleccion.Select(o => o.FechaEmision).Distinct();
            var fechasEstado = ordenesSeleccion.Select(o => o.FechaEstado).Distinct();

            // Cargar datos en los ComboBox
            IdOrdenSeleccionCombo.Items.AddRange(idOrdenesSeleccion.ToArray());
            // Si tienes otros ComboBoxes para fechas, deberías hacer lo mismo

            // Llenar ListView
            ListarOrdenSeleccionList.Items.Clear(); // Limpiar antes de llenar
            foreach (var orden in ordenesSeleccion)
            {
                ListViewItem item = new ListViewItem
                {
                    Text = orden.IdOrdenSeleccion.ToString(),
                    SubItems =
            {
                orden.FechaEmision.ToString("dd/MM/yyyy"),
                orden.FechaEstado.ToString("dd/MM/yyyy"),
                orden.Estado
            }
                };

                ListarOrdenSeleccionList.Items.Add(item);
            }
        }

        private void VolverListaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarOrdenSeleccionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay una selección
            if (ListarOrdenSeleccionList.SelectedItems.Count > 0)
            {
                // Obtener la orden seleccionada (primer elemento seleccionado)
                var idOrdenSeleccionada = ListarOrdenSeleccionList.SelectedItems[0].Text;

                // Buscar la orden en el modelo de datos
                var ordenSeleccionada = modelo.OrdenesSeleccionadas.FirstOrDefault(o => o.IdOrdenSeleccion == idOrdenSeleccionada);

                if (ordenSeleccionada != null)
                {
                    // Limpiar la lista de productos antes de cargar los nuevos
                    listOrdenPreparacion.Items.Clear();

                    // Cargar los productos relacionados a la orden seleccionada
                    foreach (var ordenPreparacion in ordenSeleccionada.OrdenesPreparacion)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = ordenPreparacion.IdOrden;
                        item.SubItems.Add(ordenPreparacion.IdCliente);
                        item.SubItems.Add(ordenPreparacion.Transportista);

                        listOrdenPreparacion.Items.Add(item);
                    }
                }
            }
        }

        private void ProductosList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listOrdenPreparacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay una selección
            if (listOrdenPreparacion.SelectedItems.Count > 0)
            {
                // Obtener la orden de preparación seleccionada
                var idOrdenPreparacionSeleccionada = listOrdenPreparacion.SelectedItems[0].Text;

                // Buscar la orden de preparación en el modelo de datos
                var ordenPreparacionSeleccionada = modelo.OrdenesSeleccionadas
                    .SelectMany(o => o.OrdenesPreparacion) // Aplana la lista de órdenes de preparación
                    .FirstOrDefault(op => op.IdOrden == idOrdenPreparacionSeleccionada);

                if (ordenPreparacionSeleccionada != null)
                {
                    // Limpiar la lista de productos antes de cargar los nuevos
                    ProductosList.Items.Clear();

                    // Cargar los productos relacionados a la orden de preparación seleccionada
                    foreach (var producto in ordenPreparacionSeleccionada.Productos)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = producto.DescripcionProducto; // Suponiendo que aquí agregas la descripción del producto
                        item.SubItems.Add(producto.Cantidad.ToString()); // Agregar la cantidad como subitem

                        // Agregar el item a la lista
                        ProductosList.Items.Add(item);
                    }
                }
            }
        }
    }
}
