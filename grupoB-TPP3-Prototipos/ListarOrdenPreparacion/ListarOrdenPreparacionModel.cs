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
                        Nombre = ClienteAlmacen.Clientes.First(c => c.IdCliente == ordenEntidad.IdCliente).NombreCliente,
                        Prioridad = ordenEntidad.Prioridad.ToString(),
                        Estado = ordenEntidad.Estado.ToString(),
                        FechaEmision = ordenEntidad.FechaEmision,
                        FechaEstado = ordenEntidad.FechaEntrega,
                        Producto = ordenEntidad.Detalle.Select(detalle => new Producto
                        {
                            DescripcionProducto = ProductoAlmacen.Productos.First(pr => pr.SKUProducto == detalle.SKUProducto).DescripcionProducto,
                            Cantidad = detalle.Cantidad
                        }).ToList()
                    };


                    var producto1 = ProductoAlmacen.Productos.Where(p => p.IdCliente == "1").Select(p => new Producto
                    {

                    }).ToList();

                    /*
                    ordenModelo.Producto = new List<Producto>();

                    foreach(var detalleOrden in ordenEntidad.Detalle)
                    {                        
                        var productoEntidad = ProductoAlmacen.Productos.First(p => p.SKUProducto == detalleOrden.SKUProducto);

                        var productoModelo = new Producto();
                        productoModelo.IDProducto = productoEntidad.SKUProducto;
                        productoModelo.DescripcionProducto = productoEntidad.DescripcionProducto;
                        productoModelo.Cantidad = detalleOrden.Cantidad;

                        ordenModelo.Producto.Add(productoModelo);
                    }*/

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
