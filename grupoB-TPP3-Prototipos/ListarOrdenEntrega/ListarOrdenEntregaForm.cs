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
using grupoB_TPP3_Prototipos.ListarOrdenPreparacion;
using System.Linq;

namespace grupoB_TPP3_Prototipos.ListarOrdenEntrega
{
    public partial class ListarOrdenEntregaForm : Form
    {
        private ListarOrdenEntregaModel model = new();
        public ListarOrdenEntregaForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ListarOrdenEntregaForm_Load);
            BuscarButton.Click += BuscarButton_Click;

            FechaDesdeOEPicker.ValueChanged += FechaDesdeOEPicker_ValueChanged;
            FechaHastaOEPicker.ValueChanged += FechaHastaOEPicker_ValueChanged;
            VolverButton.Click += new EventHandler(VolverButton_Click);
        }

        private void ListarOrdenEntregaForm_Load(object sender, EventArgs e)
        {
            var ordenesEntrega = model.ObtenerOrdenesEntrega();

            if (ordenesEntrega == null || !ordenesEntrega.Any())
            {
                MessageBox.Show("No se encontraron órdenes de entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarOrdenesEnListView(ordenesEntrega);

            // Extraer datos para cada ComboBox
            var idsClientes = ordenesEntrega.Select(o => o.IdCliente).Distinct().ToList();
            var idsOrdenesEntrega = ordenesEntrega.Select(o => o.IdOrden).Distinct().ToList();
            var estadosOrdenEntrega = ordenesEntrega.Select(o => o.Estado).Distinct().ToList();

            FechaDesdeOEPicker.Format = DateTimePickerFormat.Custom;
            FechaDesdeOEPicker.CustomFormat = " ";
            FechaHastaOEPicker.Format = DateTimePickerFormat.Custom;
            FechaHastaOEPicker.CustomFormat = " ";

            // Cargar datos en los ComboBox
            IdClienteCombo.Items.Clear();
            foreach (var id in idsClientes)
            {
                IdClienteCombo.Items.Add(id);
            }

            IdOrdenCombo.Items.Clear();
            foreach (var id in idsOrdenesEntrega)
            {
                IdOrdenCombo.Items.Add(id);
            }

            EstadoCombo.Items.Clear();
            foreach (var estado in estadosOrdenEntrega)
            {
                EstadoCombo.Items.Add(estado);
            }
        }

        private void CargarOrdenesEnListView(IEnumerable<OrdenEntrega> ordenes)
        {
            ListarOrdenEntregaList.Items.Clear();

            foreach (var orden in ordenes)
            {
                var item = new ListViewItem(orden.IdOrden);
                item.SubItems.Add(orden.FechaEmision.ToString("yyyy-MM-dd"));
                item.SubItems.Add(orden.Estado);
                item.SubItems.Add(orden.FechaEstado.ToString("yyyy-MM-dd"));

                ListarOrdenEntregaList.Items.Add(item);
            }
        }

        private void FechaDesdeOEPicker_ValueChanged(object sender, EventArgs e)
        {
            FechaDesdeOEPicker.Format = DateTimePickerFormat.Short;
        }

        private void FechaHastaOEPicker_ValueChanged(object sender, EventArgs e)
        {
            FechaHastaOEPicker.Format = DateTimePickerFormat.Short;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdOrdenCombo.Text) &&
                string.IsNullOrEmpty(IdClienteCombo.Text) &&
                string.IsNullOrEmpty(EstadoCombo.Text) &&
                !FechaDesdeOEPicker.Checked &&
                !FechaHastaOEPicker.Checked)
            {
                MessageBox.Show("No se ha seleccionado ningún filtro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ordenesEntrega = model.ObtenerOrdenesEntrega();

            // Aplicar los filtros
            var ordenesFiltradas = ordenesEntrega.AsEnumerable();

            if (!string.IsNullOrEmpty(IdOrdenCombo.Text))
            {
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.IdOrden == IdOrdenCombo.Text);
            }

            if (!string.IsNullOrEmpty(IdClienteCombo.Text))
            {
                int idClienteSeleccionado = int.Parse(IdClienteCombo.Text);
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.IdCliente == idClienteSeleccionado);
            }

            if (!string.IsNullOrEmpty(EstadoCombo.Text))
            {
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.Estado == EstadoCombo.Text);
            }


            if (FechaDesdeOEPicker.Checked && FechaHastaOEPicker.Checked)
            {
                DateTime fechaDesde = FechaDesdeOEPicker.Value;
                DateTime fechaHasta = FechaHastaOEPicker.Value;
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.FechaEmision >= fechaDesde && orden.FechaEmision <= fechaHasta);
            }
            else if (FechaDesdeOEPicker.Checked)
            {
                DateTime fechaDesde = FechaDesdeOEPicker.Value;
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.FechaEmision >= fechaDesde);
            }
            else if (FechaHastaOEPicker.Checked)
            {
                DateTime fechaHasta = FechaHastaOEPicker.Value;
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.FechaEmision <= fechaHasta);
            }

            CargarOrdenesEnListView(ordenesFiltradas);

            if (ListarOrdenEntregaList.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron órdenes de entrega con los criterios seleccionados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}







