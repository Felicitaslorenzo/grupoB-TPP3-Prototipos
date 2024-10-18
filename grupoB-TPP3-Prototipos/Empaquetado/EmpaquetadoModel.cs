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
            if (indiceActual < ordenes.Count)
            {
                ordenes.RemoveAt(indiceActual);

                // Actualizar el índice después de eliminar la orden actual
                if (indiceActual >= ordenes.Count)
                {
                    indiceActual--; // Ajusta el índice si se ha eliminado la última orden
                }
            }
        }

        // Mantiene el método ya existente
        public List<OrdenPreparacion> ObtenerOrdenesPreparacion()
        {
            return new List<OrdenPreparacion>
            {
                new OrdenPreparacion
                {
                    IdOrden = "OP001",
                    Producto = new List<Producto>
                    {
                        new Producto { DescripcionProducto = "Ropa", Cantidad = 30 },
                        new Producto { DescripcionProducto = "Mueble", Cantidad = 40 }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP002",
                    Producto = new List<Producto>
                    {
                        new Producto { DescripcionProducto = "Ladrillos", Cantidad = 50 },
                        new Producto { DescripcionProducto = "Cemento", Cantidad = 100 }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP008",
                    Producto = new List<Producto>
                    {
                        new Producto { DescripcionProducto = "Calzado", Cantidad = 100 },
                        new Producto { DescripcionProducto = "Accesorio", Cantidad = 150 }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP009",
                    Producto = new List<Producto>
                    {
                        new Producto { DescripcionProducto = "Accesorio", Cantidad = 200 },
                        new Producto { DescripcionProducto = "Dispositivo electrónico", Cantidad = 80 }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP010",
                    Producto = new List<Producto>
                    {
                        new Producto { DescripcionProducto = "Metales", Cantidad = 500 }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP011",
                    Producto = new List<Producto>
                    {
                        new Producto { DescripcionProducto = "Ropa", Cantidad = 50 },
                        new Producto { DescripcionProducto = "Mueble", Cantidad = 200 }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP015",
                    Producto = new List<Producto>
                    {
                        new Producto { DescripcionProducto = "Producto farmacéutico", Cantidad = 100 },
                        new Producto { DescripcionProducto = "Material sensible", Cantidad = 400 }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP018",
                    Producto = new List<Producto>
                    {
                        new Producto { DescripcionProducto = "Calzado", Cantidad = 800 },
                        new Producto { DescripcionProducto = "Accesorio", Cantidad = 2000 }
                    }
                }
            };
        }
    }
}
