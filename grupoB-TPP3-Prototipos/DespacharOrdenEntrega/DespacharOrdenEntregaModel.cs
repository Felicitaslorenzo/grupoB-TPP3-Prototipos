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
        }

        public List<OrdenEntrega> ObtenerOrdenesEntrega()
        {
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
            };
        }

        public List<OrdenEntrega> ObtenerOrdenesEntregaPorCliente(string idCliente)
        {
            return ordenesEntrega.Where(o => o.IdCliente == idCliente).ToList();
        }
    }

}
