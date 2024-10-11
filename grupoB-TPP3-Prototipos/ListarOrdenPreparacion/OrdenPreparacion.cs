using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.ListarOrdenPreparacion
{
    internal class OrdenPreparacion
    {
        public string IdOrden { get; set; }
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public DateTime FechaEstado { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<Producto> Producto { get; set; }
    }
}
