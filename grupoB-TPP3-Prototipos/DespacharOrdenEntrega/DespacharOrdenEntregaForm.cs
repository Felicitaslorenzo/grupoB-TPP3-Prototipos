﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.DespacharOrdenEntrega
{
    public partial class DespacharOrdenEntregaForm : Form
    {
        private DespacharOrdenEntregaModel model;

        // A TENER EN CUENTA: SOLO mostrar las OP que estén en estado "Preparada" 
        // y que tengan fecha de hoy o anterior.

        public DespacharOrdenEntregaForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(DespacharOrdenEntregaForm_Load);
            BuscarButton.Click += new EventHandler(BuscarButton_Click);
            EmitirOrdenDeDespachoButton.Click += new EventHandler(EmitirOrdenDeDespachoButton_Click);
            IdOrdenEntregaCombo.DropDownStyle = ComboBoxStyle.DropDownList; // Aquí se establece el estilo
            VolverButton.Click += new EventHandler(VolverButton_Click);
            EmitirOrdenDeDespachoButton.Enabled = false;
            ListarOrdenDespacharBuscarList.SelectedIndexChanged += new EventHandler(ListarOrdenDespacharBuscarList_SelectedIndexChanged);
            ListarOrdenDespacharBuscarList.MultiSelect = true;
            ListarOrdenDespacharBuscarList.FullRowSelect = true;
        }

        private void ListarOrdenDespacharBuscarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListarOrdenDespacharBuscarList.SelectedItems.Count > 0)
            {
                EmitirOrdenDeDespachoButton.Enabled = true;
            }
            else
            {
                EmitirOrdenDeDespachoButton.Enabled = false;
            }
        }

        private void DespacharOrdenEntregaForm_Load(object sender, EventArgs e)
        {
            model = new DespacharOrdenEntregaModel();
            CargarTransportistasEnComboBox();
        }

        private void CargarTransportistasEnComboBox()
        {
            IdOrdenEntregaCombo.Items.Clear();

            var transportistas = model.ObtenerTransportistas();

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

            // Obtén las órdenes de entrega por transportista
            var ordenes = model.ObtenerOrdenesEntregaPorTransportista(transportistaSeleccionado);

            if (ordenes == null || ordenes.Count == 0)
            {
                MessageBox.Show("No se encontraron órdenes de entrega para el transportista seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Limpia el ListView antes de agregar los nuevos elementos
            ListarOrdenDespacharBuscarList.Items.Clear();

            // Agrega las órdenes sin incluir la fecha
            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(new[]
                {
            orden.IdOrden,    // Columna para el ID de la Orden
            orden.IdCliente,  // Columna para el ID del Cliente
            orden.Estado      // Columna para el Estado de la Orden
        });
                ListarOrdenDespacharBuscarList.Items.Add(item);
            }
        }

        private void EmitirOrdenDeDespachoButton_Click(object sender, EventArgs e)
        {
            /* if (ListarOrdenDespacharBuscarList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una orden de la lista antes de generar la orden de despacho.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } */

            // Verifica que la variable 'nuevoIDRemito' esté declarada
            var nuevoIDRemito = model.GenerarNuevoIDRemito();  // Asegúrate de que 'model' esté instanciado

            // Después puedes usarla
            MessageBox.Show($"El remito {nuevoIDRemito} se ha generado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiamos la lista de órdenes de despacho después de generar el remito
            ListarOrdenDespacharBuscarList.Items.Clear();
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmitirOrdenDeDespachoButton_Click_1(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}