using grupoB_TPP3_Prototipos.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.GenerarOrdenSeleccion
{
    internal class OrdenSeleccion
    {
        public string IdOrden { get; set; }
        public EstadoOrdenSelEnum Estado { get; set; }
        public DateTime FechaEstado { get; set; }
        public DateTime FechaEmision { get; set; }
        //public List<OrdenPreparacion> OrdenPreparacion{ get; set; }

    }
}
