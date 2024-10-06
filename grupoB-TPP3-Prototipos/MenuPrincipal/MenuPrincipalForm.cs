using grupoB_TPP3_Prototipos.MenuOrdenesEntrega;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.MenuPrincipal
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonOrdenesPreparacion_Click(object sender, EventArgs e)
        {
            MenuOrdenesPreparacion.MenuOrdenesPreparacionForm menuOrdenesPreparacionForm = new MenuOrdenesPreparacion.MenuOrdenesPreparacionForm();
            menuOrdenesPreparacionForm.ShowDialog();
        }

        private void buttonOrdenesSeleccion_Click(object sender, EventArgs e)
        {
            MenuOrdenesSeleccion.MenuOrdenesSeleccionForm menuOrdenesSeleccionForm = new MenuOrdenesSeleccion.MenuOrdenesSeleccionForm();
            menuOrdenesSeleccionForm.ShowDialog();
        }

        private void buttonOrdenesDeEntrega_Click(object sender, EventArgs e)
        {
            MenuOrdenesEntrega.MenuOrdenesEntregaForm menuOrdenesEntregaForm = new MenuOrdenesEntrega.MenuOrdenesEntregaForm();
            menuOrdenesEntregaForm.ShowDialog();
        }
    }
}
