using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Empaquetado
{
    internal class OrdenPreparacion
    {
        public string IdOrden { get; set; }
        public string Nombre { get; set; }
        public string Transportista { get; set; }
        public List<Producto> Producto { get; set; }
    }
}
