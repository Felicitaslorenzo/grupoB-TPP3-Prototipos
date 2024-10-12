using grupoB_TPP3_Prototipos.Generar_orden_de_Selección;
using grupoB_TPP3_Prototipos.GenerarOrdenSeleccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.GenerarOrdenSelección
{
    public partial class GenerarOrdenSeleccionForm : Form
    {
        public GenerarOrdenSeleccionForm()
        {
            InitializeComponent();
            var modelo = new GenerarOrdenSeleccionModel();
            var ordenesPreparacion = modelo.ObtenerOrdenesPreparacion();
            CargarOrdenesEnComboBox(ordenesPreparacion);
            
            //modelo.CargarCliente(DescripcionClienteCombo);
        }

        private void CargarOrdenesEnComboBox(List<grupoB_TPP3_Prototipos.GenerarOrdenSeleccion.OrdenPreparacion> ordenesPreparacion)
        {
            IdOrdenPreparacionCombo.Items.Clear();

            foreach (var orden in ordenesPreparacion)
            {
                IdOrdenPreparacionCombo.Items.Add(orden.IdOrden);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
