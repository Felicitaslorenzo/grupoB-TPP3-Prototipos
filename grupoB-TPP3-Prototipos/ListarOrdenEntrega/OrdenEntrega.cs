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
        public string IdOrdenEntrega { get; set; }
        // public string Estado { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaEntrega { get; set; }
        public List <OrdenPreparacion> OrdenesPreparacion { get; set; }
    }
}

