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
                labelOP.Text = orden.IdOrden; // Muestra el ID de la orden
                labelCliente.Text = orden.Nombre; // Muestra el nombre del cliente
                labelTransportista.Text = orden.Transportista; // Muestra el transportista
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
            // Eliminar la orden actual
            model.EliminarOrdenActual();

            // Mostrar la siguiente orden
            MostrarOrdenActual();
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
