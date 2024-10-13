using grupoB_TPP3_Prototipos.Generar_orden_de_Selección;
using grupoB_TPP3_Prototipos.GenerarOrdenSeleccion;
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

namespace grupoB_TPP3_Prototipos.GenerarOrdenSelección
{
    public partial class GenerarOrdenSeleccionForm : Form
    {
        private List<OrdenPreparacion> todasLasOrdenes;
        public GenerarOrdenSeleccionForm()
        {
            InitializeComponent();
            var modelo = new GenerarOrdenSeleccionModel();
            var ordenesPreparacion = modelo.ObtenerOrdenesPreparacion();
            CargarOrdenesEnComboBox(ordenesPreparacion);
            var clientes = modelo.ObtenerClientes();
            CargarClientesEnComboBox(clientes);
            CargarOrdenesEnListView(ordenesPreparacion);
            todasLasOrdenes = modelo.ObtenerOrdenesPreparacion();
        }
        private void CargarClientesEnComboBox(List<Cliente> clientes)
        {
            DescripcionClienteCombo.Items.Clear();

            foreach (var cliente in clientes)
            {
                DescripcionClienteCombo.Items.Add(cliente.IdCliente);
            }
        }
        private void CargarOrdenesEnComboBox(List<grupoB_TPP3_Prototipos.GenerarOrdenSeleccion.OrdenPreparacion> ordenesPreparacion)
        {
            IdOrdenPreparacionCombo.Items.Clear();

            foreach (var orden in ordenesPreparacion)
            {
                IdOrdenPreparacionCombo.Items.Add(orden.IdOrden);
            }
        }
        private void CargarOrdenesEnListView(List<OrdenPreparacion> ordenesPreparacion)
        {
            GenerarOrdenSeleccionBuscarList.Items.Clear();

            foreach (var orden in ordenesPreparacion)
            {
                var item = new ListViewItem(orden.IdOrden);
                item.SubItems.Add(orden.Nombre);
                item.SubItems.Add(orden.FechaEmision.ToString("dd/MM/yyyy"));

                GenerarOrdenSeleccionBuscarList.Items.Add(item);
            }
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            string idOrden = IdOrdenPreparacionCombo.Text;
            DateTime? fechaDesde = null;
            DateTime? fechaHasta = null;
            if (DateTime.TryParse(FechaOSDesdePicker.Text, out DateTime fechaDesdeValor))
            {
                fechaDesde = fechaDesdeValor;
            }

            if (DateTime.TryParse(FechaOSHastaPicker.Text, out DateTime fechaHastaValor))
            {
                fechaHasta = fechaHastaValor;
            }
            string prioridad = PrioridadCombo.Text; // La prioridad es del cliente
            string idCliente = DescripcionClienteCombo.Text;
            //var ordenesFiltradas = modelo.FiltrarOrdenes(todasLasOrdenes, idOrden, fechaDesde, fechaHasta, prioridad, idCliente);

            //CargarOrdenesEnListView(ordenesFiltradas);
        }
    }
}
