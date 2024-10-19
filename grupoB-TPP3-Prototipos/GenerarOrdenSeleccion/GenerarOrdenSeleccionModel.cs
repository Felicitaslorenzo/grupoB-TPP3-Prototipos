using grupoB_TPP3_Prototipos.GenerarOrdenSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Generar_orden_de_Selección
{
    internal class GenerarOrdenSeleccionModel
    {
        public List<OrdenPreparacion> ObtenerOrdenesPreparacion()
        {
            var ordenesPreparacion = new List<OrdenPreparacion>
            {
                new OrdenPreparacion
                {
                    IdOrden = "OP001",
                    Nombre = "Porter SA",
                    FechaEstado = DateTime.Parse("2024-09-30"),
                    FechaEmision = DateTime.Parse("2024-10-03"),
                    Producto = new List<Producto>
                    {
                        new Producto
                        {
                            DescripcionProducto = "Ropa",
                            Cantidad = 30,
                        
                        },
                        new Producto
                        {
                            DescripcionProducto = "Mueble",
                            Cantidad = 40,
                           
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP002",
                    Nombre = "Ferreteria SRL",
                    FechaEstado = DateTime.Parse("2024-09-25"),
                    FechaEmision = DateTime.Parse("2024-09-29"),
                    Producto = new List<Producto>
                    {
                        new Producto 
                        { 
                            DescripcionProducto = "Ladrillos", 
                            Cantidad = 50 
                        },
                        new Producto 
                        { 
                            DescripcionProducto = "Cemento", 
                            Cantidad = 100 
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP003",
                    Nombre = "Porter SA",
                    FechaEstado = DateTime.Parse("2024-10-01"),
                    FechaEmision = DateTime.Parse("2024-10-05"),
                    Producto = new List<Producto>
                    {
                        new Producto
                        {
                            DescripcionProducto = "Electrodoméstico",
                            Cantidad = 15
                        },
                        new Producto 
                        {
                            DescripcionProducto = "Artículo de decoración", 
                            Cantidad = 50
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP004",
                    Nombre = "Techno Corp",
                    FechaEstado = DateTime.Parse("2024-09-21"),
                    FechaEmision = DateTime.Parse("2024-09-25"),
                    Producto = new List<Producto>
                    {
                        new Producto
                        {
                            DescripcionProducto = "Producto farmacéutico", 
                            Cantidad = 100
                        },
                        new Producto 
                        {
                            DescripcionProducto = "Inventario de lujo", 
                            Cantidad = 20
                        },
                        new Producto 
                        { 
                            DescripcionProducto = "Material sensible", 
                            Cantidad = 10 
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP005",
                    Nombre = "Construcciones Beta",
                    FechaEstado = DateTime.Parse("2024-09-24"),
                    FechaEmision = DateTime.Parse("2024-09-28"),
                    Producto = new List<Producto>
                    {
                        new Producto 
                        { 
                            DescripcionProducto = "Artículo de decoración", 
                            Cantidad = 60 
                        },
                        new Producto 
                        { 
                            DescripcionProducto = "Producto farmacéutico", 
                            Cantidad = 70
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP006",
                    Nombre = "Distribuciones Alfa",
                    FechaEstado = DateTime.Parse("2024-09-19"),
                    FechaEmision = DateTime.Parse("2024-09-23"),
                    Producto = new List<Producto>
                    {
                        new Producto 
                        { 
                            DescripcionProducto = "Artículo de decoración", 
                            Cantidad = 40
                        },
                        new Producto 
                        { 
                            DescripcionProducto = "Calzado", 
                            Cantidad = 120 
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP007",
                    Nombre = "Electro SA",
                    FechaEstado = DateTime.Parse("2024-09-26"),
                    FechaEmision = DateTime.Parse("2024-09-30"),
                    Producto = new List<Producto>
                    {
                        new Producto 
                        {
                            DescripcionProducto = "Máquinas", 
                            Cantidad = 5 
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP008",
                    Nombre = "Alimentos Granjeros",
                    FechaEstado = DateTime.Parse("2024-09-22"),
                    FechaEmision = DateTime.Parse("2024-09-26"),
                    Producto = new List<Producto>
                    {
                        new Producto 
                        { 
                            DescripcionProducto = "Calzado", 
                            Cantidad = 100 
                        },
                        new Producto 
                        { 
                            DescripcionProducto = "Accesorio",
                            Cantidad = 150
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP009",
                    Nombre = "Distribuciones Alfa",
                    FechaEstado = DateTime.Parse("2024-09-23"),
                    FechaEmision = DateTime.Parse("2024-09-27"),
                    Producto = new List<Producto>
                    {
                        new Producto 
                        { 
                            DescripcionProducto = "Accesorio", 
                            Cantidad = 200 
                        },
                        new Producto 
                        { 
                            DescripcionProducto = "Dispositivo electrónico", 
                            Cantidad = 80 
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP010",
                    Nombre = "Construcciones Beta",
                    FechaEstado = DateTime.Parse("2024-09-27"),
                    FechaEmision = DateTime.Parse("2024-09-30"),
                    Producto = new List<Producto>
                    {
                        new Producto 
                        { 
                            DescripcionProducto = "Metales", 
                            Cantidad = 500
                        }
                    }
                }
            };
            return ordenesPreparacion;
        }
        public List<Cliente> ObtenerClientes()
        {
            return new List<Cliente>
            {
                new Cliente { IdCliente = "CL001", Transportistas = new List<string> {"TR001", "TR002", "TR003", "CL001"}},
                new Cliente { IdCliente = "CL002", Transportistas = new List<string> {"TR004", "TR005", "CL002"}},
                new Cliente { IdCliente = "CL003", Transportistas = new List<string> {"TR006", "TR007", "CL003"}},
                new Cliente { IdCliente = "CL004", Transportistas = new List<string> {"TR008", "TR009", "TR010", "TR011", "CL004"}},
                new Cliente { IdCliente = "CL005", Transportistas = new List<string> {"TR012", "TR013", "CL005"}},
                new Cliente { IdCliente = "CL006", Transportistas = new List<string> {"TR014", "TR015", "CL006"}},
                new Cliente { IdCliente = "CL007", Transportistas = new List<string> {"TR016", "TR017", "CL007"}},
                new Cliente { IdCliente = "CL008", Transportistas = new List<string> {"TR018", "TR019", "CL008"}},
                new Cliente { IdCliente = "CL009", Transportistas = new List<string> {"TR020", "TR021", "CL009"}},
                new Cliente { IdCliente = "CL010", Transportistas = new List<string> {"TR022", "TR023", "CL010"}},
            };
        } 

        public List<OrdenPreparacion> FiltrarOrdenes(List<OrdenPreparacion> ordenesPreparacion, string idOrden, DateTime? fechaDesde, DateTime? fechaHasta, string prioridad, string idCliente)
        {
            var ordenesFiltradas = ordenesPreparacion.AsQueryable();

            if (!string.IsNullOrEmpty(idOrden))
            {
                ordenesFiltradas = ordenesFiltradas.Where(o => o.IdOrden == idOrden);
            }

            if (fechaDesde.HasValue)
            {
                ordenesFiltradas = ordenesFiltradas.Where(o => o.FechaEmision >= fechaDesde.Value);
            }

            if (fechaHasta.HasValue)
            {
                ordenesFiltradas = ordenesFiltradas.Where(o => o.FechaEmision <= fechaHasta.Value);
            }

            /*if (!string.IsNullOrEmpty(prioridad))
            {
                ordenesFiltradas = ordenesFiltradas.Where(o => o.Prioridad == prioridad);
            }
            
            if (!string.IsNullOrEmpty(idCliente))
            {
                ordenesFiltradas = ordenesFiltradas.Where(o => o.IdCliente == idCliente);
            }*/

            return ordenesFiltradas.ToList();
        }

        private int numeroOrdenSeleccion = 1;

        // Método para obtener el siguiente número de orden
        public string GenerarNuevaOrden()
        {
            string nuevaOrden = $"OS-{numeroOrdenSeleccion:D3}"; // Formato de 3 dígitos
            numeroOrdenSeleccion++; // Incrementar el número de orden
            return nuevaOrden;
        }
    }
}