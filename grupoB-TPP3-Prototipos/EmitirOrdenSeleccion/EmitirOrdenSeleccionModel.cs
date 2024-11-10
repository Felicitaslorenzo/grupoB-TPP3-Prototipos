﻿using grupoB_TPP3_Prototipos.Almacenes;
using grupoB_TPP3_Prototipos.GenerarOrdenSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Generar_orden_de_Selección
{
    internal class EmitirOrdenSeleccionModel
    {
        public List<OrdenPreparacion> ObtenerOrdenesPreparacion()
        {
            // get
            {
                var listarOrdenes = new List<OrdenPreparacion>();

                foreach (var ordenEntidad in OrdenPreparacionAlmacen.OrdenesPreparacion)
                {
                    var ordenModelo = new OrdenPreparacion
                    {
                        IdCliente = ordenEntidad.IdCliente,
                        IdOrden = ordenEntidad.IdOrdenPreparacion,
                        Nombre = ClienteAlmacen.Clientes.First(c => c.IdCliente == ordenEntidad.IdCliente).NombreCliente,
                        Prioridad = ordenEntidad.Prioridad.ToString(),
                        Estado = ordenEntidad.Estado.ToString(),
                        FechaEmision = ordenEntidad.FechaEmision,
                        FechaEstado = ordenEntidad.FechaEntrega, // Asegúrate de que `FechaEntrega` esté definido en `OrdenPreparacion`.
                        Producto = ordenEntidad.Detalle.Select(detalle => new Producto
                        {
                            DescripcionProducto = detalle.DescripcionProducto,
                            // DescripcionProducto = ProductoAlmacen.Productos.First(pr => pr.SKUProducto == detalle.SKUProducto).DescripcionProducto,
                            Cantidad = detalle.Cantidad
                        }).ToList()
                    };

                    listarOrdenes.Add(ordenModelo); // Agrega el `ordenModelo` a la lista
                }

                return listarOrdenes;
            }
        } 
        public List<Cliente> ObtenerClientes()
        {
            var listaClientes = new List<Cliente>();  // Renombramos 'cliente' para evitar el conflicto.

            foreach (var clienteIterado in ClienteAlmacen.Clientes)  // Cambié 'cliente' por 'clienteIterado'.
            {
                var clienteModelo = new Cliente
                {
                    IdCliente = clienteIterado.IdCliente,
                    nombreCliente = clienteIterado.NombreCliente,
                    Transportistas = TransportistaAlmacen.Transportistas
                        .Where(transportista => transportista.IdCliente == clienteIterado.IdCliente)
                        .Select(transportista => transportista.IdTransportista)
                        .ToList()
                };

                listaClientes.Add(clienteModelo);  // Usamos listaClientes para agregar los clientes.
            }

            return listaClientes;
        } 

        private int numeroOrdenSeleccion = 1;

        // Método para obtener el siguiente número de orden
        public string GenerarNuevaOrden()
        {
            string nuevaOrden = $"OS-{numeroOrdenSeleccion:D3}"; // Formato de 3 dígitos
            numeroOrdenSeleccion++; // Incrementar el número de orden
            return nuevaOrden;
        }

        public void QuitarSeleccionadas(ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                // Crear una lista temporal para almacenar los elementos seleccionados a eliminar
                var itemsAEliminar = new List<ListViewItem>();

                // Añadir los ítems seleccionados a la lista de eliminación
                foreach (ListViewItem selectedItem in listView.SelectedItems)
                {
                    itemsAEliminar.Add(selectedItem);
                }

                // Eliminar los elementos seleccionados del ListView
                foreach (var item in itemsAEliminar)
                {
                    listView.Items.Remove(item);
                }
            }
            else
            {
                throw new InvalidOperationException("No hay elementos seleccionados para eliminar.");
            }
        }

        public void AgregarSeleccionadas(ListView sourceListView, ListView targetListView)
        {
            if (sourceListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in sourceListView.SelectedItems)
                {
                    // Clonar el elemento seleccionado
                    var itemClonado = (ListViewItem)selectedItem.Clone();

                    // Verificar si el item ya existe en targetListView
                    bool itemExists = false;
                    foreach (ListViewItem item in targetListView.Items)
                    {
                        if (item.Text == itemClonado.Text)
                        {
                            itemExists = true;
                            break;
                        }
                    }

                    // Si no existe, agregar el elemento clonado al segundo ListView
                    if (!itemExists)
                    {
                        targetListView.Items.Add(itemClonado);
                    }
                    else
                    {
                        throw new InvalidOperationException($"La orden '{itemClonado.Text}' ya fue seleccionada.");
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("Por favor seleccione una orden antes de agregarla.");
            }
        }

        public void CargarComboBox<T>(ComboBox comboBox, List<T> items, Func<T, string> getDisplayText)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(string.Empty); // O "Seleccione una opción"

            foreach (var item in items)
            {
                comboBox.Items.Add(getDisplayText(item));
            }
        }

        public void CargarListView<T>(List<T> items, ListView listView, Func<T, ListViewItem> crearItem)
        {
            listView.Items.Clear();

            foreach (var item in items)
            {
                var listViewItem = crearItem(item);
                listView.Items.Add(listViewItem);
            }
        }
    }
}