﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.ListarOrdenPreparacion
{
    public partial class ListarOrdenPreparacionForm : Form
    {
        private ListarOrdenPreparacionModel model = new();
        public ListarOrdenPreparacionForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ListarOrdenPreparacionForm_Load);
            BuscarButton.Click += BuscarButton_Click;

        }
        private void ListarOrdenPreparacionForm_Load(object sender, EventArgs e)
        {
            var ordenesPreparacion = model.ObtenerOrdenesPreparacion();

            // Extraer datos para cada ComboBox
            var nombresClientes = ordenesPreparacion.Select(o => o.Nombre).Distinct().ToList();
            var idsClientes = ordenesPreparacion.Select(o => o.IdCliente).Distinct().ToList();
            var idsOrdenesPreparacion = ordenesPreparacion.Select(o => o.IdOrden).Distinct().ToList();
            var prioridadesOrdenPreparacion = ordenesPreparacion.Select(o => o.Prioridad).Distinct().ToList();
            var estadosOrdenPreparacion = ordenesPreparacion.Select(o => o.Estado).Distinct().ToList();

            // Cargar datos en los desplegables
            foreach (var nombre in nombresClientes)
            {
                NombreClienteCombo.Items.Add(nombre);
            }

            foreach (var id in idsClientes)
            {
                IdClienteCombo.Items.Add(id);
            }

            foreach (var id in idsOrdenesPreparacion)
            {
                IdOrdenPreparacionCombo.Items.Add(id);
            }

            foreach (var prioridad in prioridadesOrdenPreparacion)
            {
                PrioridadOrdenPreparacionCombo.Items.Add(prioridad);
            }

            foreach (var estado in estadosOrdenPreparacion)
            {
                EstadoOrdenPreparacionCombo.Items.Add(estado);
            }


            OrdenesPreparacionList.View = View.Details;
            foreach (var ordenPreparacion in model.ObtenerOrdenesPreparacion())
            {
                ListViewItem item = new ListViewItem();
                item.Text = ordenPreparacion.IdOrden.ToString();
                item.SubItems.Add(ordenPreparacion.IdCliente.ToString());
                item.SubItems.Add(ordenPreparacion.Nombre);
                item.SubItems.Add(ordenPreparacion.Estado);
                item.SubItems.Add(ordenPreparacion.Fecha.ToString("dd/MM/yyyy"));

                OrdenesPreparacionList.Items.Add(item);
            }

        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            // validar si se ha seleccionado algún filtro
            if (string.IsNullOrEmpty(IdOrdenPreparacionCombo.Text) &&
                string.IsNullOrEmpty(IdClienteCombo.Text) &&
                string.IsNullOrEmpty(NombreClienteCombo.Text) &&
                string.IsNullOrEmpty(EstadoOrdenPreparacionCombo.Text) &&
                string.IsNullOrEmpty(PrioridadOrdenPreparacionCombo.Text))
            {
                MessageBox.Show("No se ha seleccionado ningún filtro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // valores seleccionados en los desplegables
                int.TryParse(IdOrdenPreparacionCombo.Text, out int idOrdenSeleccionado);
                int.TryParse(IdClienteCombo.Text, out int idClienteSeleccionado);
                string nombreClienteSeleccionado = NombreClienteCombo.Text;
                string estadoSeleccionado = EstadoOrdenPreparacionCombo.Text;
                string prioridadSeleccionada = PrioridadOrdenPreparacionCombo.Text;

                // Filtrar OrdenesPreparacionList
                var ordenesFiltradas = model.ObtenerOrdenesPreparacion().Where(o =>
                    (idOrdenSeleccionado == 0 || o.IdOrden == idOrdenSeleccionado) &&
                    (idClienteSeleccionado == 0 || o.IdCliente == idClienteSeleccionado) &&
                    (string.IsNullOrEmpty(nombreClienteSeleccionado) || o.Nombre == nombreClienteSeleccionado) &&
                    (string.IsNullOrEmpty(estadoSeleccionado) || o.Estado == estadoSeleccionado) &&
                    (string.IsNullOrEmpty(prioridadSeleccionada) || o.Prioridad == prioridadSeleccionada)
                ).ToList();

                // Limpiar la OrdenesPreparacionList antes de agregar los elementos filtrados
                OrdenesPreparacionList.Items.Clear();

                // agregar elementos filtrados a la OrdenesPreparacionList
                foreach (var ordenPreparacion in ordenesFiltradas)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = ordenPreparacion.IdOrden.ToString();
                    item.SubItems.Add(ordenPreparacion.IdCliente.ToString());
                    item.SubItems.Add(ordenPreparacion.Nombre);
                    item.SubItems.Add(ordenPreparacion.Estado);
                    item.SubItems.Add(ordenPreparacion.Fecha.ToString("dd/MM/yyyy"));

                    OrdenesPreparacionList.Items.Add(item);
                }

            }
        }
    }
}

