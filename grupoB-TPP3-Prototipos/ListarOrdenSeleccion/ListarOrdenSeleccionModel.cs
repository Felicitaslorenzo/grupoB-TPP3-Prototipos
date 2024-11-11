using grupoB_TPP3_Prototipos.Almacenes;
using grupoB_TPP3_Prototipos.DespacharOrdenEntrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.ListarOrdenSeleccion
{
    internal class ListarOrdenSeleccionModel
    {
        public List<OrdenSeleccion> OrdenesSeleccionadas = OrdenSeleccionAlmacen.OrdenesSeleccion.Select(os => new OrdenSeleccion
        {
            IdOrdenSeleccion = os.IdOrdenSeleccion,
            FechaEmision = os.FechaEmision,
            FechaEstado = os.FechaEstado,
            Estado = os.Estado.ToString(),

            // Obtiene las órdenes de preparación asociadas para cada orden de selección.
            OrdenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
         .Where(op => os.OrdenesPreparacion.Contains(op.IdOrdenPreparacion))  // Usar Contains para la comparación
         .Select(op => new OrdenPreparacion
         {
             IdOrden = op.IdOrdenPreparacion,
             IdCliente = op.IdCliente,
             Transportista = op.IdTransportista,
             //
             // Obtiene la lista de productos de cada orden de preparación.
             Productos = op.Detalle.Select(det => new Producto
             {
                 DescripcionProducto = ProductoAlmacen.Productos
                     .First(p => p.SKUProducto == det.SKUProducto).DescripcionProducto,
                 Cantidad = det.Cantidad
             }).ToList()
         }).ToList()
        }).ToList();

    }
}
