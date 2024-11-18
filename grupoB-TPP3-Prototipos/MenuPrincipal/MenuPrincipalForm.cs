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

            // Enlazar al ComboBox
            DepositosCombo.DataSource = DepositoAlmacen.Depositos.ToList(); // Convertir a lista
            DepositosCombo.DisplayMember = "Nombre"; // Mostrar el nombre del depósito
            DepositosCombo.ValueMember = "IdDeposito"; // Utilizar el ID como valor interno

            // Seleccionar el depósito actual en el ComboBox
            var depositoActual = DepositoAlmacen.DepositoActual;
            DepositosCombo.SelectedValue = depositoActual.IdDeposito;
        }
        private void DepositosCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Actualizar el depósito actual al cambiar la selección
            if (DepositosCombo.SelectedItem is DepositoEnt depositoSeleccionado)
            {
                //DepositoAlmacen.CambiarDepositoActual(depositoSeleccionado);
            }
        }
    }
}
