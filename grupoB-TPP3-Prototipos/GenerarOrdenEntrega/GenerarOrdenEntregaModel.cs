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
        }

    }
}
