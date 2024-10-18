using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.RetirarOrdenSeleccion
{
    internal class OrdenPreparacion
    {
        public string IdOrden { get; set; }
        public string Cliente { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaDespacho { get; set; }
        public List<Producto> Producto { get; set; }
    }
}

