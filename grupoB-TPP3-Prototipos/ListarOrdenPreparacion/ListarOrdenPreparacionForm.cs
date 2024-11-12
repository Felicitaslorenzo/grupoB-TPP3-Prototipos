using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.ListarOrdenPreparacion
{

    public partial class ListarOrdenPreparacionForm : Form
    {
        private ListarOrdenPreparacionModel model = new();
        public ListarOrdenPreparacionForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ListarOrdenPreparacionForm_Load);
            BuscarButton.Click += BuscarButton_Click;
            FechaDesdeOPPicker.ValueChanged += FechaDesdeOSPicker_ValueChanged;
            FechaHastaOPPicker.ValueChanged += FechaHastaOSPicker_ValueChanged;
        }

        

    private void FechaDesdeOSPicker_ValueChanged(object? sender, EventArgs e)
    {
        FechaDesdeOPPicker.Format = DateTimePickerFormat.Short;
    }

    private void FechaHastaOSPicker_ValueChanged(object? sender, EventArgs e)
    {
        FechaHastaOPPicker.Format = DateTimePickerFormat.Short;
    }


    private void ListarOrdenPreparacionForm_Load(object sender, EventArgs e)
        {
            var ordenesPreparacion = model.ObtenerOrdenesPreparacion();

            // Extraer datos para cada ComboBox
            var nombresClientes = ordenesPreparacion.Select(o => o.Nombre).Distinct().ToList();
            var idsClientes = ordenesPreparacion.Select(o => o.IdCliente).Distinct().ToList();
            var idsOrdenesPreparacion = ordenesPreparacion.Select(o => o.IdOrden).Distinct().ToList();
            var prioridadesOrdenPreparacion = ordenesPreparacion.Select(o => o.Prioridad).Distinct().ToList();
            var estadosOrdenPreparacion = ordenesPreparacion.Select(o => o.Estado).Distinct().ToList();

            // Agregar opción vacía y cargar datos en los desplegables


            IdOrdenPreparacionCombo.Items.Add("");
            foreach (var id in idsOrdenesPreparacion)
            {
                if (id != null)
                {
                    IdOrdenPreparacionCombo.Items.Add(id);
                }

            }

            NombreClienteCombo.Items.Add("");
            foreach (var nombre in nombresClientes)
            {
                NombreClienteCombo.Items.Add(nombre);
            }

            IdClienteCombo.Items.Add("");
            foreach (var id in idsClientes)
            {
                if (id != null)
                {
                    IdClienteCombo.Items.Add(id);
                }
               
                //IdClienteCombo.Items.Add(id);
            }

            PrioridadOrdenPreparacionCombo.Items.Add("");
            foreach (var prioridad in prioridadesOrdenPreparacion)
            {
                PrioridadOrdenPreparacionCombo.Items.Add(prioridad);
            }

            EstadoOrdenPreparacionCombo.Items.Add("");
            foreach (var estado in estadosOrdenPreparacion)
            {
                EstadoOrdenPreparacionCombo.Items.Add(estado);
            }

            OrdenesPreparacionList.View = View.Details;
            foreach (var ordenPreparacion in model.ObtenerOrdenesPreparacion())
            {
                ListViewItem item = new ListViewItem();
                item.Text = ordenPreparacion.IdOrden;
                item.SubItems.Add(ordenPreparacion.IdCliente.ToString());
                item.SubItems.Add(ordenPreparacion.Nombre);
                item.SubItems.Add(ordenPreparacion.Estado);
                item.SubItems.Add(ordenPreparacion.FechaEstado.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ordenPreparacion.FechaEmision.ToString("dd/MM/yyyy"));

                OrdenesPreparacionList.Items.Add(item);
            }

            OrdenesPreparacionList.SelectedIndexChanged += OrdenesPreparacionList_SelectedIndexChanged;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            // Validar si se ha seleccionado algún filtro
            if (string.IsNullOrEmpty(IdOrdenPreparacionCombo.Text) &&
                string.IsNullOrEmpty(IdClienteCombo.Text) &&
                string.IsNullOrEmpty(NombreClienteCombo.Text) &&
                string.IsNullOrEmpty(EstadoOrdenPreparacionCombo.Text) &&
                string.IsNullOrEmpty(PrioridadOrdenPreparacionCombo.Text) &&
                !FechaDesdeOPPicker.Checked &&
                !FechaHastaOPPicker.Checked)
            {
                MessageBox.Show("No se ha seleccionado ningún filtro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valores seleccionados en los desplegables
            string idClienteSeleccionado = IdClienteCombo.Text;
            string idOrdenSeleccionado = IdOrdenPreparacionCombo.Text;
            string nombreClienteSeleccionado = NombreClienteCombo.Text;
            string estadoSeleccionado = EstadoOrdenPreparacionCombo.Text;
            string prioridadSeleccionada = PrioridadOrdenPreparacionCombo.Text;

            // Filtrar OrdenesPreparacionList
            var ordenesFiltradas = model.ObtenerOrdenesPreparacion().Where(o =>
                (string.IsNullOrEmpty(idOrdenSeleccionado) || o.IdOrden == idOrdenSeleccionado) &&
                (string.IsNullOrEmpty(idClienteSeleccionado) || o.IdCliente == idClienteSeleccionado) &&
                (string.IsNullOrEmpty(nombreClienteSeleccionado) || o.Nombre == nombreClienteSeleccionado) &&
                (string.IsNullOrEmpty(prioridadSeleccionada) || o.Prioridad == prioridadSeleccionada) &&
                (string.IsNullOrEmpty(estadoSeleccionado) || o.Estado == estadoSeleccionado));

            // Aplicar filtros de fechas
            if (FechaDesdeOPPicker.Checked && FechaHastaOPPicker.Checked)
            {
                DateTime fechaDesde = FechaDesdeOPPicker.Value.Date;  // Solo fecha (sin la hora)
                DateTime fechaHasta = FechaHastaOPPicker.Value.Date;  // Solo fecha (sin la hora)

                // Filtrar por FechaEmision usando FechaDesdeOPPicker
                ordenesFiltradas = ordenesFiltradas.Where(orden =>
                    orden.FechaEmision.Date == fechaDesde &&
                    orden.FechaEstado.Date == fechaHasta);  // Filtrar por FechaEstado usando FechaHastaOPPicker
            }
            else if (FechaDesdeOPPicker.Checked)
            {
                DateTime fechaDesde = FechaDesdeOPPicker.Value.Date;  // Solo fecha (sin la hora)

                // Filtrar solo por FechaEmision
                ordenesFiltradas = ordenesFiltradas.Where(orden =>
                    orden.FechaEmision.Date == fechaDesde);
            }
            else if (FechaHastaOPPicker.Checked)
            {
                DateTime fechaHasta = FechaHastaOPPicker.Value.Date;  // Solo fecha (sin la hora)

                // Filtrar solo por FechaEstado
                ordenesFiltradas = ordenesFiltradas.Where(orden =>
                    orden.FechaEstado.Date == fechaHasta);
            }

            // Limpiar el ListView antes de agregar los elementos filtrados
            OrdenesPreparacionList.Items.Clear();

            if (!ordenesFiltradas.Any())
            {
                MessageBox.Show("No hay órdenes con los criterios seleccionados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Agregar elementos filtrados a la lista
            foreach (var ordenPreparacion in ordenesFiltradas)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ordenPreparacion.IdOrden.ToString();
                item.SubItems.Add(ordenPreparacion.IdCliente.ToString());
                item.SubItems.Add(ordenPreparacion.Nombre);
                item.SubItems.Add(ordenPreparacion.Estado);
                item.SubItems.Add(ordenPreparacion.FechaEstado.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ordenPreparacion.FechaEmision.ToString("dd/MM/yyyy"));

                OrdenesPreparacionList.Items.Add(item);
            }
        }

        private void ListarOrdenesPreparacionGroup_Enter(object sender, EventArgs e)
        {

        }

        private void ListarOrdenPreparacionForm_Load_1(object sender, EventArgs e)
        {
        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {

        }

        private void OrdenesPreparacionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdenesPreparacionList.SelectedItems.Count > 0)
            {
                var idOrdenSeleccionada = OrdenesPreparacionList.SelectedItems[0].Text;
                var ordenSeleccionada = model.ObtenerOrdenesPreparacion().FirstOrDefault(o => o.IdOrden == idOrdenSeleccionada);

                if (ordenSeleccionada != null)
                {
                    ProductosList.Items.Clear();

                    if (ordenSeleccionada.Producto != null && ordenSeleccionada.Producto.Any())
                    {
                        // Agregamos cada producto al ListView de productos
                        foreach (var producto in ordenSeleccionada.Producto)
                        {
                            ListViewItem item = new ListViewItem(producto.IDProducto); 
                            item.SubItems.Add(producto.DescripcionProducto); 
                            item.SubItems.Add(producto.Cantidad.ToString()); 

                            ProductosList.Items.Add(item); 
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron productos para esta orden.");
                    }
                }
            }
        }



        private void VolverListaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

