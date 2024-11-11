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
            }
        }

        // Botón Volver
        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Botón Generar Orden de Entrega (aquí podrías agregar la lógica para generar una nueva orden)
        private void GenerarOrdenEntregaButton_Click(object sender, EventArgs e)
        {
            var resultado = modelo.GenerarNuevoIDOrden();
            MessageBox.Show(resultado);
            MostrarOrdenesActuales(); // Actualiza la vista después de generar la orden
        }

        private ListView listView1;

        private void GenerarOEbutton_Click(object sender, EventArgs e)
        {
            // Llamamos al método para generar el nuevo ID de orden
            var nuevoIDOrden = modelo.GenerarNuevoIDOrden();

            // Mostramos un mensaje con el nuevo ID de la orden
            MessageBox.Show($"Se generó {nuevoIDOrden}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Actualizamos la lista de órdenes
            MostrarOrdenesActuales();
        }
    }
}

