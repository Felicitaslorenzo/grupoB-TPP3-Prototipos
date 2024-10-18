using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.GenerarOrdenEntrega
{
    public partial class GenerarOrdenEntregaForm : Form
    {
        private GenerarOrdenEntregaModel modelo = new GenerarOrdenEntregaModel();

        public GenerarOrdenEntregaForm()
        {
            InitializeComponent();
        }




        //Boton Volver
        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            //if(string.IsNullOrWhiteSpace(IdOrdenPreparacioncomboBox3.Text)||string.IsNullOrWhiteSpace(ClienteComboBox.Text))
            //{
            //    MessageBox.Show("Los campos de Id Orden Preparacion y Cliente, no pueden estar vacíos");
            //}
            //else
            //{
            //    var cliente = new ListViewItem(ClienteComboBox.Text);
            //    var idordenprep = new ListViewItem(IdOrdenPreparacioncomboBox3.Text);
            //    string idordenpreparacion = IdOrdenPreparacioncomboBox3.Text;


            //    MessageBox.Show($"La Orden de Preparación {idordenpreparacion} ha sido agregada exitosamente a la lista.");
            //}


        }
    }
}
