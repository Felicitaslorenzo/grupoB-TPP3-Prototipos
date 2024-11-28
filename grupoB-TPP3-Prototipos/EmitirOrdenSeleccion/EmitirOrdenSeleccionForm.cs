using grupoB_TPP3_Prototipos.Almacenes;
using grupoB_TPP3_Prototipos.Generar_orden_de_Selección;
using grupoB_TPP3_Prototipos.GenerarOrdenSeleccion;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.Xml;
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
                orden.FechaEstado.ToString("dd/MM/yyyy") // ACA HICE EL CAMBIO 
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

            // Obtener los valores seleccionados en los filtros
            string idOrdenSeleccionado = IdOrdenPreparacionCombo.Text.Trim();
            string nombreClienteSeleccionado = DescripcionClienteCombo.Text.Trim();
            string prioridadSeleccionada = PrioridadCombo.Text.Trim();

            // Obtener todas las órdenes de preparación
            var ordenesPreparacion = model.ObtenerOrdenesPreparacion();

            // Filtrar las órdenes basándonos en los criterios seleccionados
            var ordenesFiltradas = ordenesPreparacion.Where(o =>
                (string.IsNullOrEmpty(idOrdenSeleccionado) || o.IdOrden.Equals(idOrdenSeleccionado, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(nombreClienteSeleccionado) || o.Nombre.Equals(nombreClienteSeleccionado, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(prioridadSeleccionada) || o.Prioridad.Equals(prioridadSeleccionada, StringComparison.OrdinalIgnoreCase))
            );

            // Filtrar por Fecha Desde (FechaEmision)
            if (FechaOSDesdePicker.Checked)
            {
                DateTime fechaDesde = FechaOSDesdePicker.Value.Date;
                ordenesFiltradas = ordenesFiltradas.Where(o => o.FechaEmision.Date >= fechaDesde);
            }

            // Filtrar por Fecha Hasta (FechaEntrega)
            if (FechaOSHastaPicker.Checked)
            {
                DateTime fechaHasta = FechaOSHastaPicker.Value.Date;
                ordenesFiltradas = ordenesFiltradas.Where(o => o.FechaEstado.Date <= fechaHasta);
            }

            // Filtrar solo las órdenes pendientes
            ordenesFiltradas = ordenesFiltradas.Where(o => o.Estado == EstadoOrdenPrepEnum.Pendiente);

            // Limpiar el ListView antes de cargar los resultados
            GenerarOrdenSeleccionBuscarList.Items.Clear();

            // Mostrar mensaje si no hay resultados
            if (!ordenesFiltradas.Any())
            {
                MessageBox.Show("No hay órdenes con los criterios seleccionados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Agregar las órdenes filtradas al ListView
            foreach (var ordenPreparacion in ordenesFiltradas)
            {
                var item = new ListViewItem(ordenPreparacion.IdOrden.ToString());
                item.SubItems.Add(ordenPreparacion.Nombre);
                item.SubItems.Add(ordenPreparacion.FechaEstado.ToString("dd/MM/yyyy")); // Mostrar solo FechaEntrega

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
                // OrdenPreparacionAlmacen.Grabar();

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

        private void EmitirOrdenSeleccionForm_Load(object sender, EventArgs e)
        {
            label5.Text = $"Se emitirá la Orden Selección con Id: {model.GenerarNuevaOrden()}";
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los filtros de los ComboBox
            IdOrdenPreparacionCombo.SelectedIndex = 0; // Seleccionar el primer elemento vacío
            DescripcionClienteCombo.SelectedIndex = 0; // Seleccionar el primer elemento vacío
            PrioridadCombo.SelectedIndex = -1; // Seleccionar el primer elemento vacío

            // Limpiar los DateTimePickers
            FechaOSDesdePicker.Checked = false;
            FechaOSHastaPicker.Checked = false;

            // Volver a cargar todos los datos en los ListView
            var modelo = new EmitirOrdenSeleccionModel();
            var ordenesPreparacion = modelo.ObtenerOrdenesPreparacion();
            CargarOrdenesEnListView(ordenesPreparacion);
            CargarProductosEnListView(new List<Producto>());
        }
    }
}
