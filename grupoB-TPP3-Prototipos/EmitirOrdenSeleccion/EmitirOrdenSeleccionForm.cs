using grupoB_TPP3_Prototipos.Generar_orden_de_Selección;
using grupoB_TPP3_Prototipos.GenerarOrdenSeleccion;
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

namespace grupoB_TPP3_Prototipos.GenerarOrdenSelección
{
    public partial class EmitirOrdenSeleccionForm : Form
    {
        private EmitirOrdenSeleccionModel model = new EmitirOrdenSeleccionModel();
        public EmitirOrdenSeleccionForm()
        {
            InitializeComponent();
            var modelo = new EmitirOrdenSeleccionModel();
            var ordenesPreparacion = modelo.ObtenerOrdenesPreparacion();
            CargarOrdenesEnComboBox(ordenesPreparacion);
            var clientes = modelo.ObtenerClientes();
            CargarClientesEnComboBox(clientes);
            CargarOrdenesEnListView(ordenesPreparacion);
            model.ObtenerOrdenesPreparacion();
        }
        private void CargarClientesEnComboBox(List<Cliente> clientes)
        {
            DescripcionClienteCombo.Items.Clear();

            foreach (var cliente in clientes)
            {
                DescripcionClienteCombo.Items.Add(cliente.IdCliente);
            }
        }
        private void CargarOrdenesEnComboBox(List<grupoB_TPP3_Prototipos.GenerarOrdenSeleccion.OrdenPreparacion> ordenesPreparacion)
        {
            IdOrdenPreparacionCombo.Items.Clear();

            foreach (var orden in ordenesPreparacion)
            {
                IdOrdenPreparacionCombo.Items.Add(orden.IdOrden);
            }
        }
        private void CargarOrdenesEnListView(List<OrdenPreparacion> ordenesPreparacion)
        {
            GenerarOrdenSeleccionBuscarList.Items.Clear();

            foreach (var orden in ordenesPreparacion)
            {
                var item = new ListViewItem(orden.IdOrden);
                item.SubItems.Add(orden.Nombre);
                item.SubItems.Add(orden.FechaEmision.ToString("dd/MM/yyyy"));

                GenerarOrdenSeleccionBuscarList.Items.Add(item);
            }
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            string idOrden = IdOrdenPreparacionCombo.Text;
            DateTime? fechaDesde = null;
            DateTime? fechaHasta = null;
            if (DateTime.TryParse(FechaOSDesdePicker.Text, out DateTime fechaDesdeValor))
            {
                fechaDesde = fechaDesdeValor;
            }

            if (DateTime.TryParse(FechaOSHastaPicker.Text, out DateTime fechaHastaValor))
            {
                fechaHasta = fechaHastaValor;
            }
            string prioridad = PrioridadCombo.Text; // La prioridad es del cliente
            string idCliente = DescripcionClienteCombo.Text;
            //var ordenesFiltradas = modelo.FiltrarOrdenes(todasLasOrdenes, idOrden, fechaDesde, fechaHasta, prioridad, idCliente);

            //CargarOrdenesEnListView(ordenesFiltradas);
        }

        private void GenerarOrdenSeleccionBuscarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenerarOrdenSeleccionBuscarList.SelectedItems.Count > 0)
            {
                // Obtener el IdOrden de la orden seleccionada
                var idOrdenSeleccionada = GenerarOrdenSeleccionBuscarList.SelectedItems[0].Text;

                // Buscar la orden en la lista de todasLasOrdenes
                var ordenSeleccionada = model.ObtenerOrdenesPreparacion().FirstOrDefault(o => o.IdOrden == idOrdenSeleccionada);

                // Si se encuentra la orden, cargar los productos
                if (ordenSeleccionada != null)
                {
                    CargarProductosEnListView(ordenSeleccionada.Producto);
                }
            }
        }

        private void CargarProductosEnListView(List<Producto> productos)
        {
            DetalleOSList.Items.Clear();

            foreach (var producto in productos)
            {
                var item = new ListViewItem(producto.DescripcionProducto);
                item.SubItems.Add(producto.Cantidad.ToString());

                DetalleOSList.Items.Add(item);
            }
        }

        private void AgregarSeleccionadaOSButton_Click(object sender, EventArgs e)
        {
            // Asegurarse de que hay un elemento seleccionado en GenerarOrdenSeleccionBuscarList
            if (GenerarOrdenSeleccionBuscarList.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in GenerarOrdenSeleccionBuscarList.SelectedItems)
                {
                    // Clonar el elemento seleccionado
                    var itemClonado = (ListViewItem)selectedItem.Clone();

                    // Agregar el elemento clonado al segundo ListView (ejemplo: SeleccionOrdenesListView)
                    GenerarOSSeleccionadasList.Items.Add(itemClonado);

                    // (Opcional) Eliminar el ítem original del primer ListView si deseas moverlo
                    // GenerarOrdenSeleccionBuscarList.Items.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una orden antes de agregarla.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void QuitarSeleccionadasOSButton_Click(object sender, EventArgs e)
        {
            // Asegurarse de que hay elementos seleccionados en el segundo ListView (SeleccionOrdenesListView)
            if (GenerarOSSeleccionadasList.SelectedItems.Count > 0)
            {
                // Crear una lista temporal para almacenar los elementos seleccionados a eliminar
                List<ListViewItem> itemsAEliminar = new List<ListViewItem>();

                // Añadir los ítems seleccionados a la lista de eliminación
                foreach (ListViewItem selectedItem in GenerarOSSeleccionadasList.SelectedItems)
                {
                    itemsAEliminar.Add(selectedItem);
                }

                // Eliminar los elementos seleccionados del segundo ListView
                foreach (var item in itemsAEliminar)
                {
                    GenerarOSSeleccionadasList.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una orden antes de quitarla.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarOrdenButton_Click(object sender, EventArgs e)
        {
            // Generar una nueva orden y mostrar el mensaje
            string mensaje = $"Se generó orden de selección - {model.GenerarNuevaOrden()}";
            MessageBox.Show(mensaje, "Orden Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Eliminar los elementos seleccionados del ListView principal
            foreach (ListViewItem item in GenerarOSSeleccionadasList.Items)
            {
                // Encontrar el mismo elemento en el ListView principal y eliminarlo
                foreach (ListViewItem mainItem in GenerarOrdenSeleccionBuscarList.Items)
                {
                    if (mainItem.Text == item.Text)
                    {
                        GenerarOrdenSeleccionBuscarList.Items.Remove(mainItem);
                        break; // Salir del bucle una vez eliminado el elemento
                    }
                }
            }

            // Limpiar los dos ListView
            DetalleOSList.Items.Clear(); // Limpiar el ListView de selección
            GenerarOSSeleccionadasList.Items.Clear(); // Limpiar el ListView final (o el que quieras limpiar)

            // El primer ListView queda sin cambios, por lo que podrás seguir seleccionando y repitiendo el proceso
        }
    }
}
