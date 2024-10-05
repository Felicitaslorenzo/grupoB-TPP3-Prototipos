using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.ListarOrdenSeleccion
{
    public partial class ListarOrdenSeleccionForm : Form
    {
        private ListarOrdenSeleccionModel modelo = new();

        public ListarOrdenSeleccionForm()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            // Obtener el valor del documento ingresado en el ComboBox
            if (IdOrdenSeleccionCombo.SelectedItem != null && FechaOSPicker.Value != null &&
                DateTime.TryParse(FechaOSPicker.Value.ToString(), out DateTime FechaOS))
            {
                // Obtener el ID de la orden seleccionada del ComboBox
                string idOrdenSeleccion = IdOrdenSeleccionCombo.SelectedItem.ToString();

                // Filtrar la lista de órdenes
                var ordenBuscada = modelo.OrdenesSeleccionadas.FirstOrDefault(p =>
                    p.IdOrdenSeleccion == idOrdenSeleccion &&
                    p.FechaOS.Date == FechaOS.Date); // Comparar solo la fecha

                if (ordenBuscada != null)
                {
                    // Limpiar el ListView antes de mostrar los resultados de la búsqueda
                    ListarOrdenSeleccionBuscarList.Items.Clear();

                    // Crear un nuevo elemento para el ListView con la orden encontrada
                    ListViewItem item = new ListViewItem(ordenBuscada.IdOrdenSeleccion);
                    item.SubItems.Add(ordenBuscada.FechaOS.ToShortDateString()); // Mostrar la fecha en formato corto
                    item.SubItems.Add(ordenBuscada.DescripcionProducto);
                    item.SubItems.Add(ordenBuscada.Cantidad.ToString());
                    item.SubItems.Add(ordenBuscada.Ubicacion);

                    // Agregar el elemento al ListView
                    ListarOrdenSeleccionBuscarList.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna orden con ese ID y fecha.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un ID de orden y una fecha válidos para buscar.");
            }
        }
    }
}
