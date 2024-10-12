using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.GenerarOrdenEntrega
{
    internal class Cliente
    {
        public string IdCliente { get; set; }
        public string Prioridad { get; set; }
        public List<string> Transportistas { get; set; }
    }
}
