using grupoB_TPP3_Prototipos.GenerarOrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Generar_orden_de_Selección
{
    internal class GenerarOrdenSeleccionModel
    {
        internal void CargarCliente(ComboBox IdClienteCombo)
        {
            var clientes = ObtenerCliente();

            IdClienteCombo.Items.Clear();
            foreach (var cliente in clientes)
            {
                IdClienteCombo.Items.Add(cliente);
            }
            IdClienteCombo.DisplayMember = "IdCliente";
        }
        public List<Cliente> ObtenerCliente()
        {
            return new List<Cliente>
            {
                new Cliente { IdCliente = "CL001", Transportista = "TR001" },
                new Cliente { IdCliente = "CL002", Transportista = "TR002" },
                new Cliente { IdCliente = "CL003", Transportista = "TR003" },
                new Cliente { IdCliente = "CL004", Transportista = "TR004" },
                new Cliente { IdCliente = "CL005", Transportista = "TR005" },
                new Cliente { IdCliente = "CL006", Transportista = "TR006" },
                new Cliente { IdCliente = "CL007", Transportista = "TR007" },
                new Cliente { IdCliente = "CL008", Transportista = "TR008" },
                new Cliente { IdCliente = "CL009", Transportista = "TR009" },
                new Cliente { IdCliente = "CL010", Transportista = "TR010" },
            };
        }
    }
}
