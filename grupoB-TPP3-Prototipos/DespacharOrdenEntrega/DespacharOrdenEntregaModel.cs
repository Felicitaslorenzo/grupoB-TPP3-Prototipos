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
        /*
            return new List<Cliente>
            {
                new Cliente { IdCliente = "CL001", Transportistas = new List<string> {"TR001", "TR002", "TR003"}},
                new Cliente { IdCliente = "CL002", Transportistas = new List<string> {"TR004", "TR005"}},
                new Cliente { IdCliente = "CL003", Transportistas = new List<string> {"TR006", "TR007"}},
                new Cliente { IdCliente = "CL004", Transportistas = new List<string> {"TR008", "TR009", "TR010", "TR011"}},
                new Cliente { IdCliente = "CL005", Transportistas = new List<string> {"TR012", "TR013"}},
                new Cliente { IdCliente = "CL006", Transportistas = new List<string> {"TR014", "TR015"}},
                new Cliente { IdCliente = "CL007", Transportistas = new List<string> {"TR016", "TR017"}},
                new Cliente { IdCliente = "CL008", Transportistas = new List<string> {"TR018", "TR019"}},
                new Cliente { IdCliente = "CL009", Transportistas = new List<string> {"TR019", "TR020"}},
                new Cliente { IdCliente = "CL010", Transportistas = new List<string> {"TR021", "TR022"}},
            };
        } */

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

            /*
            return new List<OrdenEntrega>
            {
               new OrdenEntrega("ORD001", "CL001", "Pendiente"),
               new OrdenEntrega("ORD002", "CL002", "En Proceso"),
               new OrdenEntrega("ORD003", "CL003",  "Completada"),
               new OrdenEntrega("ORD004", "CL004", "Pendiente"),
               new OrdenEntrega("ORD005", "CL005",  "En Proceso"),
               new OrdenEntrega("ORD006", "CL006",  "Completada"),
               new OrdenEntrega("ORD007", "CL007",  "Pendiente"),
               new OrdenEntrega("ORD008", "CL008",  "En Proceso"),
               new OrdenEntrega("ORD009", "CL009", "Completada"),
               new OrdenEntrega("ORD010", "CL010",  "Pendiente"),
               new OrdenEntrega("ORD011", "CL001",  "En Proceso"),
               new OrdenEntrega("ORD012", "CL002",  "Completada"),
               new OrdenEntrega("ORD013", "CL003",  "Pendiente"),
               new OrdenEntrega("ORD014", "CL004",  "En Proceso"),
               new OrdenEntrega("ORD015", "CL005",  "Completada"),
               new OrdenEntrega("ORD016", "CL006",  "Pendiente"),
               new OrdenEntrega("ORD017", "CL007", "En Proceso"),
               new OrdenEntrega("ORD018", "CL008",  "Completada"),
               new OrdenEntrega("ORD019", "CL009",  "Pendiente"),
               new OrdenEntrega("ORD020", "CL010",  "En Proceso")
            }; */
        }

        public List<OrdenEntrega> ObtenerOrdenesEntregaPorCliente(string idCliente)
        {
            return ordenesEntrega.Where(o => o.IdCliente == idCliente).ToList();
        }
    }

}
