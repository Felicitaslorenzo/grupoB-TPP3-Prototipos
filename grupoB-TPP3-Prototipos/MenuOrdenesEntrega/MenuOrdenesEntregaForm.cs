using grupoB_TPP3_Prototipos.DespacharOrdenEntrega;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.MenuOrdenesEntrega
{
    public partial class MenuOrdenesEntregaForm : Form
    {
        public MenuOrdenesEntregaForm()
        {
            InitializeComponent();
        }

        private void buttonListarOrdenesEntrega_Click(object sender, EventArgs e)
        {
            ListarOrdenEntrega.ListarOrdenEntregaForm listarOrdenEntregaForm = new ListarOrdenEntrega.ListarOrdenEntregaForm();
            listarOrdenEntregaForm.ShowDialog();
        }

        private void buttonGenerarOrdenEntrega_Click(object sender, EventArgs e)
        {
            CrearOrdenEntrega.EmpaquetadoForm crearOrdenEntregaForm = new CrearOrdenEntrega.EmpaquetadoForm();
            crearOrdenEntregaForm.ShowDialog();
        }

        private void buttonDespacharOrdenEntrega_Click(object sender, EventArgs e)
        {
            DespacharOrdenEntrega.DespacharOrdenEntregaForm despacharOrdenEntregaForm = new DespacharOrdenEntrega.DespacharOrdenEntregaForm();
            despacharOrdenEntregaForm.ShowDialog();
        }
    }
}
