using grupoB_TPP3_Prototipos.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.ConsultaStock
{
    internal class ConsultaStockModel
    {
        internal List<Producto> BuscarProducto(Producto producto)
        {
            var productos = ProductoAlmacen.Productos
             .Where(p => string.IsNullOrEmpty(producto.SKUProducto) || p.SKUProducto == producto.SKUProducto) // Filtro por SKUProducto si se pasa
             .Select(p => new Producto
             {
                 SKUProducto = p.SKUProducto,
                 DescripcionProducto = p.DescripcionProducto,
                 IdCliente = p.IdCliente,
                 TotalCantidad = p.Inventario.Sum(i => i.Cantidad), // Sumar la cantidad dentro del inventario
                 TotalComprometido = ObtenerCantidadDisponible(p.SKUProducto), // Cantidad comprometida
                 Inventario = p.Inventario.Select(inv => new Inventario
                 {
                     IdDeposito = inv.IdDeposito,
                     Ubicacion = inv.Ubicacion,
                     Cantidad = inv.Cantidad
                 }).ToList() // Asegúrate de que Inventario sea una lista
             }).ToList();

            return productos;
        }

        public int ObtenerCantidadDisponible(string skuProducto)
        {
            // Busca en InventarioMercaderia la cantidad disponible para el SKUProducto específico

            var depositoActual = DepositoAlmacen.DepositoActual.IdDeposito;
            var producto = ProductoAlmacen.Productos.First(p => p.SKUProducto == skuProducto);

            int cantidadDisponible = producto.Inventario.Where(d => d.IdDeposito == depositoActual).Sum(d => d.Cantidad);

            int cantidadComprometida = OrdenPreparacionAlmacen.OrdenesPreparacion
                   .Where(o => o.IdDeposito == depositoActual &&
                               (o.Estado == EstadoOrdenPrepEnum.Pendiente ||
                                o.Estado == EstadoOrdenPrepEnum.EnSeleccion)) //   Comprometemos las canitdades en estado 0 y 1 ya que en estado 2 se restan de inventario
                   .SelectMany(o => o.Detalle)
                   .Where(d => d.SKUProducto == skuProducto)
                   .Sum(o => o.Cantidad);

            int cantidadRestante = cantidadDisponible - cantidadComprometida;
            return cantidadRestante;
        }
    }
}
