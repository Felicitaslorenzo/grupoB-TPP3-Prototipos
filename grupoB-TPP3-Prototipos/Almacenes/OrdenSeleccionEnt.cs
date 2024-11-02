using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal class OrdenSeleccionEnt
    {
        public string IdOrdenSeleccion { get; set; }
        public EstadoOrdenSelEnum Estado { get; set; }
        public DateTime FechaEstado { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<string> OrdenesPreparacion { get; } = new();

    }
}
