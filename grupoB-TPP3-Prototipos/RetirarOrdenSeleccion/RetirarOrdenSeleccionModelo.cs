using grupoB_TPP3_Prototipos.Almacenes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.RetirarOrdenSeleccion
{
    internal class RetirarOrdenSeleccionModelo
    {
        public List<OrdenSeleccion> OrdenesSeleccionadas
        {
            get
            {
                var listarOrdenesSeleccion = new List<OrdenSeleccion>();

                foreach (var ordenEntidad in OrdenSeleccionAlmacen.OrdenesSeleccion)
                {
                    if (ordenEntidad.Estado == EstadoOrdenSelEnum.Pendiente)
                    {
                        var ordenModelo = new OrdenSeleccion
                        {
                            IdOrdenSeleccion = ordenEntidad.IdOrdenSeleccion,
                            Estado = ordenEntidad.Estado,
                            FechaEstado = ordenEntidad.FechaEstado,
                            FechaEmision = ordenEntidad.FechaEmision,
                            OrdenesPreparacion = ordenEntidad.OrdenesPreparacion
                        };
                        foreach (var idOrdenPreparacion in ordenEntidad.OrdenesPreparacion)
                        {
                            var ordenPrep = OrdenPreparacionAlmacen.ObtenerOrdenPreparacion(idOrdenPreparacion);
                            if (ordenPrep != null)
                            {
                                ordenModelo.OrdenesPreparacion.Add(ordenPrep);
                            }
                        }
                        listarOrdenesSeleccion.Add(ordenModelo);
                        /*
        ORDEN SELECCION:
            -Orden prep 1
                - Producto A...
                -Producto B
            - Orden prep 2
                - Producto A...
                -Producto B...
            -...n

        El TOTAL es de 120 remeras y 50 zapatillas. -- -

        Para cada producto ...
            Para cada ubicacion del producto....Retiro lo que me falta del producto o la cantidad que haya en la ubicacion y agrego un item a la lista de resultado.

            Sigo recorriendo ubicaciones hasta que haya retirado todo lo necesario.



        Devuelvo la lista de ubicaciones y cantidades que utilicé.
        UBICACION A => SACA 100 Remeras
        UBICACION B => SACA 20 Remeras
        UBICACION C => SACA 50 Zapatillas*/
                    }
                }
                return listarOrdenesSeleccion;
            }
        }
        public List<InventarioMercaderiaEnt> CargarProductosYUbicaciones(List<string> ordenesPreparacionIds)
        {
            var productosAgrupados = new Dictionary<string, int>();
            foreach (var opId in ordenesPreparacionIds)
            {
                var op = OrdenPreparacionAlmacen.ObtenerOrdenPreparacion(opId);
                if (op != null)
                {
                    foreach (var producto in op.Productos)
                    {
                        if (productosAgrupados.ContainsKey(producto.SKUProducto))
                        {
                            productosAgrupados[producto.SKUProducto] += producto.Cantidad;
                        }
                        else
                        {
                            productosAgrupados[producto.SKUProducto] = producto.Cantidad;
                        }
                    }
                }
            }
            var resultadoUbicaciones = new List<InventarioMercaderiaEnt>();
            foreach (var kvp in productosAgrupados)
            {
                string sku = kvp.Key;
                int cantidadTotal = kvp.Value;

                var ubicaciones = ObtenerUbicacionesProducto(sku);

                int cantidadRestante = cantidadTotal;

                foreach (var ubicacion in ubicaciones)
                {
                    if (cantidadRestante <= 0) break;

                    int cantidadEnUbicacion = Math.Min(ubicacion.Cantidad, cantidadRestante);
                    cantidadRestante -= cantidadEnUbicacion;

                    resultadoUbicaciones.Add(new InventarioMercaderiaEnt
                    {
                        IdDeposito = ubicacion.IdDeposito,
                        Ubicacion = ubicacion.Ubicacion,
                        Cantidad = cantidadEnUbicacion
                    });
                }
            }

            return resultadoUbicaciones;
        }
        private List<InventarioMercaderiaEnt> ObtenerUbicacionesProducto(string skuProducto)
        {
            // Simular un método que devuelve las ubicaciones del inventario para un producto dado
            return InventarioMercaderiaAlmacen.ObtenerInventarioPorSKU(skuProducto);
        }
        internal void Confirmar(string? idSeleccionado)
        {
            //TODO: impactar en inventario con los valores ya calculados.
        }
    }
}
