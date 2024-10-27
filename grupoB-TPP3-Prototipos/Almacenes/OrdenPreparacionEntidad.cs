using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal class OrdenPreparacionEntidad
    {
        public string IdOrdenPreparacion { get; set; }
        public string IdCliente { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Transportista { get; set; }
        public DateTime FechaEstado { get; set; }
    }
}
