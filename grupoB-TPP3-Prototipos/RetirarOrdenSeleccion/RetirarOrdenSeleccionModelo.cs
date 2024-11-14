using grupoB_TPP3_Prototipos.Almacenes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.RetirarOrdenSeleccion
{
    internal class RetirarOrdenSeleccionModelo
    {
        private List<OrdenSeleccion> ordenesSeleccion;

        public RetirarOrdenSeleccionModelo()
        {
            CargarOrdenes();
        }

        private void CargarOrdenes()
        {
            var depositoActual = DepositoAlmacen.DepositoActual.IdDeposito;
            ordenesSeleccion = OrdenSeleccionAlmacen.OrdenesSeleccion
                .Where(o => OrdenPreparacionAlmacen.OrdenesPreparacion.First(ope => ope.IdOrdenPreparacion == o.OrdenesPreparacion.First()).IdDeposito == depositoActual)
                .Select(ent => new OrdenSeleccion
                {
                    IdOrdenSeleccion = ent.IdOrdenSeleccion,
                    Estado = ent.Estado,
                    // Asigna las demás propiedades de OrdenSeleccion aquí
                    // Ejemplo: Producto = ent.Producto.Select(p => new Producto { /* Copia propiedades */ }).ToList()
                })
                .ToList();
        }


        public List<OrdenSeleccion> ObtenerOrdenesPendientes()
        {
            var idDeposito = DepositoAlmacen.DepositoActual.IdDeposito;
            return ordenesSeleccion
                .Where(orden => orden.Estado == EstadoOrdenSelEnum.Pendiente)
                .ToList();
        }

        public List<Producto> ObtenerProductosPorOrden(string idOrdenSeleccion)
        {
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
                UBICACION C => SACA 50 Zapatillas
            */

            var ordenSeleccionada = OrdenSeleccionAlmacen.OrdenesSeleccion
                .FirstOrDefault(o => o.IdOrdenSeleccion == idOrdenSeleccion);

            if (ordenSeleccionada == null)
            {
                return new List<Producto>();
            }

            var productos = new List<Producto>();

            var ordenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(op => ordenSeleccionada.OrdenesPreparacion.Contains(op.IdOrdenPreparacion))
                .ToList();

            Dictionary<string, int> totalRequeridoPorProducto = new();
            foreach (var ordenPreparacion in ordenesPreparacion)
            {
                foreach (var detalle in ordenPreparacion.Detalle)
                {
                    if (totalRequeridoPorProducto.ContainsKey(detalle.SKUProducto))
                    {
                        // Acumular la cantidad requerida para el producto específico
                        totalRequeridoPorProducto[detalle.SKUProducto] += detalle.Cantidad;
                    }
                    else
                    {
                        // Si no existe en el diccionario, agregar el SKU y la cantidad inicial
                        totalRequeridoPorProducto.Add(detalle.SKUProducto, detalle.Cantidad);
                    }
                }
            }

            foreach (var productoSku in totalRequeridoPorProducto.Keys)
            {
                var productoEntidad = ProductoAlmacen.Productos
                    .Where(p => p.SKUProducto == productoSku)
                    .First();

                foreach (var inventario in productoEntidad.Inventario)
                {
                    if (totalRequeridoPorProducto[productoSku] <= 0) break;

                    int cantidadAUtilizar = Math.Min(inventario.Cantidad, totalRequeridoPorProducto[productoSku]);
                    totalRequeridoPorProducto[productoSku] -= cantidadAUtilizar;

                    var producto = new Producto
                    {
                        DescripcionProducto = productoEntidad.DescripcionProducto,
                        Ubicacion = inventario.Ubicacion,
                        Cantidad = cantidadAUtilizar
                        // Cantidad = inventario.Cantidad
                    };

                    productos.Add(producto);
                }
            }

            return productos;
        }

        public void ConfirmarOrden(string idOrdenSeleccion)
        {
            // Busca la orden de selección; lanza excepción si no se encuentra.
            var ordenEntidad = OrdenSeleccionAlmacen.OrdenesSeleccion.FirstOrDefault(o => o.IdOrdenSeleccion == idOrdenSeleccion);
            if (ordenEntidad == null)
            {
                throw new InvalidOperationException($"No se encontró la orden de selección con ID {idOrdenSeleccion}.");
            }

            ordenEntidad.Estado = EstadoOrdenSelEnum.Preparada;

            // Actualiza el estado de cada orden de preparación asociada
            foreach (var idOrdenPrep in ordenEntidad.OrdenesPreparacion)
            {
                var ordenPrepEntidad = OrdenPreparacionAlmacen.OrdenesPreparacion.FirstOrDefault(op => op.IdOrdenPreparacion == idOrdenPrep);
                if (ordenPrepEntidad == null)
                {
                    throw new InvalidOperationException($"No se encontró la orden de preparación con ID {idOrdenPrep}.");
                }
                ordenPrepEntidad.Estado = EstadoOrdenPrepEnum.Seleccionada;
            }

            // Baja de inventario utilizando el SKUProducto y la cantidad
            var depositoActual = DepositoAlmacen.DepositoActual.IdDeposito;

            foreach (var idOrdenPrep in ordenEntidad.OrdenesPreparacion)
            {
                var ordenPrepEntidad = OrdenPreparacionAlmacen.OrdenesPreparacion.FirstOrDefault(op => op.IdOrdenPreparacion == idOrdenPrep);
                if (ordenPrepEntidad == null) continue;

                foreach (var detalle in ordenPrepEntidad.Detalle)
                {
                    // Obtiene el producto del almacén por SKUProducto del detalle de la orden de preparación
                    var productoEntidad = ProductoAlmacen.Productos.FirstOrDefault(p => p.SKUProducto == detalle.SKUProducto);
                    if (productoEntidad == null)
                    {
                        throw new InvalidOperationException($"No se encontró el producto con SKU {detalle.SKUProducto} en el inventario general.");
                    }

                    // Baja de inventario en cada ubicación del depósito hasta cubrir la cantidad requerida
                    var cantidadPendiente = detalle.Cantidad;
                    foreach (var inventario in productoEntidad.Inventario.Where(i => i.IdDeposito == depositoActual))
                    {
                        if (cantidadPendiente <= 0) break;

                        if (inventario.Cantidad >= cantidadPendiente)
                        {
                            inventario.Cantidad -= cantidadPendiente;
                            cantidadPendiente = 0;
                        }
                        else
                        {
                            cantidadPendiente -= inventario.Cantidad;
                            inventario.Cantidad = 0;
                        }
                    }

                    // Verifica si queda cantidad pendiente después de recorrer el inventario
                    if (cantidadPendiente > 0)
                    {
                        throw new InvalidOperationException($"Inventario insuficiente para el producto con SKU {detalle.SKUProducto} en el depósito {depositoActual}.");
                    }
                }
            }

            // Graba los cambios en cada almacén
            OrdenSeleccionAlmacen.Grabar();
            OrdenPreparacionAlmacen.Grabar();
            ProductoAlmacen.Grabar();
        }


        /* public void ConfirmarOrden(string idOrdenSeleccion)
        {
            var ordenEntidad = OrdenSeleccionAlmacen.OrdenesSeleccion.First(o => o.IdOrdenSeleccion == idOrdenSeleccion);
            ordenEntidad.Estado = EstadoOrdenSelEnum.Preparada;

            foreach (var ordenPrep in ordenEntidad.OrdenesPreparacion)
            {
                var ordenPrepEntidad = OrdenPreparacionAlmacen.OrdenesPreparacion.First(o => o.IdOrdenPreparacion == ordenPrep);
                ordenPrepEntidad.Estado = EstadoOrdenPrepEnum.Seleccionada;
            }

            //TO DO: baja inventario.
            List<Producto> productosConfirmados = ObtenerProductosPorOrden(idOrdenSeleccion);
            var depositoActual = DepositoAlmacen.DepositoActual.IdDeposito;

            foreach (var producto in productosConfirmados)
            {
                var productoEntidad = ProductoAlmacen.Productos.First(p => p.SKUProducto == producto.SKUProducto);
                var inventarioMercaderia = productoEntidad.Inventario.First(i => i.Ubicacion == producto.Ubicacion && i.IdDeposito == depositoActual);
                inventarioMercaderia.Cantidad -= producto.Cantidad;
            }

            OrdenSeleccionAlmacen.Grabar();
            OrdenPreparacionAlmacen.Grabar();
            ProductoAlmacen.Grabar();
        } */

        /*public List<OrdenSeleccion> ObtenerOrdenesSeleccionadas() //Esto no se está usando, para qué está?
        {
            var listarOrden = new List<OrdenSeleccion>();

            // Filtramos las órdenes con estado Pendiente
            foreach (var ordenEntidad in OrdenSeleccionAlmacen.OrdenesSeleccion)
            {
                if (ordenEntidad.Estado == EstadoOrdenSelEnum.Pendiente)
                {
                    var ordenSeleccionada = new OrdenSeleccion
                    {
                        IdOrdenSeleccion = ordenEntidad.IdOrdenSeleccion,
                        Estado = ordenEntidad.Estado,
                        Producto = new List<Producto>()
                    };

                    var ordenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
                        .Where(op => ordenEntidad.OrdenesPreparacion.Contains(op.IdOrdenPreparacion))
                        .ToList();

                    foreach (var ordenPreparacion in ordenesPreparacion)
                    {
                        foreach (var detalle in ordenPreparacion.Detalle)
                        {
                            // Busca directamente en ProductoAlmacen por el SKUProducto en detalle
                            var productosCoincidentes = grupoB_TPP3_Prototipos.Almacenes.ProductoAlmacen.Productos
                                .Where(p => p.SKUProducto == detalle.SKUProducto)
                                .ToList();

                            foreach (var productoAlmacen in productosCoincidentes)
                            {
                                // Una vez encontrado el producto, accede a su inventario para ubicación y cantidad
                                foreach (var inventario in productoAlmacen.Inventario)
                                {
                                    var producto = new Producto
                                    {
                                        DescripcionProducto = productoAlmacen.DescripcionProducto,
                                        Ubicacion = inventario.Ubicacion,  // Ubicación del inventario
                                        Cantidad = inventario.Cantidad      // Cantidad del inventario
                                    };

                                    // Agrega el producto a la lista de productos de la orden seleccionada
                                    ordenSeleccionada.Producto.Add(producto);
                                }
                            }
                        }
                    }
                    listarOrden.Add(ordenSeleccionada);
                }
            }

            return listarOrden;
        }*/


        /*
         * 
         *
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
        UBICACION C => SACA 50 Zapatillas
                    }
                }
                return listarOrdenesSeleccion;
            }
        }
        public List<InventarioMercaderiaEnt> CargarProductosYUbicaciones(List<string> ordenesPreparacionIds)
        {
           /* var productosAgrupados = new Dictionary<string, int>();
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
        }*/
    }
}
