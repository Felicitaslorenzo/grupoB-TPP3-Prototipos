using grupoB_TPP3_Prototipos.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.RetirarOrdenSeleccion
{
    internal class OrdenSeleccion
    {
        public string IdOrdenSeleccion { get; set; }
        public EstadoOrdenSelEnum Estado { get; set; }
        public List<Producto> Producto { get; set; }
    }
}
