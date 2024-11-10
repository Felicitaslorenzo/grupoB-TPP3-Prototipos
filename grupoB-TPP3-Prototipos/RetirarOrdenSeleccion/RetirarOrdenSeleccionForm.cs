using grupoB_TPP3_Prototipos.Almacenes;
using grupoB_TPP3_Prototipos.ListarOrdenPreparacion;
using grupoB_TPP3_Prototipos.RetirarOrdenSeleccion;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace grupoB_TPP3_Prototipos.PrepararOrdenSeleccion
{
    public partial class RetirarOrdenSeleccionForm : Form
    {
        private RetirarOrdenSeleccionModelo model = new();

        private List<OrdenSeleccion> ordenesSeleccion;
        public RetirarOrdenSeleccionForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.RetirarOrdenSeleccionForm_Load);

            // Agregar el manejador para el evento SelectedIndexChanged
            OrdenSCombo.SelectedIndexChanged += OrdenSCombo_SelectedIndexChanged;
        }

        private void OrdenSCombo_SelectedIndexChanged(object? sender, EventArgs e)
        {

            // Limpia el ListView antes de agregar los nuevos elementos
            listView1.Items.Clear();

            // Verifica que se haya seleccionado algo
            if (OrdenSCombo.SelectedItem != null)
            {
                // Obtiene el Id de la orden seleccionada
                var idSeleccionado = OrdenSCombo.SelectedItem.ToString();

                // Busca la orden correspondiente en tu modelo
                var ordenSeleccionada = model.OrdenesSeleccionadas.FirstOrDefault(o => o.IdOrdenSeleccion == idSeleccionado);

                // Verifica que la propiedad OrdenesPreparacion no sea null y contenga elementos
               /* foreach (var producto in ordenSeleccionada.Producto)
                {
                    // Ahora iteramos sobre la lista de productos
                    // Crea un nuevo ListViewItem
                    ListViewItem item = new ListViewItem(producto.Ubicacion);
                    item.SubItems.Add(producto.DescripcionProducto);
                    item.SubItems.Add(producto.Cantidad.ToString());
                    listView1.Items.Add(item);
                }*/

            }
        }


        private void RetirarOrdenSeleccionForm_Load(object? sender, EventArgs e)
        {
            ordenesSeleccion = model.OrdenesSeleccionadas ?? new List<OrdenSeleccion>();
            OrdenSeleccionAlmacen.Leer();
            CargarOrdenesEnComboBox();
        }

        private void CargarOrdenesEnComboBox()
        {
            // Limpia los ítems existentes en el ComboBox antes de agregar nuevos
            OrdenSCombo.Items.Clear();
            ordenesSeleccion = model.OrdenesSeleccionadas;
            // Llenar el ComboBox de órdenes desde el modelo
            var ordenesPendientes = ordenesSeleccion.Where(orden => orden.Estado == EstadoOrdenSelEnum.Pendiente).ToList();

            // Imprimir los estados de las órdenes para depuración
            foreach (var orden in ordenesPendientes)
            {
                Console.WriteLine($"Orden: {orden.IdOrdenSeleccion}, Estado: {orden.Estado}");
            }
            // Verifica si hay órdenes pendientes para evitar errores
            if (ordenesPendientes.Any())
            {
                foreach (var orden in ordenesPendientes)
                {
                    // Agrega solo el ID o cualquier atributo que desees mostrar en el ComboBox
                    OrdenSCombo.Items.Add(orden.IdOrdenSeleccion);
                }
            }
            else
            {
                MessageBox.Show("No hay órdenes pendientes para retirar.");
            }
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            // Verificar que se haya hecho una selección válida
            if (OrdenSCombo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una orden."); // Solo si no hay selección
            }
            else
            {
                // Obtiene el Id de la orden seleccionada
                var idSeleccionado = OrdenSCombo.SelectedItem.ToString();
                var ordenSeleccionada = model.OrdenesSeleccionadas.FirstOrDefault(o => o.IdOrdenSeleccion == idSeleccionado);

                if (ordenSeleccionada != null)
                {
                    model.Confirmar(idSeleccionado);         
                    // Limpia las selecciones del ListView y actualiza el ComboBox
                    listView1.Items.Clear();
                    CargarOrdenesEnComboBox(); // Actualiza el ComboBox

                    // Mostrar mensaje de confirmación
                    MessageBox.Show("El retiro de la(s) orden(es) de preparación se ha confirmado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            CargarOrdenesEnComboBox();
        }
    }
}

