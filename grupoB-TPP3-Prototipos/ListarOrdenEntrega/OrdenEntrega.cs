using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using grupoB_TPP3_Prototipos.ListarOrdenEntrega;

namespace grupoB_TPP3_Prototipos.ListarOrdenEntrega
{
    internal class OrdenEntrega
    {
        public string IdOrden { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public DateTime FechaEstado { get; set; }
        public DateTime FechaEmision { get; set; }

    }
}

