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
        public DateTime FechaOS { get; set; }
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }
        public string Ubicacion { get; set; }
        public string Estado {  get; set; }
    }
}
