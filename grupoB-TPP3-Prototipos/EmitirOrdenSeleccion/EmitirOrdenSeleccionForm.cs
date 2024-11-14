using grupoB_TPP3_Prototipos.Almacenes;
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
            CargarPrioridadesEnComboBox();
        }
        private void CargarClientesEnComboBox(List<Cliente> clientes)
        {
            DescripcionClienteCombo.Items.Clear();
            DescripcionClienteCombo.Items.Add(string.Empty);

            foreach (var cliente in clientes)
            {
                DescripcionClienteCombo.Items.Add(cliente.nombreCliente);
            }
        }

        private void CargarOrdenesEnComboBox(List<OrdenPreparacion> ordenesPreparacion)
        {
            IdOrdenPreparacionCombo.Items.Clear();
            IdOrdenPreparacionCombo.Items.Add(string.Empty);

            var ordenesPendientes = ordenesPreparacion
                .Where(o => o.Estado == EstadoOrdenPrepEnum.Pendiente)
                .ToList();

            foreach (var orden in ordenesPendientes)
            {
                IdOrdenPreparacionCombo.Items.Add(orden.IdOrden);
            }
        }

        private void CargarPrioridadesEnComboBox()
        {
            // Obtener las prioridades desde el enum usando el método del modelo
            var prioridades = model.ObtenerPrioridad();

            // Limpiar el ComboBox y agregar las prioridades
            PrioridadCombo.Items.Clear();
            PrioridadCombo.Items.AddRange(prioridades.ToArray());
        }

        private void CargarOrdenesEnListView(List<OrdenPreparacion> ordenesPreparacion)
        {
            GenerarOrdenSeleccionBuscarList.Items.Clear();

            var ordenesPendientes = ordenesPreparacion
                .Where(o => o.Estado == EstadoOrdenPrepEnum.Pendiente)
                .ToList();

            foreach (var orden in ordenesPendientes)
            {
                ListViewItem item = new ListViewItem(orden.IdOrden)
                {
                    SubItems = {
                orden.Nombre,
                orden.FechaEmision.ToString("dd/MM/yyyy")
            }
                };
                GenerarOrdenSeleccionBuscarList.Items.Add(item);
            }
        }

        private void CargarProductosEnListView(List<Producto> productos)
        {
            DetalleOSList.Items.Clear();

            foreach (var producto in productos)
            {
                ListViewItem item = new ListViewItem(producto.DescripcionProducto)
                {
                    SubItems = {
                producto.Cantidad.ToString()
            }
                };
                DetalleOSList.Items.Add(item);
            }
        }

        private void AgregarSeleccionadas(ListView sourceListView, ListView targetListView)
        {
            if (sourceListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in sourceListView.SelectedItems)
                {
                    var itemClonado = (ListViewItem)selectedItem.Clone();
                    bool itemExists = targetListView.Items
                        .Cast<ListViewItem>()
                        .Any(item => item.Text == itemClonado.Text);

                    if (!itemExists)
                    {
                        targetListView.Items.Add(itemClonado);
                    }
                    else
                    {
                        MessageBox.Show($"La orden '{itemClonado.Text}' ya fue seleccionada.", "Elemento Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una orden antes de agregarla.", "Sin Selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void QuitarSeleccionadas(ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                var itemsAEliminar = listView.SelectedItems.Cast<ListViewItem>().ToList();
                foreach (var item in itemsAEliminar)
                {
                    listView.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados para eliminar.", "Sin Selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            // Validar si se ha seleccionado algún filtro
            if (string.IsNullOrEmpty(IdOrdenPreparacionCombo.Text) &&
                string.IsNullOrEmpty(DescripcionClienteCombo.Text) &&
                string.IsNullOrEmpty(PrioridadCombo.Text) &&
                !FechaOSDesdePicker.Checked &&
                !FechaOSHastaPicker.Checked)
            {
                MessageBox.Show("No se ha seleccionado ningún filtro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valores seleccionados en los desplegables
            string nombreClienteSeleccionado = DescripcionClienteCombo.Text;
            string idOrdenSeleccionado = IdOrdenPreparacionCombo.Text;
            string prioridadSeleccionada = PrioridadCombo.Text;

            // Filtrar OrdenesPreparacionList directamente por el nombre del cliente
            var ordenesFiltradas = model.ObtenerOrdenesPreparacion().Where(o =>
                (string.IsNullOrEmpty(idOrdenSeleccionado) || o.IdOrden == idOrdenSeleccionado) &&
                (string.IsNullOrEmpty(nombreClienteSeleccionado) || o.Nombre == nombreClienteSeleccionado) && // Usar nombre directamente
                (string.IsNullOrEmpty(prioridadSeleccionada) || o.Prioridad == prioridadSeleccionada));

            // Aplicar filtros de fechas
            if (FechaOSDesdePicker.Checked && FechaOSHastaPicker.Checked)
            {
                DateTime fechaDesde = FechaOSDesdePicker.Value;
                DateTime fechaHasta = FechaOSHastaPicker.Value;
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.FechaEmision >= fechaDesde && orden.FechaEmision <= fechaHasta);
            }
            else if (FechaOSDesdePicker.Checked)
            {
                DateTime fechaDesde = FechaOSDesdePicker.Value;
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.FechaEmision >= fechaDesde);
            }
            else if (FechaOSHastaPicker.Checked)
            {
                DateTime fechaHasta = FechaOSHastaPicker.Value;
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.FechaEmision <= fechaHasta);
            }
            //Filtramos solo las que están Pendientes
            ordenesFiltradas = ordenesFiltradas.Where(o => o.Estado == EstadoOrdenPrepEnum.Pendiente);


            GenerarOrdenSeleccionBuscarList.Items.Clear();

            if (!ordenesFiltradas.Any())
            {
                MessageBox.Show("No hay órdenes con los criterios seleccionados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Agregar elementos filtrados a la OrdenesPreparacionList
            foreach (var ordenPreparacion in ordenesFiltradas)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ordenPreparacion.IdOrden.ToString();
                item.SubItems.Add(ordenPreparacion.Nombre);
                item.SubItems.Add(ordenPreparacion.FechaEstado.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ordenPreparacion.FechaEmision.ToString("dd/MM/yyyy"));

                GenerarOrdenSeleccionBuscarList.Items.Add(item);
            }
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

        private void AgregarSeleccionadaOSButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar al método del modelo para agregar elementos seleccionados
                AgregarSeleccionadas(GenerarOrdenSeleccionBuscarList, GenerarOSSeleccionadasList);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void QuitarSeleccionadasOSButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar al método del modelo para quitar los elementos seleccionados
                QuitarSeleccionadas(GenerarOSSeleccionadasList);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarOrdenButton_Click(object sender, EventArgs e)
        {
            // Verificar si hay órdenes seleccionadas en el ListView final
            if (GenerarOSSeleccionadasList.Items.Count > 0)
            {
                // Obtener las órdenes de preparación seleccionadas
                List<string> opSeleccionadas = ObtenerOrdenesPreparacionSeleccionadas();
                var nuevaOrdenSeleccion = new OrdenSeleccionEnt
                {
                    IdOrdenSeleccion = model.GenerarNuevaOrden(), // Generar un ID único
                    FechaEmision = DateTime.Now,
                    Estado = EstadoOrdenSelEnum.Pendiente, // Establecer el estado por defecto
                    FechaEstado = DateTime.Now,
                    OrdenesPreparacion = opSeleccionadas
                };
                OrdenSeleccionAlmacen.AgregarOrdenSeleccion(nuevaOrdenSeleccion);

                // Cambiar el estado de las órdenes de preparación seleccionadas de EnSeleccion a Seleccionada
                foreach (var idOrdenPrep in opSeleccionadas)
                {
                    var ordenPrepEntidad = OrdenPreparacionAlmacen.OrdenesPreparacion.FirstOrDefault(o => o.IdOrdenPreparacion == idOrdenPrep);
                    if (ordenPrepEntidad != null && ordenPrepEntidad.Estado == EstadoOrdenPrepEnum.Pendiente)
                    {
                        ordenPrepEntidad.Estado = EstadoOrdenPrepEnum.EnSeleccion;
                    }
                }

                // Grabar los cambios
                OrdenPreparacionAlmacen.Grabar();

                // Generar una nueva orden y mostrar el mensaje
                string mensaje = $"Se generó {nuevaOrdenSeleccion.IdOrdenSeleccion}";
                MessageBox.Show(mensaje, "Orden Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Eliminar los elementos seleccionados del ListView principal
                foreach (ListViewItem item in GenerarOSSeleccionadasList.Items)
                {
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
                GenerarOSSeleccionadasList.Items.Clear(); // Limpiar el ListView final
            } // aca esta la actu
            else
            {
                // Mostrar mensaje si no se ha seleccionado ninguna orden
                MessageBox.Show("Debe seleccionar al menos una orden.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<string> ObtenerOrdenesPreparacionSeleccionadas()
        {
            List<string> opSeleccionadas = new List<string>();

            foreach (ListViewItem item in GenerarOSSeleccionadasList.Items)
            {
                string idOP = item.Text;
                opSeleccionadas.Add(idOP);
            }

            return opSeleccionadas;
        }

        private void buttonGenerarOrdenSeleccion_Click(object sender, EventArgs e)
        {

        }

        private void PrioridadCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
