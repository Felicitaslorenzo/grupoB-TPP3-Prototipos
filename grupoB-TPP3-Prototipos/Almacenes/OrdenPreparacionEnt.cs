using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal class OrdenPreparacionEnt
    {
        public string IdOrdenPreparacion { get; set; }
        public string IdCliente { get; set; }
        public string IdDeposito { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaEntrega { get; set; }
        public EstadoOrdenPrepEnum Estado { get; set; }
        public PrioridadEnum Prioridad { get; set; }
        public string IdTransportista { get; set; }
        public List<OrdenPreparacionDetalle> Detalle { get; set; } = new();
    }
}
