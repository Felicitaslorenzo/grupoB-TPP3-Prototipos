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
            // Obtener los valores seleccionados
            string idOrdenSeleccionada = IdOrdenSeleccionCombo.Text;
            DateTime fechaSeleccionada = FechaOSPicker.Value.Date;

            // Validar si al menos un filtro está activo
            if (string.IsNullOrEmpty(idOrdenSeleccionada) && !FechaOSPicker.Checked)
            {
                MessageBox.Show("Por favor, selecciona al menos un filtro.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Filtrar OrdenesSeleccionadasList basado en los valores seleccionados (si ambos están activos o solo uno)
            var ordenesFiltradas = modelo.OrdenesSeleccionadas.Where(o =>
                (string.IsNullOrEmpty(idOrdenSeleccionada) || o.IdOrdenSeleccion == idOrdenSeleccionada)
            ).ToList();

            // Limpiar la lista antes de agregar los elementos filtrados
            ListarOrdenSeleccionList.Items.Clear();

            // Verificar si no se encontraron resultados
            if (ordenesFiltradas.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados con los filtros seleccionados.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Agregar los elementos filtrados a la lista
            foreach (var ordenSeleccion in ordenesFiltradas)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ordenSeleccion.IdOrdenSeleccion;
                item.SubItems.Add(ordenSeleccion.FechaOS.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ordenSeleccion.DescripcionProducto);
                item.SubItems.Add(ordenSeleccion.Cantidad.ToString());
                item.SubItems.Add(ordenSeleccion.Ubicacion);
                item.SubItems.Add(ordenSeleccion.Estado);

                ListarOrdenSeleccionList.Items.Add(item);
            }
        }

        private void ListarOrdenSeleccionForm_Load(object sender, EventArgs e)
        {
            var ordenesSeleccion = modelo.OrdenesSeleccionadas;

            // Extraer datos para cada ComboBox
            var idOrdenesSeleccion = ordenesSeleccion.Select(o => o.IdOrdenSeleccion).Distinct().ToList();
            var FechaOS = ordenesSeleccion.Select(o => o.FechaOS).Distinct().ToList();

            // Cargar datos en los desplegables
            foreach (var idOrdenSeleccion in idOrdenesSeleccion)
            {
                IdOrdenSeleccionCombo.Items.Add(idOrdenSeleccion);
            }
            foreach (var ordenPreparacion in modelo.OrdenesSeleccionadas)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ordenPreparacion.IdOrdenSeleccion.ToString();
                item.SubItems.Add(ordenPreparacion.FechaOS.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ordenPreparacion.DescripcionProducto.ToString());
                item.SubItems.Add(ordenPreparacion.Cantidad.ToString());
                item.SubItems.Add(ordenPreparacion.Ubicacion);
                item.SubItems.Add(ordenPreparacion.Estado);
                

                ListarOrdenSeleccionList.Items.Add(item);
            }
        }
    }
}
