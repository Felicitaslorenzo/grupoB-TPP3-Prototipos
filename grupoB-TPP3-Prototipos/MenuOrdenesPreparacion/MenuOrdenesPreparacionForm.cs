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

namespace grupoB_TPP3_Prototipos.MenuOrdenesPreparacion
{
    public partial class MenuOrdenesPreparacionForm : Form
    {
        public MenuOrdenesPreparacionForm()
        {
            InitializeComponent();
        }

        private void buttonListarOrdenesPreparacion_Click(object sender, EventArgs e)
        {
            ListarOrdenPreparacion.ListarOrdenPreparacionForm listarOrdenPreparacionForm = new ListarOrdenPreparacion.ListarOrdenPreparacionForm();
            listarOrdenPreparacionForm.ShowDialog();
        }

        private void buttonGenerarOrden_Click(object sender, EventArgs e)
        {
            GenerarOrdenPreparacion.GenerarOrdenPreparacionForm GenerarOrdenPreparacionForm = new GenerarOrdenPreparacion.GenerarOrdenPreparacionForm();
            GenerarOrdenPreparacionForm.ShowDialog();
        }
    }
}
