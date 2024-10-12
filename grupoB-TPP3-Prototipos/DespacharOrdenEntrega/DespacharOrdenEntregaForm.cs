using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.DespacharOrdenEntrega
{
    public partial class DespacharOrdenEntregaForm : Form
    {
        private DespacharOrdenEntregaModel _model;

        public DespacharOrdenEntregaForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(DespacharOrdenEntregaForm_Load);
            BuscarButton.Click += new EventHandler(BuscarButton_Click);
            GenerarOrdenDeDespachoButton.Click += new EventHandler(GenerarOrdenDeDespachoButton_Click);
            VolverButton.Click += new EventHandler(VolverButton_Click);
            GenerarOrdenDeDespachoButton.Enabled = false;
            ListarOrdenDespacharBuscarList.SelectedIndexChanged += new EventHandler(ListarOrdenDespacharBuscarList_SelectedIndexChanged);
            ListarOrdenDespacharBuscarList.MultiSelect = true; 
            ListarOrdenDespacharBuscarList.FullRowSelect = true; 

        }
        private void ListarOrdenDespacharBuscarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListarOrdenDespacharBuscarList.SelectedItems.Count > 0)
            {
                GenerarOrdenDeDespachoButton.Enabled = true;
            }
            else
            {
                GenerarOrdenDeDespachoButton.Enabled = false;
            }
        }
        private void DespacharOrdenEntregaForm_Load(object sender, EventArgs e)
        {
            _model = new DespacharOrdenEntregaModel();

            CargarTransportistasEnComboBox();
        }

        private void CargarTransportistasEnComboBox()
        {
            IdOrdenEntregaCombo.Items.Clear();

            var transportistas = _model.ObtenerTransportistas();

            foreach (var transportista in transportistas)
            {
                IdOrdenEntregaCombo.Items.Add(transportista);
            }

            if (IdOrdenEntregaCombo.Items.Count > 0)
            {
                IdOrdenEntregaCombo.SelectedIndex = 0;
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            string transportistaSeleccionado = IdOrdenEntregaCombo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(transportistaSeleccionado))
            {
                MessageBox.Show("Por favor, selecciona un transportista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string clienteAsociado = _model.ObtenerClientePorTransportista(transportistaSeleccionado);

            if (clienteAsociado == null)
            {
                MessageBox.Show("No se encontró un cliente asociado a este transportista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ordenes = _model.ObtenerOrdenesEntregaPorCliente(clienteAsociado);

            ListarOrdenDespacharBuscarList.Items.Clear();
            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(new[]
                {
            orden.IdOrden,
            orden.IdCliente, 
            orden.Fecha.ToString("g"),
            orden.Estado
        });
                ListarOrdenDespacharBuscarList.Items.Add(item);
            }
        }
        private void GenerarOrdenDeDespachoButton_Click(object sender, EventArgs e)
        {
            if (ListarOrdenDespacharBuscarList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una orden de la lista antes de generar la orden de despacho.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Generando orden de despacho...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
