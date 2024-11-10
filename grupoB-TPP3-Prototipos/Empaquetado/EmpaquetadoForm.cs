using grupoB_TPP3_Prototipos.Empaquetado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.CrearOrdenEntrega
{
    public partial class EmpaquetadoForm : Form
    {
        private EmpaquetadoModel model = new EmpaquetadoModel();

        public EmpaquetadoForm()
        {
            InitializeComponent();
            MostrarOrdenActual();
        }

        private void MostrarOrdenActual()
        {
            var orden = model.ObtenerOrdenActual();
            if (orden != null)
            {
                ListarEmpaquetarOrdenList.Items.Clear(); // Limpia el ListView

                foreach (var producto in orden.Producto)
                {
                    var item = new ListViewItem(producto.DescripcionProducto);
                    item.SubItems.Add(producto.Cantidad.ToString());
                    ListarEmpaquetarOrdenList.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No hay órdenes para empaquetar.");
                this.Close(); // Cierra el formulario si no hay más órdenes
            }
        }

        private void EmpaquetarOrdenButton_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado algún producto en el ListView
            if (ListarEmpaquetarOrdenList.SelectedItems.Count > 0)
            {
                // Eliminar la orden actual
                model.EliminarOrdenActual();

                // Mostrar la siguiente orden
                MostrarOrdenActual();

                // Mostrar mensaje de éxito
                MessageBox.Show("La orden se ha empaquetado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Si no se ha seleccionado ningún producto
                MessageBox.Show("Por favor, selecciona un producto antes de empaquetar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EmpaquetadoForm_Load(object sender, EventArgs e)
        {
            var ordenActual = model.ObtenerOrdenActual();

            if (ordenActual != null)
            {
                model.EliminarOrdenActual(); // Elimina la orden actual
                MostrarOrdenActual(); // Muestra la siguiente orden
            }
            else
            {
                // Si no hay más órdenes, muestra un mensaje y cierra el formulario
                MessageBox.Show("No hay más órdenes para empaquetar.");
                this.Close(); // Cierra el formulario
            }
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
