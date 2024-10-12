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
        public List<OrdenSeleccion> OrdenesSeleccionadas = new List<OrdenSeleccion>
        {
            new OrdenSeleccion { IdOrdenSeleccion = "OS001", FechaEmision = DateTime.Parse("2024-01-15"), FechaEstado = DateTime.Parse("2024-01-18"), Estado = "Seleccionada",
                OrdenesPreparacion = new List <OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP001",
                        IdCliente = "CL001",
                        Transportista = "TR001",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Ropa", Cantidad = 30 },
                            new Producto { DescripcionProducto = "Mueble", Cantidad = 40 }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP002",
                        IdCliente = "CL002",
                        Transportista = "TR005",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Ladrillos", Cantidad = 50, },
                            new Producto { DescripcionProducto = "Cemento", Cantidad = 100, }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS002", FechaEmision = DateTime.Parse("2024-01-20"), FechaEstado = DateTime.Parse("2024-01-22"), Estado = "Desapchada",
                OrdenesPreparacion = new List <OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP003",
                        IdCliente = "CL001",
                        Transportista = "TR002",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Electrodoméstico", Cantidad = 15 },
                            new Producto { DescripcionProducto = "Artículo de decoración", Cantidad = 50 }
                        }
                    }
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS003", FechaEmision = DateTime.Parse("2024-02-05"), FechaEstado = DateTime.Parse("2024-02-06"), Estado = "Preparada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP004",
                        IdCliente = "CL005",
                        Transportista = "TR013",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Producto farmacéutico", Cantidad = 100},
                            new Producto { DescripcionProducto = "Inventario de lujo", Cantidad = 20 },
                            new Producto { DescripcionProducto = "Material sensible", Cantidad = 10 }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP005",
                        IdCliente = "CL004",
                        Transportista = "TR010",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Artículo de decoración", Cantidad = 60 },
                            new Producto { DescripcionProducto = "Producto farmacéutico", Cantidad = 70 }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS004", FechaEmision = DateTime.Parse("2024-02-10"), FechaEstado = DateTime.Parse("2024-02-18"), Estado = "Despachada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP006",
                        IdCliente = "CL010",
                        Transportista = "TR022",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Artículo de decoración", Cantidad = 40 },
                            new Producto { DescripcionProducto = "Calzado", Cantidad = 120 }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP007",
                        IdCliente = "CL009",
                        Transportista = "TR020",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Máquinas", Cantidad = 5 }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS005", FechaEmision = DateTime.Parse("2024-02-15"), FechaEstado = DateTime.Parse("2024-02-18"), Estado = "Seleccionada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP008",
                        IdCliente = "CL008",
                        Transportista = "TR019",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Calzado", Cantidad = 100 },
                            new Producto { DescripcionProducto = "Accesorio", Cantidad = 150 }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP009",
                        IdCliente = "CL010",
                        Transportista = "TR023",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Accesorio", Cantidad = 200 },
                            new Producto { DescripcionProducto = "Dispositivo electrónico", Cantidad = 80 }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS006", FechaEmision = DateTime.Parse("2024-02-16"), FechaEstado = DateTime.Parse("2024-02-19"), Estado = "Seleccionada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP010",
                        IdCliente = "CL004",
                        Transportista = "TR008",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Metales", Cantidad = 500 }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS007", FechaEmision = DateTime.Parse("2024-02-20"), FechaEstado = DateTime.Parse("2024-02-22"), Estado = "Seleccionada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP011",
                        IdCliente = "CL001",
                        Transportista = "TR003",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Ropa", Cantidad = 50 },
                            new Producto { DescripcionProducto = "Mueble", Cantidad = 200 }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS008", FechaEmision = DateTime.Parse("2024-02-22"), FechaEstado = DateTime.Parse("2024-02-25"), Estado = "Preparada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP012",
                        IdCliente = "CL002",
                        Transportista = "TR005",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Ropa", Cantidad = 20 },
                            new Producto {DescripcionProducto = "Ladrillos", Cantidad = 80 }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP013",
                        IdCliente = "CL003",
                        Transportista = "TR006",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Articulo de decoración", Cantidad = 50 },
                            new Producto { DescripcionProducto = "Cemento", Cantidad = 100 }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS009", FechaEmision = DateTime.Parse("2024-02-25"), FechaEstado = DateTime.Parse("2024-02-27"), Estado = "Despachada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP014",
                        IdCliente = "CL004",
                        Transportista = "TR011",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Metales", Cantidad = 600 },
                            new Producto { DescripcionProducto = "Producto farmacéutico", Cantidad = 150 }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS010", FechaEmision = DateTime.Parse("2024-02-26"), FechaEstado = DateTime.Parse("2024-02-28"), Estado = "Seleccionada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP015",
                        IdCliente = "CL005",
                        Transportista = "TR012",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Producto farmacéutico", Cantidad = 100 },
                            new Producto { DescripcionProducto = "Material sensible", Cantidad = 400 }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS011", FechaEmision = DateTime.Parse("2024-02-29"), FechaEstado = DateTime.Parse("2024-03-01"), Estado = "Preparada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP016",
                        IdCliente = "CL006",
                        Transportista = "TR014",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Articulos de decoración", Cantidad = 60 },
                            new Producto { DescripcionProducto = "Dispositivo electronico", Cantidad = 80 }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP017",
                        IdCliente = "CL007",
                        Transportista = "TR016",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Maquinas", Cantidad = 5 },
                            new Producto { DescripcionProducto = "Muebles", Cantidad = 10 }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS012", FechaEmision = DateTime.Parse("2024-03-01"), FechaEstado = DateTime.Parse("2024-03-03"), Estado = "Seleccionada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP018",
                        IdCliente = "CL008",
                        Transportista = "TR018",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Calzado", Cantidad = 800 },
                            new Producto { DescripcionProducto = "Accesorio", Cantidad = 2000 }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS013", FechaEmision = DateTime.Parse("2024-03-03"), FechaEstado = DateTime.Parse("2024-03-07"), Estado = "Preparada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP019",
                        IdCliente = "CL009",
                        Transportista = "TR021",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Maquinas", Cantidad = 30 },
                            new Producto { DescripcionProducto = "Muebles", Cantidad = 20 }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS014", FechaEmision = DateTime.Parse("2024-03-05"), FechaEstado = DateTime.Parse("2024-03-10"), Estado = "Despachada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP020",
                        IdCliente = "CL010",
                        Transportista = "TR023",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Articulos de decoración", Cantidad = 40 },
                            new Producto { DescripcionProducto = "Calzado", Cantidad = 120 }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP021",
                        IdCliente = "CL003",
                        Transportista = "TR007",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Ladrillos", Cantidad = 50, },
                            new Producto { DescripcionProducto = "Cemento", Cantidad = 10, }
                        }
                    }
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS015", FechaEmision = DateTime.Parse("2024-03-10"), FechaEstado = DateTime.Parse("2024-03-14"), Estado = "Preparada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP021",
                        IdCliente = "CL006",
                        Transportista = "TR015",
                        Productos = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Articulos de decoración", Cantidad = 100 },
                            new Producto { DescripcionProducto = "Metales", Cantidad = 400 },
                            new Producto { DescripcionProducto = "Dispositivo electronico", Cantidad = 100 }
                        }
                    }
                }
            }
        };
    }

   

}
