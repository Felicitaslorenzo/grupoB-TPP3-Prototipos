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

        // Aquí creas la lista de 'OrdenesPreparacion' de forma correcta.
        OrdenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
            .Where(op => oe.OrdenesPreparacion.Contains(op.IdOrdenPreparacion))
            .Select(op => new OrdenPreparacion
            {
                IdOrden = op.IdOrdenPreparacion,   // Asegúrate de que este mapeo es correcto.
                IdCliente = op.IdCliente,
                FechaEstado = op.FechaEntrega,
                Estado = op.Estado.ToString(),
            })
            .ToList(), // Convertimos a lista
    })
    .ToList(); // Convertimos la consulta principal a lista


        public List<OrdenEntrega> ObtenerOrdenesEntrega()
        {
            return OrdenesEntregadas;
        }
    }
}
