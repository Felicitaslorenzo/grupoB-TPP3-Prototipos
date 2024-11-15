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
                // this.Close(); // Cierra el formulario si no hay más órdenes ME DA EXCEPTION CON ESTE THIS.CLOSE
                EmpaquetarOrdenButton.Enabled = false;
            }
        }

        private void EmpaquetarOrdenButton_Click(object sender, EventArgs e)
        {
            /// Verificar si hay órdenes disponibles para empaquetar
            if (ListarEmpaquetarOrdenList.Items.Count > 0)
            {
                EmpaquetarOrdenButton.Enabled = true;

                // Obtén el ID de la orden actual antes de eliminarla
                var idOrdenActual = model.ObtenerIdOrdenActual();

                // Eliminar la orden actual
                model.EliminarOrdenActual();

                // Verificar si hay más órdenes después de eliminar la orden actual 
                var ordenSiguiente = model.ObtenerOrdenActual();

                // Mostrar mensaje de éxito
                MessageBox.Show($"La orden con ID {idOrdenActual} se ha empaquetado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mostrar la siguiente orden si existe
                if (ordenSiguiente != null)
                {
                    // Mostrar la siguiente orden
                    MostrarOrdenActual();
                }
                else
                {
                    // Si no hay más órdenes, mostrar el mensaje de "No hay más órdenes" y cerrar el formulario
                    MessageBox.Show("No hay más órdenes para empaquetar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cierra el formulario
                }
            }
        }

        private void EmpaquetadoForm_Load(object sender, EventArgs e)
        {
          
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
