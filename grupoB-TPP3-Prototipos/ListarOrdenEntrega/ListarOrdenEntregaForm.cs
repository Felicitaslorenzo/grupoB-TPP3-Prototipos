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
using grupoB_TPP3_Prototipos.ListarOrdenPreparacion;
using System.Linq;

namespace grupoB_TPP3_Prototipos.ListarOrdenEntrega
{
    public partial class ListarOrdenEntregaForm : Form
    {
        private ListarOrdenEntregaModel model = new();
        public ListarOrdenEntregaForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ListarOrdenEntregaForm_Load);
            BuscarButton.Click += BuscarButton_Click;
            FechaDesdeOEPicker.ValueChanged += FechaDesdeOEPicker_ValueChanged;
            FechaHastaOEPicker.ValueChanged += FechaHastaOEPicker_ValueChanged;
            VolverButton.Click += new EventHandler(VolverButton_Click);
        }

        private void ListarOrdenEntregaForm_Load(object sender, EventArgs e)
        {
            var ordenesEntrega = model.ObtenerOrdenesEntrega();

            if (ordenesEntrega == null || !ordenesEntrega.Any())
            {
                MessageBox.Show("No se encontraron órdenes de entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarOrdenesEnListView(ordenesEntrega);

            // Extraer datos para cada ComboBox
            var idsClientes = ordenesEntrega
                .SelectMany(o => o.OrdenesPreparacion.Select(p => p.IdCliente))
                .Where(id => !string.IsNullOrEmpty(id)) // Filtrar valores nulos o vacíos
                .Distinct()
                .ToList();

            var idsOrdenesEntrega = ordenesEntrega
                .Select(o => o.IdOrdenEntrega)
                .Distinct()
                .ToList();

            var estadosOrdenEntrega = ordenesEntrega
                .SelectMany(o => o.OrdenesPreparacion.Select(p => p.Estado))  // Seleccionar Estado de cada OrdenEntrega
                .Where(estado => !string.IsNullOrEmpty(estado)) // Filtrar valores nulos o vacíos
                .Distinct()
                .ToList();

            // Cargar datos en los ComboBox
            IdClienteCombo.Items.Clear();
            IdClienteCombo.Items.Add(string.Empty); // Opción vacía

            foreach (var id in idsClientes)
            {
                IdClienteCombo.Items.Add(id); // Asegurarse de que 'id' no sea null
            }

            IdOrdenCombo.Items.Clear();
            IdOrdenCombo.Items.Add(string.Empty); // Opción vacía

            foreach (var id in idsOrdenesEntrega)
            {
                IdOrdenCombo.Items.Add(id); // Agregar las opciones de IdOrdenEntrega
            }

            EstadoCombo.Items.Clear();
            EstadoCombo.Items.Add(string.Empty); // Opción vacía

            foreach (var estado in estadosOrdenEntrega)
            {
                EstadoCombo.Items.Add(estado); // Agregar las opciones de Estado
            }
        }

        private void CargarOrdenesEnListView(IEnumerable<OrdenEntrega> ordenes)
        {
            // Limpiar el ListView antes de cargar los nuevos datos
            ListarOrdenEntregaList.Items.Clear();

            // Iterar sobre la colección de órdenes y agregar cada una al ListView
            foreach (var orden in ordenes)
            {
                // Crear un nuevo item con el ID de la orden de entrega
                var item = new ListViewItem(orden.IdOrdenEntrega);

                // Agregar la fecha de emisión como subitem (asegurándose de formatear la fecha)
                item.SubItems.Add(orden.FechaEmision.ToString("yyyy-MM-dd"));

                // Agregar la fecha de entrega como subitem (también con formato)
                item.SubItems.Add(orden.FechaEntrega.ToString("yyyy-MM-dd"));

                // Si deseas agregar más datos, por ejemplo, el Estado (descomentando la siguiente línea):
                // item.SubItems.Add(orden.Estado);

                // Añadir el item al ListView
                ListarOrdenEntregaList.Items.Add(item);
            }
        }

        private void FechaDesdeOEPicker_ValueChanged(object sender, EventArgs e)
        {
            FechaDesdeOEPicker.Format = DateTimePickerFormat.Short;
        }

        private void FechaHastaOEPicker_ValueChanged(object sender, EventArgs e)
        {
            FechaHastaOEPicker.Format = DateTimePickerFormat.Short;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdOrdenCombo.Text) &&
         string.IsNullOrEmpty(IdClienteCombo.Text) &&
         string.IsNullOrEmpty(EstadoCombo.Text) &&
         !FechaDesdeOEPicker.Checked &&
         !FechaHastaOEPicker.Checked)
            {
                MessageBox.Show("No se ha seleccionado ningún filtro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ordenesEntrega = model.ObtenerOrdenesEntrega();

            // Aplicar los filtros
            var ordenesFiltradas = ordenesEntrega.AsEnumerable();

            // Filtro por IdOrdenEntrega
            if (!string.IsNullOrEmpty(IdOrdenCombo.Text))
            {
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.IdOrdenEntrega == IdOrdenCombo.Text);
            }

            // Filtro por IdCliente
            if (!string.IsNullOrEmpty(IdClienteCombo.Text))
            {
                string idClienteSeleccionado = IdClienteCombo.Text;
                ordenesFiltradas = ordenesFiltradas.Where(orden =>
                    orden.OrdenesPreparacion.Any(p => p.IdCliente == idClienteSeleccionado)); // Filtra por el IdCliente de las órdenes de preparación
            }

            // Filtro por Estado
            if (!string.IsNullOrEmpty(EstadoCombo.Text))
            {
                string estadoSeleccionado = EstadoCombo.Text;
                ordenesFiltradas = ordenesFiltradas.Where(orden =>
                    orden.OrdenesPreparacion.Any(p => p.Estado == estadoSeleccionado)); // Filtra por el Estado de las órdenes de preparación
            }

            // Filtro por fechas (FechaDesdeOEPicker y FechaHastaOEPicker)
            if (FechaDesdeOEPicker.Checked && FechaHastaOEPicker.Checked)
            {
                DateTime fechaDesde = FechaDesdeOEPicker.Value;
                DateTime fechaHasta = FechaHastaOEPicker.Value;
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.FechaEmision >= fechaDesde && orden.FechaEmision <= fechaHasta);
            }
            else if (FechaDesdeOEPicker.Checked)
            {
                DateTime fechaDesde = FechaDesdeOEPicker.Value;
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.FechaEmision >= fechaDesde);
            }
            else if (FechaHastaOEPicker.Checked)
            {
                DateTime fechaHasta = FechaHastaOEPicker.Value;
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.FechaEmision <= fechaHasta);
            }

            // Cargar las órdenes filtradas en el ListView
            CargarOrdenesEnListView(ordenesFiltradas);

            // Si no se encontraron resultados, mostrar mensaje
            if (ListarOrdenEntregaList.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron órdenes de entrega con los criterios seleccionados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {

        }

        private void ListarOrdenEntregaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListarOrdenEntregaList.SelectedItems.Count > 0)
            {
                var selectedItem = ListarOrdenEntregaList.SelectedItems[0];
                var idOrdenEntrega = selectedItem.SubItems[0].Text; // Asumiendo que el ID de orden de entrega está en la primera columna

                var ordenEntrega = model.OrdenesEntregadas.FirstOrDefault(o => o.IdOrdenEntrega == idOrdenEntrega);

                if (ordenEntrega != null)
                {
                    CargarOrdenesPreparacionEnListView(ordenEntrega.OrdenesPreparacion);
                }
            }
        }
        private void CargarOrdenesPreparacionEnListView(List<OrdenPreparacion> ordenesPreparacion)
        {
            DetalleOrdenesPreparacionList.Items.Clear(); // Limpiar el ListView antes de cargar los nuevos datos

            // Iterar sobre la colección de órdenes de preparación y agregar cada una al ListView
            foreach (var orden in ordenesPreparacion)
            {
                // Crear un nuevo item con el Id de la orden de preparación
                var item = new ListViewItem(orden.IdOrden.ToString()); // Asegúrate de que 'IdOrden' se mapea correctamente

                // Agregar el estado de la orden de preparación como subitem
                item.SubItems.Add(orden.Estado.ToString()); // Convertir 'Estado' a string

                // Agregar la fecha de estado de la orden de preparación como subitem
                item.SubItems.Add(orden.FechaEstado.ToString("yyyy-MM-dd")); // Formatear la fecha

                // Añadir el item al ListView
                DetalleOrdenesPreparacionList.Items.Add(item);
            }
        }
    }
}







