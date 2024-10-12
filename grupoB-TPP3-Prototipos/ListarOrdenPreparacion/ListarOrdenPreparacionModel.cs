using grupoB_TPP3_Prototipos.GenerarOrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.ListarOrdenPreparacion
{
    internal class ListarOrdenPreparacionModel
    {
        public List<OrdenPreparacion> ObtenerOrdenesPreparacion()
        {
            return new List<OrdenPreparacion>
            {
                new OrdenPreparacion
                {
                    IdOrden = "OP001",
                    IdCliente = "CL001",
                    Nombre = "Porter SA",
                    Estado = "Seleccionada",
                    FechaEstado = DateTime.Parse("2024-09-30"),
                    FechaEmision = DateTime.Parse("2024-10-03"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU001", DescripcionProducto = "Ropa", Cantidad = 30, Ubicacion = "1-2-4" },
                        new Producto { IDProducto = "SKU002", DescripcionProducto = "Mueble", Cantidad = 40, Ubicacion = "1-2-3" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP002",
                    IdCliente = "CL002",
                    Nombre = "Ferreteria SRL",
                    Estado = "Seleccionada",
                    FechaEstado = DateTime.Parse("2024-09-25"),
                    FechaEmision = DateTime.Parse("2024-09-29"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU004", DescripcionProducto = "Ladrillos", Cantidad = 50, Ubicacion = "2-3-1" },
                        new Producto { IDProducto = "SKU005", DescripcionProducto = "Cemento", Cantidad = 100, Ubicacion = "2-3-2" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP003",
                    IdCliente = "CL001",
                    Nombre = "Porter SA",
                    Estado = "Despachada",
                    FechaEstado = DateTime.Parse("2024-10-01"),
                    FechaEmision = DateTime.Parse("2024-10-05"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU003", DescripcionProducto = "Electrodoméstico", Cantidad = 15, Ubicacion = "3-1-2" },
                        new Producto { IDProducto = "SKU007", DescripcionProducto = "Artículo de decoración", Cantidad = 50, Ubicacion = "3-1-4" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP004",
                    IdCliente = "CL005",
                    Nombre = "Techno Corp",
                    Estado = "Preparada",
                    FechaEstado = DateTime.Parse("2024-09-21"),
                    FechaEmision = DateTime.Parse("2024-09-25"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU011", DescripcionProducto = "Producto farmacéutico", Cantidad = 100, Ubicacion = "4-2-1" },
                        new Producto { IDProducto = "SKU012", DescripcionProducto = "Inventario de lujo", Cantidad = 20, Ubicacion = "4-2-3" },
                        new Producto { IDProducto = "SKU013", DescripcionProducto = "Material sensible", Cantidad = 10, Ubicacion = "4-2-5" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP005",
                    IdCliente = "CL004",
                    Nombre = "Construcciones Beta",
                    Estado = "Preparada",
                    FechaEstado = DateTime.Parse("2024-09-24"),
                    FechaEmision = DateTime.Parse("2024-09-28"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU007", DescripcionProducto = "Artículo de decoración", Cantidad = 60, Ubicacion = "5-1-3" },
                        new Producto { IDProducto = "SKU011", DescripcionProducto = "Producto farmacéutico", Cantidad = 70, Ubicacion = "5-1-5" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP006",
                    IdCliente = "CL010",
                    Nombre = "Distribuciones Alfa",
                    Estado = "Despachada",
                    FechaEstado = DateTime.Parse("2024-09-19"),
                    FechaEmision = DateTime.Parse("2024-09-23"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU007", DescripcionProducto = "Artículo de decoración", Cantidad = 40, Ubicacion = "6-2-1" },
                        new Producto { IDProducto = "SKU018", DescripcionProducto = "Calzado", Cantidad = 120, Ubicacion = "6-2-3" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP007",
                    IdCliente = "CL009",
                    Nombre = "Electro SA",
                    Estado = "Despachada",
                    FechaEstado = DateTime.Parse("2024-09-26"),
                    FechaEmision = DateTime.Parse("2024-09-30"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU015", DescripcionProducto = "Máquinas", Cantidad = 5, Ubicacion = "7-1-1" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP008",
                    IdCliente = "CL008",
                    Nombre = "Alimentos Granjeros",
                    Estado = "Seleccionada",
                    FechaEstado = DateTime.Parse("2024-09-22"),
                    FechaEmision = DateTime.Parse("2024-09-26"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU018", DescripcionProducto = "Calzado", Cantidad = 100, Ubicacion = "8-1-2" },
                        new Producto { IDProducto = "SKU019", DescripcionProducto = "Accesorio", Cantidad = 150, Ubicacion = "8-1-3" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP009",
                    IdCliente = "CL010",
                    Nombre = "Distribuciones Alfa",
                    Estado = "Seleccionada",
                    FechaEstado = DateTime.Parse("2024-09-23"),
                    FechaEmision = DateTime.Parse("2024-09-27"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU019", DescripcionProducto = "Accesorio", Cantidad = 200, Ubicacion = "9-1-1" },
                        new Producto { IDProducto = "SKU014", DescripcionProducto = "Dispositivo electrónico", Cantidad = 80, Ubicacion = "9-1-2" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP010",
                    IdCliente = "CL004",
                    Nombre = "Construcciones Beta",
                    Estado = "Seleccionada",
                    FechaEstado = DateTime.Parse("2024-09-27"),
                    FechaEmision = DateTime.Parse("2024-09-30"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU010", DescripcionProducto = "Metales", Cantidad = 500, Ubicacion = "10-1-2" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP011",
                    IdCliente = "CL001",
                    Nombre = "Porter SA",
                    Estado = "Seleccionada",
                    FechaEstado = DateTime.Parse("2024-10-01"),
                    FechaEmision = DateTime.Parse("2024-10-05"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU001", DescripcionProducto = "Ropa", Cantidad = 50, Ubicacion = "11-2-4" },
                        new Producto { IDProducto = "SKU002", DescripcionProducto = "Mueble", Cantidad = 200, Ubicacion = "11-2-3" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP012",
                    IdCliente = "CL002",
                    Nombre = "Ferreteria SRL",
                    Estado = "Preparada",
                    FechaEstado = DateTime.Parse("2024-10-02"),
                    FechaEmision = DateTime.Parse("2024-10-06"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU001", DescripcionProducto = "Ropa", Cantidad = 20, Ubicacion = "12-1-1" },
                        new Producto { IDProducto = "SKU004", DescripcionProducto = "Ladrillos", Cantidad = 80, Ubicacion = "12-1-2" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP013",
                    IdCliente = "CL003",
                    Nombre = "Materiales SRL",
                    Estado = "Preparada",
                    FechaEstado = DateTime.Parse("2024-10-03"),
                    FechaEmision = DateTime.Parse("2024-10-07"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulo de decoración", Cantidad = 50, Ubicacion = "13-3-1" },
                        new Producto { IDProducto = "SKU009", DescripcionProducto = "Cemento", Cantidad = 100, Ubicacion = "13-3-2" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP014",
                    IdCliente = "CL004",
                    Nombre = "Construcciones Beta",
                    Estado = "Despachada",
                    FechaEstado = DateTime.Parse("2024-10-04"),
                    FechaEmision = DateTime.Parse("2024-10-08"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU010", DescripcionProducto = "Metales", Cantidad = 600, Ubicacion = "14-4-1" },
                        new Producto { IDProducto = "SKU011", DescripcionProducto = "Producto farmacéutico", Cantidad = 150, Ubicacion = "14-4-2" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP015",
                    IdCliente = "CL005",
                    Nombre = "Techno Corp",
                    Estado = "Seleccionada",
                    FechaEstado = DateTime.Parse("2024-10-05"),
                    FechaEmision = DateTime.Parse("2024-10-09"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU011", DescripcionProducto = "Producto farmacéutico", Cantidad = 100, Ubicacion = "15-5-1" },
                        new Producto { IDProducto = "SKU013", DescripcionProducto = "Material sensible", Cantidad = 400, Ubicacion = "15-5-2" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP016",
                    IdCliente = "CL006",
                    Nombre = "Distribuciones Omega",
                    Estado = "Preparada",
                    FechaEstado = DateTime.Parse("2024-10-06"),
                    FechaEmision = DateTime.Parse("2024-10-10"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulos de decoración", Cantidad = 60, Ubicacion = "16-6-1" },
                        new Producto { IDProducto = "SKU014", DescripcionProducto = "Dispositivo electronico", Cantidad = 80, Ubicacion = "16-6-2" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP017",
                    IdCliente = "CL007",
                    Nombre = "Decoraciones SA",
                    Estado = "Preparada",
                    FechaEstado = DateTime.Parse("2024-10-07"),
                    FechaEmision = DateTime.Parse("2024-10-11"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU015", DescripcionProducto = "Maquinas", Cantidad = 5, Ubicacion = "17-7-1" },
                        new Producto { IDProducto = "SKU016", DescripcionProducto = "Muebles", Cantidad = 10, Ubicacion = "17-7-2" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP018",
                    IdCliente = "CL008",
                    Nombre = "Alimentos Granjeros",
                    Estado = "Seleccionada",
                    FechaEstado = DateTime.Parse("2024-10-08"),
                    FechaEmision = DateTime.Parse("2024-10-12"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU018", DescripcionProducto = "Calzado", Cantidad = 800, Ubicacion = "18-8-1" },
                        new Producto { IDProducto = "SKU019", DescripcionProducto = "Accesorio", Cantidad = 2000, Ubicacion = "18-8-2" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP019",
                    IdCliente = "CL009",
                    Nombre = "Electro SA",
                    Estado = "Preparada",
                    FechaEstado = DateTime.Parse("2024-10-09"),
                    FechaEmision = DateTime.Parse("2024-10-13"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU015", DescripcionProducto = "Maquinas", Cantidad = 30, Ubicacion = "19-9-1" },
                        new Producto { IDProducto = "SKU016", DescripcionProducto = "Muebles", Cantidad = 20, Ubicacion = "19-9-2" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP020",
                    IdCliente = "CL010",
                    Nombre = "Distribuciones Alfa",
                    Estado = "Despachada",
                    FechaEstado = DateTime.Parse("2024-10-10"),
                    FechaEmision = DateTime.Parse("2024-10-14"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulos de decoración", Cantidad = 40, Ubicacion = "20-10-1" },
                        new Producto { IDProducto = "SKU018", DescripcionProducto = "Calzado", Cantidad = 120, Ubicacion = "20-10-2" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP021",
                    IdCliente = "CL003",
                    Nombre = "Materiales SRL",
                    Estado = "Despachada",
                    FechaEstado = DateTime.Parse("2024-10-12"),
                    FechaEmision = DateTime.Parse("2024-10-16"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU008", DescripcionProducto = "Ladrillos", Cantidad = 50, Ubicacion = "11-4-5" },
                        new Producto { IDProducto = "SKU009", DescripcionProducto = "Cemento", Cantidad = 10, Ubicacion = "12-3-4" }
                    }
                },
                new OrdenPreparacion
                {
                    IdOrden = "OP021",
                    IdCliente = "CL006",
                    Nombre = "Distribuciones Omega",
                    Estado = "Preparada",
                    FechaEstado = DateTime.Parse("2024-10-14"),
                    FechaEmision = DateTime.Parse("2024-10-16"),
                    Producto = new List<Producto>
                    {
                        new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulos de decoración", Cantidad = 100, Ubicacion = "11-2-2" },
                        new Producto { IDProducto = "SKU010", DescripcionProducto = "Metales", Cantidad = 400, Ubicacion = "12-3-4" },
                        new Producto { IDProducto = "SKU014", DescripcionProducto = "Dispositivo electronico", Cantidad = 100, Ubicacion = "10-2-3" }
                    }
                }
            };
        }
    }
}
