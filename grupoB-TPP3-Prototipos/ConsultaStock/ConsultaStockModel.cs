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
                 Inventario = p.Inventario.Select(inv => new Inventario
                 {
                     IdDeposito = inv.IdDeposito,
                     Ubicacion = inv.Ubicacion,
                     Cantidad = inv.Cantidad
                 }).ToList() // Asegúrate de que Inventario sea una lista
             }).ToList();

            return productos;
        }
    }
}
