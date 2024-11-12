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

        Estado = ObtenerEstadoPrimeraOP(oe)
    })
    .ToList(); // Convertimos la consulta principal a lista

        private static string ObtenerEstadoPrimeraOP(OrdenEntregaEnt oeEnt)
        {
            // Obtener el estado de la primera orden de preparación asociada, si existe
            var primerEstadoOP = oeEnt.OrdenesPreparacion
                .Select(opId => OrdenPreparacionAlmacen.OrdenesPreparacion
                    .FirstOrDefault(op => op.IdOrdenPreparacion == opId)?.Estado.ToString())
                .FirstOrDefault();

            // Retornar el estado o "Sin Estado" si no hay órdenes de preparación
            return primerEstadoOP ?? "Sin Estado";
        }

        public List<OrdenEntrega> ObtenerOrdenesEntrega()
        {
            return OrdenesEntregadas;
        }
    }
}
