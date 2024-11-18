using grupoB_TPP3_Prototipos.Almacenes;
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
            this.Load += FormMenuPrincipal_Load;
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
        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarDepositos();
        }
        private void CargarDepositos()
        {

            DepositosCombo.DataSource = DepositoAlmacen.Depositos.ToList();
            DepositosCombo.DisplayMember = "Nombre";
            DepositosCombo.ValueMember = "IdDeposito";

            var depositoActual = DepositoAlmacen.DepositoActual;
            DepositosCombo.SelectedValue = depositoActual.IdDeposito;
        }
        private void DepositosCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DepositosCombo.SelectedItem is DepositoEnt depositoSeleccionado)
            {
                DepositoAlmacen.DepositoActual = depositoSeleccionado;
            }
        }
    }
}
