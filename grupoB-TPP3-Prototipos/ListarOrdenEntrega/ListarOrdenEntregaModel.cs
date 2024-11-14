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

                // Filtra las OP basándose en la lista de IDs en oe.OrdenesPreparacion.
                OrdenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
                    .Where(op => oe.OrdenesPreparacion.Contains(op.IdOrdenPreparacion))
                    .Select(op => new OrdenPreparacion
                    {
                        IdOrden = op.IdOrdenPreparacion,
                        IdCliente = op.IdCliente,
                        FechaEstado = op.FechaEntrega,
                        Estado = op.Estado.ToString(),
                    })
                    .ToList(),

                Estado = ObtenerEstadoPrimeraOP(oe)
            })
            .ToList();

        private static string ObtenerEstadoPrimeraOP(OrdenEntregaEnt oeEnt)
        {
            // Obtener el estado de la primera orden de preparación asociada, si existe
            var primerEstadoOP = oeEnt.OrdenesPreparacion
                .Select(opId => OrdenPreparacionAlmacen.OrdenesPreparacion
                    .FirstOrDefault(op => op.IdOrdenPreparacion == opId)?.Estado.ToString())
                .FirstOrDefault();

            return primerEstadoOP ?? "Sin Estado";
        }

        public List<OrdenEntrega> ObtenerOrdenesEntrega()
        {
            return OrdenesEntregadas;
        }
    }
}
