using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.ListarOrdenPreparacion
{
    internal class OrdenPreparacion
    {
        public int IdOrden { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Prioridad { get; set; }
    }
}
