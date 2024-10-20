using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.ListarOrdenEntrega
{
    internal class OrdenPreparacion
    {
        public string IdOrden { get; set; }
        public string IdCliente {  get; set; }
        public string Transportista {  get; set; }
        public DateTime FechaEstado { get; set; }
    }
}
