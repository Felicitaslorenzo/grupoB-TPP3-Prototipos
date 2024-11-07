using grupoB_TPP3_Prototipos.Almacenes;
using grupoB_TPP3_Prototipos.GenerarOrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.ListarOrdenPreparacion
{
    internal class ListarOrdenPreparacionModel
    {
        public List<OrdenPreparacion> ObtenerOrdenesPreparacion()
        {
            {
                var listarOrdenes = new List<OrdenPreparacion>();

                foreach (var ordenEntidad in OrdenPreparacionAlmacen.OrdenesPreparacion)
                {
                    var ordenModelo = new OrdenPreparacion
                    {
                        IdCliente = ordenEntidad.IdCliente,
                        IdOrden = ordenEntidad.IdOrdenPreparacion,
                        Prioridad = ordenEntidad.Prioridad.ToString(),
                        Estado = ordenEntidad.Estado.ToString(),
                        FechaEmision = ordenEntidad.FechaEmision,
                        //FechaEntrega = ordenEntidad.FechaEntrega.ToString(), // No tenemos fecha de entrega en la clase.
                        Producto = ordenEntidad.Productos.Select(p => new Producto
                        {
                            DescripcionProducto = p.DescripcionProducto,
                            Cantidad = p.Cantidad
                        }).ToList()
                    };

                    listarOrdenes.Add(ordenModelo);
                }

                return listarOrdenes;
            }
        }
        /*public List<OrdenPreparacionEnt> FiltrarOrdenes(DateTime fechaEmisionDesde, DateTime fechaEmisionHasta, string prioridad, string idCliente)
        {
            return ObtenerOrdenesPreparacion().Where(orden =>
                (fechaEmisionDesde == default(DateTime) || orden.FechaEmision >= fechaEmisionDesde) &&
                (fechaEmisionHasta == default(DateTime) || orden.FechaEmision <= fechaEmisionHasta) &&
                (string.IsNullOrEmpty(prioridad) || orden.Prioridad == prioridad) &&
                (string.IsNullOrEmpty(idCliente) || orden.IdCliente == idCliente)
            )
            .Select(orden => new OrdenPreparacionEnt
            {
                IdCliente = orden.IdCliente,
               // IdOrdenPreparacion = orden.IdOrdenPreparacion,
                Prioridad = Enum.Parse<PrioridadEnum>(orden.Prioridad),
                Estado = Enum.Parse<EstadoOrdenPrepEnum>(orden.Estado),
                FechaEmision = orden.FechaEmision,
                //FechaEntrega = string.IsNullOrEmpty(orden.FechaEntrega) ? null : DateTime.Parse(orden.FechaEntrega),
                //Detalle = orden.Detalle
            })
            .ToList();
        }*/
    }
}
