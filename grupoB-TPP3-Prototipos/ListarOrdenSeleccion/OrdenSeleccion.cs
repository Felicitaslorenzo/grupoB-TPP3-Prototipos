using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.ListarOrdenSeleccion
{
    internal class OrdenSeleccion
    {
        public string IdOrdenSeleccion { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaEstado { get; set; }
        public string Estado {  get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
    }
}
