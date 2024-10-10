using grupoB_TPP3_Prototipos.Generar_orden_de_Selección;
using grupoB_TPP3_Prototipos.GenerarOrdenPreparacion;
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

            modelo.CargarCliente(DescripcionClienteCombo);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
