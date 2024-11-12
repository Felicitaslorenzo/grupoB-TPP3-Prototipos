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
            FechaDesdeOSPicker.ValueChanged += FechaDesdeOSPicker_ValueChanged;
            FechaHastaOSPicker.ValueChanged += FechaHastaOSPicker_ValueChanged;
            ListarOrdenSeleccionList.SelectedIndexChanged += ListarOrdenSeleccionList_SelectedIndexChanged; // Asegúrate de que este evento esté asociado
        }


        private void FechaDesdeOSPicker_ValueChanged(object? sender, EventArgs e)
        {
            FechaDesdeOSPicker.Format = DateTimePickerFormat.Short;
        }

        private void FechaHastaOSPicker_ValueChanged(object? sender, EventArgs e)
        {
            FechaHastaOSPicker.Format = DateTimePickerFormat.Short;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            // Obtener los valores seleccionados
            string idOrdenSeleccionada = IdOrdenSeleccionCombo.Text;
            DateTime fechaSeleccionada = FechaDesdeOSPicker.Value.Date;  // Solo fecha sin hora
            DateTime fechaHSeleccionada = FechaHastaOSPicker.Value.Date;  // Solo fecha sin hora

            // Validar si al menos un filtro está activo
            if (string.IsNullOrEmpty(idOrdenSeleccionada) && !FechaDesdeOSPicker.Checked && !FechaHastaOSPicker.Checked)
            {
                MessageBox.Show("No se ha seleccionado ningún filtro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que la fecha hasta no sea menor que la fecha desde
            if (FechaDesdeOSPicker.Checked && FechaHastaOSPicker.Checked && fechaHSeleccionada < fechaSeleccionada)
            {
                MessageBox.Show("La fecha hasta no puede ser menor que la fecha desde", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ordenesSeleccion = modelo.OrdenesSeleccionadas;

            // Aplicar los filtros
            var ordenesFiltradas = ordenesSeleccion.AsEnumerable();

            if (!string.IsNullOrEmpty(idOrdenSeleccionada))
            {
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.IdOrdenSeleccion == idOrdenSeleccionada);
            }

            // Aplicar filtros de fechas
            if (FechaDesdeOSPicker.Checked && FechaHastaOSPicker.Checked)
            {
                // Filtrar por fecha exacta de FechaEmision y FechaEstado
                ordenesFiltradas = ordenesFiltradas.Where(orden =>
                    orden.FechaEmision.Date == fechaSeleccionada && orden.FechaEstado.Date == fechaHSeleccionada);
            }
            else if (FechaDesdeOSPicker.Checked)
            {
                // Filtrar solo por FechaEmision
                ordenesFiltradas = ordenesFiltradas.Where(orden =>
                    orden.FechaEmision.Date == fechaSeleccionada);
            }
            else if (FechaHastaOSPicker.Checked)
            {
                // Filtrar solo por FechaEstado
                ordenesFiltradas = ordenesFiltradas.Where(orden =>
                    orden.FechaEstado.Date == fechaHSeleccionada);
            }

            // Limpiar la lista antes de agregar los elementos filtrados
            ListarOrdenSeleccionList.Items.Clear();

            // Verificar si no se encontraron resultados
            if (!ordenesFiltradas.Any())
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

            // Cargar la opción vacía
            IdOrdenSeleccionCombo.Items.Add(string.Empty); // Opción vacía

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
            // Limpiar la lista de órdenes de preparación antes de cargar los nuevos
            listOrdenPreparacion.Items.Clear();

            // Verificar si hay una selección
            if (ListarOrdenSeleccionList.SelectedItems.Count > 0)
            {
                // Obtener la orden seleccionada (primer elemento seleccionado)
                var idOrdenSeleccionada = ListarOrdenSeleccionList.SelectedItems[0].Text;

                // Buscar la orden en el modelo de datos
                var ordenSeleccionada = modelo.OrdenesSeleccionadas.FirstOrDefault(o => o.IdOrdenSeleccion == idOrdenSeleccionada);

                if (ordenSeleccionada != null)
                {
                    // Cargar las órdenes de preparación relacionadas a la orden seleccionada
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
                        item.Text = producto.Cantidad.ToString(); // Agregar la cantidad como subitem
                        item.SubItems.Add(producto.DescripcionProducto); // Suponiendo que aquí agregas la descripción del producto

                        // Agregar el item a la lista
                        ProductosList.Items.Add(item);
                    }
                }
            }
        }
    }
}
