using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.DespacharOrdenEntrega
{
    internal class Remito
    {
        public string IdRemito { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<string> OrdenesPreparacion { get; set; } = new();
        public string IdTransportista { get; set; }
    }
}
