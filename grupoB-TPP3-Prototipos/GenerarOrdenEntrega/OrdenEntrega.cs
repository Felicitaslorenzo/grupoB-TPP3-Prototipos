using grupoB_TPP3_Prototipos.GenerarOrdenEntrega;

namespace grupoB_TPP3_Prototipos.GenerarOrdenEntrega
{
    public class OrdenEntrega
    {
        public string IdOdenEntrega { get; set; }
        
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public DateTime FechaEmision { get; set; }

        //public List<OrdenPreparacion> OrdenPreparacion { get; set; } = new List<OrdenPreparacion>();

    }
}