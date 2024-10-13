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

        public RetirarOrdenSeleccionForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.RetirarOrdenSeleccionForm_Load);

            // Agregar el manejador para el evento SelectedIndexChanged
            ProductoCombo.SelectedIndexChanged += ProductoCombo_SelectedIndexChanged;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica que no se esté en modo de confirmación
            if (model.IsConfirming) return;

            // Verifica que se haya seleccionado algo
            if (ProductoCombo.SelectedItem != null)
            {
                // Obtiene el Id de la orden seleccionada
                var idSeleccionado = ProductoCombo.SelectedItem.ToString();

                // Busca la orden correspondiente en tu modelo
                var ordenSeleccionada = model.OrdenesSeleccionadas.FirstOrDefault(o => o.IdOrdenSeleccion == idSeleccionado);

                // Limpia el ListView antes de agregar nuevos ítems
                listView2.Items.Clear();

                // Verifica que la propiedad OrdenesPreparacion no sea null y contenga elementos
                if (ordenSeleccionada != null && ordenSeleccionada.OrdenesPreparacion != null && ordenSeleccionada.OrdenesPreparacion.Count > 0)
                {
                    foreach (var ordenPreparacion in ordenSeleccionada.OrdenesPreparacion)
                    {
                        // Crea un nuevo ListViewItem
                        ListViewItem item = new ListViewItem(ordenPreparacion.IdOrden);
                        item.SubItems.Add(ordenPreparacion.Cliente);
                        item.SubItems.Add(ordenPreparacion.FechaEmision.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(ordenPreparacion.FechaDespacho.ToString("dd/MM/yyyy"));

                        // Agrega el ítem al ListView
                        listView2.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("No hay órdenes de preparación disponibles para esta orden.");
                }
            }
            else
            {
                // Este mensaje solo debe aparecer si se intenta confirmar sin seleccionar
                // El código de confirmación se encargará de esto
            }
        }

        private void RetirarOrdenSeleccionForm_Load(object sender, EventArgs e)
        {
            CargarOrdenesEnComboBox();
        }
        private void CargarOrdenesEnComboBox()
        {
            // Limpia los ítems existentes en el ComboBox antes de agregar nuevos
            ProductoCombo.Items.Clear();

            // Llenar el ComboBox de órdenes desde el modelo
            foreach (var orden in model.OrdenesSeleccionadas)
            {
                // Asegúrate de que solo se agregue cada orden una vez
                if (!ProductoCombo.Items.Contains(orden.IdOrdenSeleccion))
                {
                    ProductoCombo.Items.Add(orden.IdOrdenSeleccion); // Asumiendo que IdOrdenSeleccion es el texto que deseas mostrar
                }
            }
        }


        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            // Asegúrate de que hay un ítem seleccionado en el ListView
            if (listView2.SelectedItems.Count > 0)
            {
                // Obtiene la orden de preparación seleccionada
                var ordenSeleccionada = listView2.SelectedItems[0]; // Toma el primer ítem seleccionado

                // Aquí debes obtener la lista de productos asociados a la orden de preparación seleccionada
                var ordenPreparacion = model.OrdenesSeleccionadas
                    .SelectMany(o => o.OrdenesPreparacion)
                    .FirstOrDefault(op => op.IdOrden == ordenSeleccionada.Text); // Usa el IdOrden del ListView

                // Verifica que la orden de preparación no sea null
                if (ordenPreparacion != null && ordenPreparacion.Producto != null && ordenPreparacion.Producto.Count > 0)
                {
                    foreach (var producto in ordenPreparacion.Producto)
                    {
                        // Verifica que el producto no sea null
                        if (producto != null)
                        {
                            // Comprueba si el producto ya está en el ListView
                            var existingItem = listView1.Items.Cast<ListViewItem>()
                                                .FirstOrDefault(item => item.SubItems[0].Text == producto.DescripcionProducto);

                            // Si el producto ya existe en el ListView
                            if (existingItem != null)
                            {
                                // Suma la cantidad si proviene de una orden diferente
                                int existingQuantity = int.Parse(existingItem.SubItems[1].Text);
                                existingItem.SubItems[1].Text = (existingQuantity + producto.Cantidad).ToString();
                            }
                            else
                            {
                                // Si no existe el producto en el ListView, lo añadimos
                                ListViewItem newItem = new ListViewItem(producto.DescripcionProducto); // Usamos Descripcion
                                newItem.SubItems.Add(producto.Cantidad.ToString()); // Usamos Cantidad
                                newItem.SubItems.Add(producto.Ubicacion); // Usamos Ubi
                                listView1.Items.Add(newItem);
                            }
                        }
                    }

                    // Borra la orden seleccionada del ListView2
                    listView2.Items.Remove(ordenSeleccionada);
                }
            }
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            // Marca que se está confirmando
            model.IsConfirming = true;

            // Verificar que se haya hecho una selección válida
            if (ProductoCombo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una orden."); // Solo si no hay selección
            }
            else
            {
                // Obtiene el Id de la orden seleccionada
                var idSeleccionado = ProductoCombo.SelectedItem.ToString();
                var ordenSeleccionada = model.OrdenesSeleccionadas.FirstOrDefault(o => o.IdOrdenSeleccion == idSeleccionado);

                // Eliminar las órdenes de preparación del ListView y del modelo
                foreach (ListViewItem item in listView2.SelectedItems)
                {
                    var idOrdenPreparacion = item.Text; // Asumiendo que el texto del ListView es el IdOrden

                    // Busca la orden de preparación en el modelo
                    var ordenPreparacion = ordenSeleccionada.OrdenesPreparacion.FirstOrDefault(op => op.IdOrden == idOrdenPreparacion);
                    if (ordenPreparacion != null)
                    {
                        ordenSeleccionada.OrdenesPreparacion.Remove(ordenPreparacion); // Eliminar la orden de preparación del modelo
                    }
                }

                // Limpia las selecciones del ListView y actualiza el ComboBox
                listView2.Items.Clear();
                listView1.Items.Clear();
                CargarOrdenesEnComboBox(); // Actualiza el ComboBox

                // Mostrar mensaje de confirmación
                MessageBox.Show("El retiro de la(s) orden(es) de preparación se ha confirmado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Restaura el estado de confirmación
            model.IsConfirming = false; // Permitir nuevas selecciones
        }
    }
}
