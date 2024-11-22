using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupoB_TPP3_Prototipos.GenerarOrdenEntrega
{
    public partial class EmitirOrdenEntregaForm : Form
    {
        private EmitirOrdenEntregaModel modelo = new EmitirOrdenEntregaModel();

        public EmitirOrdenEntregaForm()
        {
            InitializeComponent();
            MostrarOrdenesActuales(); // Cambiamos para mostrar todas las órdenes del día
        }

        // Método para mostrar todas las órdenes de preparación con fecha de entrega actual
        private void MostrarOrdenesActuales()
        {
            var ordenes = modelo.ObtenerOrdenesPorEstadoPreparada(); // Llamada al método para obtener la lista de órdenes
            if (ordenes.Count > 0)
            {
                // Limpiar el ListView antes de agregar nuevos elementos
                OrdenesEntregalistView.Items.Clear();

                // Iterar sobre cada orden de preparación obtenida
                foreach (var orden in ordenes)
                {
                    var listViewItem = new ListViewItem(orden.IdOrden);
                    listViewItem.SubItems.Add(orden.IdCliente);
                    listViewItem.SubItems.Add(orden.FechaEntrega.ToShortDateString());
                    OrdenesEntregalistView.Items.Add(listViewItem);
                }
            }
            else
            {
                OrdenesEntregalistView.Items.Clear();
                MessageBox.Show("No hay órdenes de preparación en estado empaquetada.");
            }

            /* var ordenes = modelo.ObtenerOrdenesPorEstadoPreparada(); // Llamada al método para obtener la lista de órdenes
            if (ordenes.Count > 0) // Verifica si hay alguna orden para mostrar
            {
                // Limpiar el ListView antes de agregar nuevos elementos
                OrdenesEntregalistView.Items.Clear();

                // Iterar sobre cada orden de preparación obtenida
                foreach (var orden in ordenes)
                {
                    // Crear un nuevo elemento de la lista
                    var listViewItem = new ListViewItem(orden.IdOrden); // Primera columna: ID de la orden
                    listViewItem.SubItems.Add(orden.IdCliente); // Segunda columna: ID del cliente
                    listViewItem.SubItems.Add(orden.FechaEntrega.ToShortDateString()); // Tercera columna: Fecha de entrega

                    // Agregar el elemento al ListView
                    OrdenesEntregalistView.Items.Add(listViewItem);
                }
            }
            else
            {
                MessageBox.Show("No hay órdenes de preparación en estado preparada.");
            } */
        }

        // Botón Volver
        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Botón Generar Orden de Entrega (aquí podrías agregar la lógica para generar una nueva orden)
        private void GenerarOrdenEntregaButton_Click(object sender, EventArgs e)
        {
            if (OrdenesEntregalistView.SelectedItems.Count > 0)
            {
                // Obtener los IDs de las órdenes seleccionadas (de la primera columna)
                var idsSeleccionados = OrdenesEntregalistView.SelectedItems
                                        .Cast<ListViewItem>()
                                        .Select(item => item.SubItems[0].Text) // Extrae el texto del primer subelemento
                                        .ToList();

                // Cambia el estado de las órdenes seleccionadas
                modelo.CambiarEstadoOrden(idsSeleccionados);

                // Genera y guarda la nueva orden de entrega con los IDs seleccionados
                modelo.GenerarNuevaOrdenEntrega(idsSeleccionados);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Orden de entrega generada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Eliminar las órdenes seleccionadas del ListView
                foreach (ListViewItem item in OrdenesEntregalistView.SelectedItems)
                {
                    OrdenesEntregalistView.Items.Remove(item);
                }

                // Actualizar la lista de órdenes para reflejar los cambios
                MostrarOrdenesActuales();
            }
            else
            {
                // Mostrar un error si no se seleccionaron órdenes
                MessageBox.Show("Debe seleccionar al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*   if (OrdenesEntregalistView.SelectedItems.Count > 0)
              {
                  var idsSeleccionados = OrdenesEntregalistView.SelectedItems
                                          .Cast<ListViewItem>()
                                          .Select(item => item.SubItems[0].Text)
                                          .ToList();
                  modelo.GenerarNuevaOrdenEntrega(idsSeleccionados); // Genera la nueva orden de entrega
                  MostrarOrdenesActuales(); // Actualiza la vista después de generar la orden
              }
              else
              {
                  MessageBox.Show("Debe seleccionar al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              } */
        }

        private ListView listView1;

        private void GenerarOEbutton_Click(object sender, EventArgs e)
        {
            if (OrdenesEntregalistView.SelectedItems.Count > 0)
            {
                // Crear el nuevo ID para la orden de entrega
                var nuevoIDOrden = modelo.GenerarNuevoIDOrden();

                // Obtener los IDs de las órdenes de preparación seleccionadas (de la primera columna)
                var idsSeleccionados = OrdenesEntregalistView.SelectedItems
                                    .Cast<ListViewItem>()
                                    .Select(item => item.SubItems[0].Text)  // Extrae el texto del primer subelemento
                                    .ToList();

                // Verifica si los IDs seleccionados están correctos
                foreach (var id in idsSeleccionados)
                {
                    Console.WriteLine($"ID de Orden Seleccionada: {id}");
                }

                // Cambia el estado de las órdenes de preparación seleccionadas
                modelo.CambiarEstadoOrden(idsSeleccionados);

                // Crear y guardar la nueva orden de entrega con los IDs seleccionados
                modelo.GenerarNuevaOrdenEntrega(idsSeleccionados);

                // Mostrar un mensaje de éxito
                MessageBox.Show($"Orden de entrega generada con ID: {nuevoIDOrden}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar la lista de órdenes de preparación para reflejar los cambios
                MostrarOrdenesActuales();
            }
            else
            {
                // Mostrar un error si no se seleccionaron órdenes
                MessageBox.Show("Debe seleccionar al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrdenesEntregalistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdenesEntregalistView.SelectedItems.Count > 0)
            {
                // Obtener el ID de la orden seleccionada
                var idSeleccionado = OrdenesEntregalistView.SelectedItems[0].Text;
                Console.WriteLine($"Orden seleccionada con ID: {idSeleccionado}");
            }
        }

        private void EmitirOrdenEntregaForm_Load(object sender, EventArgs e)
        {
            label4.Text = $"Se emitirá una Orden Entrega con Id: {modelo.GenerarNuevoIDOrden()}";
        }
    }
}

