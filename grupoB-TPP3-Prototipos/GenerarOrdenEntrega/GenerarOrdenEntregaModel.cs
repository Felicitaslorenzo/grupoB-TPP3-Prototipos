using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.GenerarOrdenEntrega
{
    internal class GenerarOrdenEntregaModel
    {
        public List<OrdenEntrega> ordenesEntrega = new List<OrdenEntrega>
        {
            new OrdenEntrega()
        };

        private string GenerarIdOrden()
        {
            int id = 1;
            if(ordenesEntrega.Count > 0)
            {
                var idexistente = ordenesEntrega
                .Where(o => o != null && o.IdOdenEntrega != null && o.IdOdenEntrega.Length >= 6) // Verificar que el objeto y la propiedad no sean nulos
                .Select(o => int.Parse(o.IdOdenEntrega.Substring(3))) // Obtener solo la parte numérica
                .ToList();

                // Verificar si hay IDs existentes y calcular el nuevo ID
                if(idexistente.Count > 0)
                {
                    id=idexistente.Max() + 1;
                }
            }
            return "OE" + id;


        }

        public string GenerarNuevaOrden()
        {
            string idorden = GenerarIdOrden();

            OrdenEntrega ordennueva = new OrdenEntrega();
            
            return "a";
        }

        public List<Cliente> ObtenerCliente()
        {
            return new List<Cliente>
            {
                new Cliente { IdCliente = "CL001", Transportistas = new List<string> {"TR001", "TR002", "TR003", "CL001"}},
                new Cliente { IdCliente = "CL002", Transportistas = new List<string> {"TR004", "TR005", "CL002"}},
                new Cliente { IdCliente = "CL003", Transportistas = new List<string> {"TR006", "TR007", "CL003"}},
                new Cliente { IdCliente = "CL004", Transportistas = new List<string> {"TR008", "TR009", "TR010", "TR011", "CL004"}},
                new Cliente { IdCliente = "CL005", Transportistas = new List<string> {"TR012", "TR013", "CL005"}},
                new Cliente { IdCliente = "CL006", Transportistas = new List<string> {"TR014", "TR015", "CL006"}},
                new Cliente { IdCliente = "CL007", Transportistas = new List<string> {"TR016", "TR017", "CL007"}},
                new Cliente { IdCliente = "CL008", Transportistas = new List<string> {"TR018", "TR019", "CL008"}},
                new Cliente { IdCliente = "CL009", Transportistas = new List<string> {"TR020", "TR021", "CL009"}},
                new Cliente { IdCliente = "CL010", Transportistas = new List<string> {"TR022", "TR023", "CL010"}},
            };
        }

        internal List<Cliente> BuscarOrdenCliente(OrdenPreparacion ordenPreparacion)
        {
            switch(ordenPreparacion.IdOrden)
            {
                case "OP001":
                    return new List<Cliente>
            {
                new Cliente { IdCliente = "CL001" },
                new Cliente { IdCliente = "CL002" },
                new Cliente { IdCliente = "CL003" },
                new Cliente { IdCliente = "CL007" },
            };

                case "OP002":
                    return new List<Cliente>
            {
                new Cliente { IdCliente = "CL001" },
                new Cliente { IdCliente = "SKU004" },
                new Cliente { IdCliente = "SKU005" }
            };

                case "OP003":
                    return new List<Cliente>
            {
                new Cliente { IdCliente = "CL007" },
                new Cliente { IdCliente = "CL008" },
                new Cliente { IdCliente = "CL009" }
            };

                case "OP004":
                    return new List<Cliente>
            {
                new Cliente { IdCliente = "CL007" },
                new Cliente { IdCliente = "CL010" },
                new Cliente { IdCliente = "CL011" }
            };

                case "OP005":
                    return new List<Cliente>
            {
                new Cliente { IdCliente = "CL011" },
                new Cliente { IdCliente = "CL012" },
                new Cliente { IdCliente = "SKU013" }
            };

                case "OP006":
                    return new List<Cliente>
            {
                new Cliente { IdCliente = "CL007" },
                new Cliente { IdCliente = "CL010" },
                new Cliente { IdCliente = "CL014" }
            };

                case "OP007":
                    return new List<Cliente>
            {
                new Cliente { IdCliente = "CL007" },
                new Cliente { IdCliente = "CL015" },
                new Cliente { IdCliente = "CL016" }
            };

                case "OP008":
                    return new List<Cliente>
            {
                new Cliente { IdCliente = "CL017" },
                new Cliente { IdCliente = "CL018" },
                new Cliente { IdCliente = "CL019" }
            };

                case "OP009":
                    return new List<Cliente>
            {
                new Cliente { IdCliente = "CL015" },
                new Cliente { IdCliente = "CL016" }
            };

                case "OP010":
                    return new List<Cliente>
            {
                new Cliente { IdCliente = "CL007" },
                new Cliente { IdCliente = "CL018" },
                new Cliente { IdCliente = "CL019" },
                new Cliente { IdCliente = "CL014" }
            };

                default:
                    return new List<Cliente>();
            }

        }

        public List<OrdenPreparacion> ordenesPreparacion = new List<OrdenPreparacion>()
        {
            new OrdenPreparacion{IdOrden="OP001"},
            new OrdenPreparacion{IdOrden="OP002"},
            new OrdenPreparacion{IdOrden="OP003"},
            new OrdenPreparacion{IdOrden="OP004"},
            new OrdenPreparacion{IdOrden="OP005"},
            new OrdenPreparacion{IdOrden="OP006"},
            new OrdenPreparacion{IdOrden="OP007"},
            new OrdenPreparacion{IdOrden="OP008"},
            new OrdenPreparacion{IdOrden="OP009"},
            new OrdenPreparacion{IdOrden="OP010"}
        };
    }
}
