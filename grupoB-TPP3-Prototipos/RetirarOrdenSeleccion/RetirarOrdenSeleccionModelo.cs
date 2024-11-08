using grupoB_TPP3_Prototipos.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.RetirarOrdenSeleccion
{
    internal class RetirarOrdenSeleccionModelo
    {
        public bool IsConfirming { get; set; } = false;

        public List<OrdenSeleccion> OrdenesSeleccionadas
        {
            get
            {
                // Lista que contendrá las ordenes seleccionadas
                var listarOrdenesSeleccion = new List<OrdenSeleccion>();

                // Recorrer todas las OrdenesSeleccion
                foreach (var ordenEntidad in OrdenSeleccionAlmacen.OrdenesSeleccion)
                {
                    var ordenModelo = new OrdenSeleccion
                    {
                        IdOrdenSeleccion = ordenEntidad.IdOrdenSeleccion // Asignación correcta para OrdenSeleccion
                    };

                    // Buscar las OrdenesPreparacion asociadas con la OrdenSeleccion actual
                    var ordenesPreparacionRelacionadas = OrdenPreparacionAlmacen.OrdenesPreparacion
                        .Where(orden => ordenEntidad.OrdenesPreparacion.Contains(orden.IdOrdenPreparacion.ToString())) // Comparar si el IdOrdenPreparacion está en la lista de strings
                        .Select(ordenEntidad2 => new OrdenPreparacion
                        {
                            IdOrden = ordenEntidad2.IdOrdenPreparacion,
                            Cliente = ClienteAlmacen.Clientes.First(c => c.IdCliente == ordenEntidad2.IdCliente).NombreCliente,
                            FechaEmision = ordenEntidad2.FechaEmision,
                            FechaDespacho = ordenEntidad2.FechaEntrega,
                            Producto = ordenEntidad2.Detalle.Select(detalle => new Producto
                            {
                                DescripcionProducto = ProductoAlmacen.Productos.First(pr => pr.SKUProducto == detalle.SKUProducto).DescripcionProducto,
                                Cantidad = detalle.Cantidad,
                                // Ubicacion = InventarioMercaderiaAlmacen.Ubicacion

                            }).ToList()
                        }).ToList();

                    // Asociar las ordenes de preparación a la orden de selección
                    ordenModelo.OrdenesPreparacion = ordenesPreparacionRelacionadas;

                    // Agregar el modelo de la orden seleccionada a la lista
                    listarOrdenesSeleccion.Add(ordenModelo);
                }

                // Devolver la lista de ordenes seleccionadas con sus respectivas ordenes de preparación
                return listarOrdenesSeleccion;
            }

            /*
            new OrdenSeleccion { IdOrdenSeleccion = "OS001",
                OrdenesPreparacion = new List <OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP001",
                        Cliente = "Porter SA",
                        FechaDespacho = DateTime.Parse("2024-09-30"),
                        FechaEmision = DateTime.Parse("2024-10-03"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Ropa", Cantidad = 30, Ubicacion = "1-2-4" },
                            new Producto { DescripcionProducto = "Mueble", Cantidad = 40, Ubicacion = "1-2-3" }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP002",
                        Cliente = "Ferreteria SRL",
                        FechaDespacho = DateTime.Parse("2024-09-25"),
                        FechaEmision = DateTime.Parse("2024-09-29"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Ladrillos", Cantidad = 50, Ubicacion = "2-3-1" },
                            new Producto { DescripcionProducto = "Cemento", Cantidad = 100, Ubicacion = "2-3-2" }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS002",
                OrdenesPreparacion = new List <OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP003",
                        Cliente = "Porter SA",
                        FechaDespacho = DateTime.Parse("2024-10-01"),
                        FechaEmision = DateTime.Parse("2024-10-05"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Electrodoméstico", Cantidad = 15, Ubicacion = "3-1-2" },
                            new Producto { DescripcionProducto = "Artículo de decoración", Cantidad = 50, Ubicacion = "3-1-4" }
                        }
                    }
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS003",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP004",
                        Cliente = "Techno Corp",
                        FechaDespacho = DateTime.Parse("2024-09-21"),
                        FechaEmision = DateTime.Parse("2024-09-25"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Producto farmacéutico", Cantidad = 100, Ubicacion = "4-2-1" },
                            new Producto { DescripcionProducto = "Inventario de lujo", Cantidad = 20, Ubicacion = "4-2-3" },
                            new Producto { DescripcionProducto = "Material sensible", Cantidad = 10, Ubicacion = "4-2-5" }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP005",
                        Cliente = "Construcciones Beta",
                        FechaDespacho = DateTime.Parse("2024-09-24"),
                        FechaEmision = DateTime.Parse("2024-09-28"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Artículo de decoración", Cantidad = 60, Ubicacion = "5-1-3" },
                            new Producto { DescripcionProducto = "Producto farmacéutico", Cantidad = 70, Ubicacion = "5-1-5" }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS004",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP006",
                        Cliente = "Distribuciones Alfa",
                        FechaDespacho = DateTime.Parse("2024-09-19"),
                        FechaEmision = DateTime.Parse("2024-09-23"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Artículo de decoración", Cantidad = 40, Ubicacion = "6-2-1" },
                            new Producto { DescripcionProducto = "Calzado", Cantidad = 120, Ubicacion = "6-2-3" }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP007",
                        Cliente = "Electro SA",
                        FechaDespacho = DateTime.Parse("2024-09-26"),
                        FechaEmision = DateTime.Parse("2024-09-30"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Máquinas", Cantidad = 5, Ubicacion = "7-1-1" }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS005",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP008",
                        Cliente = "Alimentos Granjeros",
                        FechaDespacho = DateTime.Parse("2024-09-22"),
                        FechaEmision = DateTime.Parse("2024-09-26"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Calzado", Cantidad = 100, Ubicacion = "8-1-2" },
                            new Producto { DescripcionProducto = "Accesorio", Cantidad = 150, Ubicacion = "8-1-3" }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP009",
                        Cliente = "Distribuciones Alfa",
                        FechaDespacho = DateTime.Parse("2024-09-23"),
                        FechaEmision = DateTime.Parse("2024-09-27"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Accesorio", Cantidad = 200, Ubicacion = "9-1-1" },
                            new Producto { DescripcionProducto = "Dispositivo electrónico", Cantidad = 80, Ubicacion = "9-1-2" }
                        }
                    }
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS006",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP010",
                        Cliente = "Construcciones Beta",
                        FechaDespacho = DateTime.Parse("2024-09-27"),
                        FechaEmision = DateTime.Parse("2024-09-30"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Metales", Cantidad = 500, Ubicacion = "10-1-2" }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS007",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP011",
                        Cliente = "Porter SA",
                        FechaDespacho = DateTime.Parse("2024-10-01"),
                        FechaEmision = DateTime.Parse("2024-10-05"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Ropa", Cantidad = 50, Ubicacion = "11-2-4" },
                            new Producto { DescripcionProducto = "Mueble", Cantidad = 200, Ubicacion = "11-2-3" }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS008",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP012",
                        Cliente = "Ferreteria SRL",
                        FechaDespacho = DateTime.Parse("2024-10-02"),
                        FechaEmision = DateTime.Parse("2024-10-06"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Ropa", Cantidad = 20, Ubicacion = "12-1-1" },
                            new Producto { DescripcionProducto = "Ladrillos", Cantidad = 80, Ubicacion = "12-1-2" }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP013",
                        Cliente = "Materiales SRL",
                        FechaDespacho = DateTime.Parse("2024-10-03"),
                        FechaEmision = DateTime.Parse("2024-10-07"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Articulo de decoración", Cantidad = 50, Ubicacion = "13-3-1" },
                            new Producto { DescripcionProducto = "Cemento", Cantidad = 100, Ubicacion = "13-3-2" }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS009", 
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP014",
                        Cliente = "Construcciones Beta",
                        FechaDespacho = DateTime.Parse("2024-10-04"),
                        FechaEmision = DateTime.Parse("2024-10-08"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Metales", Cantidad = 600, Ubicacion = "14-4-1" },
                            new Producto { DescripcionProducto = "Producto farmacéutico", Cantidad = 150, Ubicacion = "14-4-2" }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS010",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP015",
                        Cliente = "Techno Corp",
                        FechaDespacho = DateTime.Parse("2024-10-05"),
                        FechaEmision = DateTime.Parse("2024-10-09"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Producto farmacéutico", Cantidad = 100, Ubicacion = "15-5-1" },
                            new Producto { DescripcionProducto = "Material sensible", Cantidad = 400, Ubicacion = "15-5-2" }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS011", 
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP016",
                        Cliente = "Distribuciones Omega",
                        FechaDespacho = DateTime.Parse("2024-10-06"),
                        FechaEmision = DateTime.Parse("2024-10-10"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Articulos de decoración", Cantidad = 60, Ubicacion = "16-6-1" },
                            new Producto { DescripcionProducto = "Dispositivo electronico", Cantidad = 80, Ubicacion = "16-6-2" }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP017",
                        Cliente = "Decoraciones SA",
                        FechaDespacho = DateTime.Parse("2024-10-07"),
                        FechaEmision = DateTime.Parse("2024-10-11"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Maquinas", Cantidad = 5, Ubicacion = "17-7-1" },
                            new Producto { DescripcionProducto = "Muebles", Cantidad = 10, Ubicacion = "17-7-2" }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS012",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP018",
                        Cliente = "Alimentos Granjeros", 
                        FechaDespacho = DateTime.Parse("2024-10-08"),
                        FechaEmision = DateTime.Parse("2024-10-12"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Calzado", Cantidad = 800, Ubicacion = "18-8-1" },
                            new Producto { DescripcionProducto = "Accesorio", Cantidad = 2000, Ubicacion = "18-8-2" }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS013",  
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP019",
                        Cliente = "Electro SA", 
                        FechaDespacho = DateTime.Parse("2024-10-09"),
                        FechaEmision = DateTime.Parse("2024-10-13"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Maquinas", Cantidad = 30, Ubicacion = "19-9-1" },
                            new Producto { DescripcionProducto = "Muebles", Cantidad = 20, Ubicacion = "19-9-2" }
                        }
                    },
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS014",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP020",
                        Cliente = "Distribuciones Alfa", 
                        FechaDespacho = DateTime.Parse("2024-10-10"),
                        FechaEmision = DateTime.Parse("2024-10-14"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Articulos de decoración", Cantidad = 40, Ubicacion = "20-10-1" },
                            new Producto { DescripcionProducto = "Calzado", Cantidad = 120, Ubicacion = "20-10-2" }
                        }
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP021",
                        Cliente = "Materiales SRL", 
                        FechaDespacho = DateTime.Parse("2024-10-12"),
                        FechaEmision = DateTime.Parse("2024-10-16"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Ladrillos", Cantidad = 50, Ubicacion = "11-4-5" },
                            new Producto { DescripcionProducto = "Cemento", Cantidad = 10, Ubicacion = "12-3-4" }
                        }
                    }
                }
            },
            new OrdenSeleccion { IdOrdenSeleccion = "OS015", 
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP021",
                        Cliente = "Distribuciones Omega", 
                        FechaDespacho = DateTime.Parse("2024-10-14"),
                        FechaEmision = DateTime.Parse("2024-10-16"),
                        Producto = new List<Producto>
                        {
                            new Producto { DescripcionProducto = "Articulos de decoración", Cantidad = 100, Ubicacion = "11-2-2" },
                            new Producto { DescripcionProducto = "Metales", Cantidad = 400, Ubicacion = "12-3-4" },
                            new Producto { DescripcionProducto = "Dispositivo electronico", Cantidad = 100, Ubicacion = "10-2-3" }
                        }
                    }
                }
            }
        }; */
        }
    }
}
