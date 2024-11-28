using grupoB_TPP3_Prototipos.Almacenes;
using grupoB_TPP3_Prototipos.DespacharOrdenEntrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Empaquetado
{
    internal class EmpaquetadoModel
    {
        private List<OrdenPreparacion> ordenes;
        private int indiceActual = 0;

        public EmpaquetadoModel()
        {
            ordenes = ObtenerOrdenesPreparacion();
            indiceActual = 0; // Inicia con la primera orden
        }

        public OrdenPreparacion ObtenerOrdenActual()
        {
            if (indiceActual >= 0 && indiceActual < ordenes.Count)
            {
                return ordenes[indiceActual];
            }
            else
            {
                indiceActual = -1; // O a un valor que indique que no hay órdenes
                return null; // No hay más órdenes
            }
        }

        public void EliminarOrdenActual()
        {
            // Verificar si el índice actual es válido
            if (indiceActual < ordenes.Count)
            {
                // Obtener la orden a eliminar
                var ordenAEliminar = ordenes[indiceActual];

                // Cambiar el estado de la orden en OrdenPreparacionAlmacen a 3 (Empaquetada)
                var ordenEnAlmacen = OrdenPreparacionAlmacen.OrdenesPreparacion
                    .FirstOrDefault(o => o.IdOrdenPreparacion == ordenAEliminar.IdOrden);

                if (ordenEnAlmacen != null)
                {
                    // Convertir el valor entero 3 a su correspondiente valor de enum
                    ordenEnAlmacen.Estado = (EstadoOrdenPrepEnum)3; // Cambiar a Eliminado
                }

                // OrdenPreparacionAlmacen.Grabar(); // ELEGIR SI BORRAR

                // Eliminar la orden de la lista local 'ordenes'
                ordenes.RemoveAt(indiceActual);

                // Actualizar el índice después de eliminar la orden actual
                if (indiceActual >= ordenes.Count)
                {
                    indiceActual--; // Ajusta el índice si se ha eliminado la última orden
                }
            }
        }
        public string ObtenerIdOrdenActual()
        {
            return (indiceActual >= 0 && indiceActual < ordenes.Count) ? ordenes[indiceActual].IdOrden : null;
        }
        // Mantiene el método ya existente
        public List<OrdenPreparacion> ObtenerOrdenesPreparacion()
        {
            // Lista que contendrá las ordenes de preparación
            var listarOrdenesEmpaquetado = new List<OrdenPreparacion>();

            // Fecha y hora actuales
            // DateTime fechaHoy = DateTime.Now;

            var depositoActual = DepositoAlmacen.DepositoActual.IdDeposito;

            // Recorrer todas las OrdenesPreparacion
            foreach (var ordenEntidad in OrdenPreparacionAlmacen.OrdenesPreparacion)
            {
                if (ordenEntidad.IdDeposito != depositoActual)
                {
                    continue;
                }

                // Filtrar las órdenes con estado 2 (Suponiendo que 2 es el valor de "Seleccionada") y con FechaEntrega de hoy
                if ((int)ordenEntidad.Estado == 2) 
                {
                    var ordenModelo = new OrdenPreparacion
                    {
                        IdOrden = ordenEntidad.IdOrdenPreparacion,
                        // Crear la lista de productos
                        Producto = new List<Producto>()
                    };

                    // Recorrer los detalles de la orden
                    foreach (var detalle in ordenEntidad.Detalle)
                    {
                        // Agregar los productos a la lista
                        ordenModelo.Producto.Add(new Producto
                        {
                            Cantidad = detalle.Cantidad,
                            DescripcionProducto = ProductoAlmacen.Productos.First(pr => pr.SKUProducto == detalle.SKUProducto).DescripcionProducto,
                        });
                    }

                    // Agregar el modelo de la orden de preparación a la lista
                    listarOrdenesEmpaquetado.Add(ordenModelo);
                }
            }

            // Devolver la lista de ordenes de preparación empaquetadas
            return listarOrdenesEmpaquetado;
        }


    }
}

