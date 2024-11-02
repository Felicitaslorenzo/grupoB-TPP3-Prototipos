using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal class OrdenEntregaEnt
    {
        public string IdOrdenEntrega { get; set; }
        public DateTime FechaEntrega { get; set; }
        public List<string> OrdenesPreparacion { get; } = new();

    }
}
