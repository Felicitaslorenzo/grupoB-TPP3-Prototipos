using grupoB_TPP3_Prototipos.GenerarOrdenEntrega;

namespace grupoB_TPP3_Prototipos.GenerarOrdenEntrega
{
    public class OrdenEntrega
    {
        public string IdOdenEntrega { get; set; }
        
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public DateTime FechaEmision { get; set; }

        // Agregar una lista para almacenar las órdenes de preparación
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }

        // Constructor para inicializar la lista de órdenes de preparación
        public OrdenEntrega()
        {
            OrdenesPreparacion = new List<OrdenPreparacion>();
        }
    }
}