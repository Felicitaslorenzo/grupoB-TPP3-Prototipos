using grupoB_TPP3_Prototipos.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.ListarOrdenEntrega
{
    internal class ListarOrdenEntregaModel
    {

        public List<OrdenEntrega> OrdenesEntregadas = OrdenEntregaAlmacen.OrdenesEntrega
     .Select(oe => new OrdenEntrega
     {
         IdOrdenEntrega = oe.IdOrdenEntrega,
         FechaEmision = oe.FechaEmision,
         FechaEntrega = oe.FechaEntrega,
         // Estado = oe.Estado, 

         // Asocia las órdenes de preparación usando la lista de identificadores en oe.OrdenesPreparacion
         OrdenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
             .Where(op => oe.OrdenesPreparacion.Contains(op.IdOrdenPreparacion)) // Filtra las órdenes de preparación que coincidan con los IDs en OrdenesPreparacion de OrdenEntrega
             .Select(op => new OrdenPreparacion
             {
                 IdOrden = op.IdOrdenPreparacion,
                 IdCliente = op.IdCliente,
                 Transportista = op.IdTransportista,
                 FechaEstado = op.FechaEntrega // Asegúrate de que esta sea la fecha correcta
             })
             .ToList()
     })
     .ToList();

        public List<OrdenEntrega> ObtenerOrdenesEntrega()
        {
            return OrdenesEntregadas;
        }
    }
}
