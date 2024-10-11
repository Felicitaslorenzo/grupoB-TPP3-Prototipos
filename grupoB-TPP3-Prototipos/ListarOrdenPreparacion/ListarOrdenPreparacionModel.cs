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
                    Estado = "Preparada",
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
                    Estado = "Preparada",
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
                }
            };
        }
    }
}
