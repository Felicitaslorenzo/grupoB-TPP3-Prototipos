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

        //Validación Fecha
        private void FechaDesdedateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechadesde = FechaDesdedateTimePicker.Value;
            DateTime fechahasta = FechaHastadateTimePicker.Value;
            DateTime fechaminima = DateTime.Now.AddDays(1);

            if (fechadesde < fechaminima)
            {
                MessageBox.Show("Por favor, selecciona una fecha a partir de mañana.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FechaDesdedateTimePicker.Value = fechaminima;
            }

            if (fechahasta < fechadesde)
            {
                MessageBox.Show("La fecha hasta no puede ser menor a la fecha desde.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //Boton Volver
        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(IdOrdenPreparacioncomboBox3.Text)||string.IsNullOrWhiteSpace(ClienteComboBox.Text))
            {
                MessageBox.Show("Los campos de Id Orden Preparacion y Cliente, no pueden estar vacíos");
            }
            else
            {
                var cliente = new ListViewItem(ClienteComboBox.Text);
                var idordenprep = new ListViewItem(IdOrdenPreparacioncomboBox3.Text);
                string idordenpreparacion = IdOrdenPreparacioncomboBox3.Text;

                //Limpiar campos
                ClienteComboBox.Items.Clear();
                IdOrdenPreparacioncomboBox3.Items.Clear();

                MessageBox.Show($"La Orden de Preparación {idordenpreparacion} ha sido agregada exitosamente a la lista.");
            }


        }
    }
}
