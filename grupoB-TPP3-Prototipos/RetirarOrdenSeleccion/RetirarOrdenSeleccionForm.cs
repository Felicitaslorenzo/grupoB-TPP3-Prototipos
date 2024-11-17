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

        // private List<OrdenSeleccion> ordenesSeleccion;

        public RetirarOrdenSeleccionForm()
        {
            InitializeComponent();
            // this.Load += new System.EventHandler(this.RetirarOrdenSeleccionForm_Load);
            OrdenSCombo.SelectedIndexChanged += OrdenSCombo_SelectedIndexChanged;

            // Asignar eventos a los botones
            ConfirmarButton.Click += new EventHandler(ConfirmarButton_Click);
            CancelarButton.Click += new EventHandler(CancelarButton_Click);
        }

        private void OrdenSCombo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (OrdenSCombo.SelectedItem != null)
            {
                // Obtener el ID seleccionado en el ComboBox
                var idSeleccionado = OrdenSCombo.SelectedItem.ToString();

                // Crear una lista con el ID seleccionado (aunque sea solo uno)
                var ordenesPreparacionIds = new List<string> { idSeleccionado };

                // Llamar al método para cargar los productos, pasando la lista de IDs
                CargarProductosYUbicacionesEnGrilla(ordenesPreparacionIds);  // Pasamos una lista con el idSeleccionado
            }
            /*
            listView1.Items.Clear();

            if (OrdenSCombo.SelectedItem != null)
            {
                var idSeleccionado = OrdenSCombo.SelectedItem.ToString();
                //var ordenSeleccionada = model.OrdenesSeleccionadas.FirstOrDefault(o => o.IdOrdenSeleccion == idSeleccionado);
                /*if (ordenSeleccionada != null)
                {
                    var ordenesPreparacionIds = ordenSeleccionada.OrdenesPreparacion;
                    CargarProductosYUbicacionesEnGrilla(ordenesPreparacionIds);
            
                }
            } */
        }

        private void CargarProductosYUbicacionesEnGrilla(List<string> ordenesPreparacionIds)
        {
            // Usamos el primer ID de la lista, ya que es la lista de ordenes de preparación que tenemos
            string idSeleccion = ordenesPreparacionIds.FirstOrDefault();  // Aseguramos que usamos el ID de la lista

            if (string.IsNullOrEmpty(idSeleccion))
            {
                MessageBox.Show("No se ha seleccionado ninguna orden válida.");
                return;
            }

            // Llamar al modelo para obtener los productos relacionados a la orden seleccionada usando idSeleccion
            var productos = model.ObtenerProductosPorOrden(idSeleccion);  // Asegúrate de que ObtenerProductosPorOrden acepte un parámetro idSeleccion

            if (productos == null || !productos.Any())
            {
                MessageBox.Show("No hay productos disponibles para esta orden.");
                return;
            }

            // Limpiar la grilla antes de cargar los nuevos datos
            listView1.Items.Clear();

            // Recorrer los productos obtenidos y agregar cada uno al ListView
            foreach (var producto in productos)
            {
                // Verificar si la cantidad es mayor que cero antes de agregar al ListView
                if (producto.Cantidad > 0)
                {
                    var item = new ListViewItem(producto.Ubicacion);
                    item.SubItems.Add(producto.DescripcionProducto);
                    item.SubItems.Add(producto.Cantidad.ToString());

                    // Agregar el item a la grilla (ListView)
                    listView1.Items.Add(item);
                }
            }
            // Usamos el primer ID de la lista, ya que es la lista de ordenes de preparación que tenemos
            /*  string idSeleccion = ordenesPreparacionIds.FirstOrDefault();  // Aseguramos que usamos el ID de la lista

             if (string.IsNullOrEmpty(idSeleccion))
             {
                 MessageBox.Show("No se ha seleccionado ninguna orden válida.");
                 return;
             }

             // Llamar al modelo para obtener los productos relacionados a la orden seleccionada usando idSeleccion
             var productos = model.ObtenerProductosPorOrden(idSeleccion);  // Asegúrate de que ObtenerProductosPorOrden acepte un parámetro idSeleccion

             if (productos == null || !productos.Any())
             {
                 MessageBox.Show("No hay productos disponibles para esta orden.");
                 return;
             }

             // Limpiar la grilla antes de cargar los nuevos datos
             listView1.Items.Clear();

             // Recorrer los productos obtenidos y agregar cada uno al ListView
             foreach (var producto in productos)
             {
                 var item = new ListViewItem(producto.Ubicacion);
                 item.SubItems.Add(producto.DescripcionProducto);
                 item.SubItems.Add(producto.Cantidad.ToString());

                 // Agregar el item a la grilla (ListView)
                 listView1.Items.Add(item);
             } */
            /*
            if (ordenesPreparacionIds == null || !ordenesPreparacionIds.Any())
            {
                MessageBox.Show("No hay productos disponibles para esta orden.");
                return;
            }
            //var productosConUbicaciones = model.CargarProductosYUbicaciones(ordenesPreparacionIds);

            listView1.Items.Clear();
            /*foreach (var producto in productosConUbicaciones)
            {
                var item = new ListViewItem(producto.Ubicacion);
                item.SubItems.Add(producto.DescripcionProducto);
                item.SubItems.Add(producto.Cantidad.ToString());

                listView1.Items.Add(item);
            }*/
        }

        private void RetirarOrdenSeleccionForm_Load(object? sender, EventArgs e)
        {
            CargarOrdenesEnComboBox();
            //ordenesSeleccion = model.OrdenesSeleccionadas ?? new List<OrdenSeleccion>();
            // CargarOrdenesEnComboBox();
        }

        private void CargarOrdenesEnComboBox()
        {
            OrdenSCombo.Items.Clear();
            var ordenesPendientes = model.ObtenerOrdenesPendientes();

            if (ordenesPendientes.Any())
            {
                foreach (var orden in ordenesPendientes)
                {
                    OrdenSCombo.Items.Add(orden.IdOrdenSeleccion);
                }
            }
            else
            {
                MessageBox.Show("No hay órdenes EnSeleccion para retirar.");
            }
            /* OrdenSCombo.Items.Clear();
            //ordenesSeleccion = model.OrdenesSeleccionadas;

            var ordenesPendientes = ordenesSeleccion.Where(orden => orden.Estado == EstadoOrdenSelEnum.Pendiente).ToList();

            if (ordenesPendientes.Any())
            {
                foreach (var orden in ordenesPendientes)
                {
                    OrdenSCombo.Items.Add(orden.IdOrdenSeleccion);
                }
            }
            else
            {
                MessageBox.Show("No hay órdenes pendientes para retirar.");
            } */
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una orden en el ComboBox
            if (OrdenSCombo.SelectedItem != null)
            {
                // Obtener el ID de la orden seleccionada
                var idSeleccionado = OrdenSCombo.SelectedItem.ToString();

                // Confirmar la orden (aquí llamamos al método que maneja la confirmación en tu modelo)
                model.ConfirmarOrden(idSeleccionado);

                // Limpiar el ListView (si es necesario para actualizar la vista de órdenes)
                listView1.Items.Clear();

                // Eliminar la orden confirmada del ComboBox
                OrdenSCombo.Items.Remove(idSeleccionado);

                // Limpiar la selección del ComboBox
                OrdenSCombo.SelectedIndex = -1;

                // Mostrar mensaje de éxito
                MessageBox.Show($"El retiro de la(s) orden(es) de preparación se ha confirmado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Si no se ha seleccionado una orden
                MessageBox.Show("Por favor, selecciona una orden antes de confirmar el retiro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /*
            // Verificar si se ha seleccionado una orden en el ComboBox
            if (OrdenSCombo.SelectedItem != null)
            {
                // Obtener el ID de la orden seleccionada
                var idSeleccionado = OrdenSCombo.SelectedItem.ToString();

                // Confirmar la orden
                model.ConfirmarOrden(idSeleccionado);

                // Limpiar el ListView
                listView1.Items.Clear();

                // Recargar el ComboBox con las órdenes pendientes
                CargarOrdenesEnComboBox();

                // Mostrar mensaje de éxito
                MessageBox.Show("El retiro de la(s) orden(es) de preparación se ha confirmado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Si no se ha seleccionado una orden
                MessageBox.Show("Por favor, selecciona una orden antes de confirmar el retiro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /*
            // Verificar que se haya hecho una selección válida
            if (OrdenSCombo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una orden."); // Solo si no hay selección
            }
            else
            {
                // Obtiene el Id de la orden seleccionada
                var idSeleccionado = OrdenSCombo.SelectedItem.ToString();
                //var ordenSeleccionada = model.OrdenesSeleccionadas.FirstOrDefault(o => o.IdOrdenSeleccion == idSeleccionado);

                /*if (ordenSeleccionada != null)
                {
                    //model.Confirmar(idSeleccionado);         
                    // Limpia las selecciones del ListView y actualiza el ComboBox
                    listView1.Items.Clear();
                    CargarOrdenesEnComboBox(); // Actualiza el ComboBox

                    // Mostrar mensaje de confirmación
                    MessageBox.Show("El retiro de la(s) orden(es) de preparación se ha confirmado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }*/
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
            // listView1.Items.Clear();
            // CargarOrdenesEnComboBox();
        }

        private void ConfirmarButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}

