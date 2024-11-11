using grupoB_TPP3_Prototipos.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace grupoB_TPP3_Prototipos.DespacharOrdenEntrega
{
    internal class DespacharOrdenEntregaModel
    {
        private List<Cliente> clientes;
        private List<OrdenEntrega> ordenesEntrega;

        public DespacharOrdenEntregaModel()
        {
            clientes = ObtenerClientes();
            ordenesEntrega = ObtenerOrdenesEntrega();
        }

        public List<string> ObtenerTransportistas()
        {
            return clientes.SelectMany(c => c.Transportistas).Distinct().ToList();
        }

        public string ObtenerClientePorTransportista(string idTransportista)
        {
            var cliente = clientes.FirstOrDefault(c => c.Transportistas.Contains(idTransportista));
            return cliente?.IdCliente; 
        }

        public List<Cliente> ObtenerClientes()
        {
            var listarClientes = new List<Cliente>();

            foreach (var ordenCliente in ClienteAlmacen.Clientes)
            {
                // Crear una nueva instancia de Cliente
                var ordenModelo = new Cliente
                {
                    IdCliente = ordenCliente.IdCliente,
                    // Asumiendo que Cliente tiene una propiedad llamada Transportistas que es una lista de enteros (IdTransportista)
                    Transportistas = TransportistaAlmacen.Transportistas
                        .Where(t => t.IdCliente == ordenCliente.IdCliente)
                        .Select(t => t.IdTransportista)
                        .ToList()
                };

                // Agregar el cliente con sus transportistas a la lista
                listarClientes.Add(ordenModelo);
            }

            // Devolver la lista de clientes con sus respectivos transportistas
            return listarClientes;
        }

        public List<OrdenEntrega> ObtenerOrdenesEntrega()
        {
            var listarOrden = new List<OrdenEntrega>();

            foreach (var ordenEntidad in OrdenPreparacionAlmacen.OrdenesPreparacion)
            {
                // Suponiendo que `OrdenEntrega` tiene un constructor que requiere "idOrden", "idCliente" y otros parámetros
                var idCliente = ClienteAlmacen.Clientes
                    .Where(c => c.IdCliente == /* usar propiedad correcta aquí */ ordenEntidad.IdCliente) // Ajusta la propiedad correcta de ordenEntidad
                    .Select(c => c.IdCliente)
                    .FirstOrDefault();

                var estado = ordenEntidad.Estado.ToString(); // VER ESTADO

                // Crear una nueva instancia de OrdenEntrega con el constructor que requiere los parámetros
                var ordenModelo = new OrdenEntrega(
                    ordenEntidad.IdOrdenPreparacion,   // idOrden
                    idCliente ,                    // idCliente (o proporciona un valor predeterminado si idCliente es nulo)
                    estado // VER ESTADO
            /* otros parámetros requeridos */
                );

                // Agregar la orden de entrega a la lista
                listarOrden.Add(ordenModelo);
            }

            // Devolver la lista de órdenes de entrega
            return listarOrden;
        }

        /* public List<OrdenEntrega> ObtenerOrdenesEntregaPorCliente(string idCliente)
        {
            return ordenesEntrega.Where(o => o.IdCliente == idCliente).ToList();
        } */

        public List<OrdenEntrega> ObtenerOrdenesEntregaPorTransportista(string transportista)
        {
            // Obtener las órdenes de preparación desde el almacén (como una lista de OrdenPreparacionEnt)
            var ordenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(o => o.IdTransportista == transportista && (int)o.Estado == 4)  // Filtrar por transportista y estado 4 (Despachada)
                .ToList();

            // Convertir la lista de OrdenPreparacionEnt en una lista de OrdenEntrega
            List<OrdenEntrega> ordenesEntrega = new List<OrdenEntrega>();

            foreach (var ordenPrep in ordenesPreparacion)
            {
                // Mapear cada OrdenPreparacionEnt a una OrdenEntrega
                OrdenEntrega orden = new OrdenEntrega(
                    ordenPrep.IdOrdenPreparacion,  // idOrden
                    ordenPrep.IdCliente.ToString(), // idCliente (convertido a string si es necesario)
                    ordenPrep.Estado.ToString()    // estado (convertido a string desde Enum)
                );

                // Agregar la nueva orden a la lista
                ordenesEntrega.Add(orden);
            }

            return ordenesEntrega;
        }

        public string GenerarNuevoIDRemito()
        {
            // Leer las órdenes desde el archivo (simulamos que ya tienes la lógica para leer desde un almacenamiento)
            RemitoAlmacen.Leer();

            // Obtener el último ID de las órdenes
            var ultimoId = RemitoAlmacen.Remitos
                .Select(o => o.IdRemito)
                .OrderByDescending(id => id)
                .FirstOrDefault();

            // Si no existe ninguna orden, empezamos con "RM001"
            if (string.IsNullOrEmpty(ultimoId))
            {
                return "RM001";
            }

            // Extraemos el número al final del ID, en el formato "RM###"
            var numero = int.Parse(ultimoId.Substring(2));  // Asumimos que el ID tiene el formato "RM###" (después de "RM")

            // Incrementamos el número
            numero++;

            // Generamos el nuevo ID en el formato "RM###"
            return $"RM{numero:D3}";  // El ":D3" asegura que el número tenga 3 dígitos, por ejemplo "RM002"
        }

    }
}
