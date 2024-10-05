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
            new OrdenSeleccion { IdOrdenSeleccion = "OS-001", FechaOS = DateTime.Parse("2024-01-15"), DescripcionProducto = "Monitor", Cantidad = 5, Ubicacion = "Almacén A", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-002", FechaOS = DateTime.Parse("2024-01-20"), DescripcionProducto = "Teclado", Cantidad = 10, Ubicacion = "Almacén B", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-003", FechaOS = DateTime.Parse("2024-02-05"), DescripcionProducto = "Mouse", Cantidad = 15, Ubicacion = "Almacén C", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-004", FechaOS = DateTime.Parse("2024-02-10"), DescripcionProducto = "Impresora", Cantidad = 2, Ubicacion = "Almacén D", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-005", FechaOS = DateTime.Parse("2024-02-15"), DescripcionProducto = "Cable HDMI", Cantidad = 20, Ubicacion = "Almacén A", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-006", FechaOS = DateTime.Parse("2024-03-01"), DescripcionProducto = "Laptop", Cantidad = 3, Ubicacion = "Almacén B", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-007", FechaOS = DateTime.Parse("2024-03-05"), DescripcionProducto = "Proyector", Cantidad = 1, Ubicacion = "Almacén C", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-008", FechaOS = DateTime.Parse("2024-03-10"), DescripcionProducto = "Escritorio", Cantidad = 4, Ubicacion = "Almacén D", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-009", FechaOS = DateTime.Parse("2024-03-15"), DescripcionProducto = "Silla de Oficina", Cantidad = 12, Ubicacion = "Almacén A", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-010", FechaOS = DateTime.Parse("2024-03-20"), DescripcionProducto = "Tóner", Cantidad = 8, Ubicacion = "Almacén B", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-011", FechaOS = DateTime.Parse("2024-03-25"), DescripcionProducto = "Monitor 4K", Cantidad = 2, Ubicacion = "Almacén C", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-012", FechaOS = DateTime.Parse("2024-03-30"), DescripcionProducto = "Router", Cantidad = 6, Ubicacion = "Almacén D", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-013", FechaOS = DateTime.Parse("2024-04-05"), DescripcionProducto = "Switch de Red", Cantidad = 4, Ubicacion = "Almacén A", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-014", FechaOS = DateTime.Parse("2024-04-10"), DescripcionProducto = "Disco Duro", Cantidad = 10, Ubicacion = "Almacén B", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-015", FechaOS = DateTime.Parse("2024-04-15"), DescripcionProducto = "Memoria RAM", Cantidad = 16, Ubicacion = "Almacén C", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-016", FechaOS = DateTime.Parse("2024-04-20"), DescripcionProducto = "SSD", Cantidad = 8, Ubicacion = "Almacén D", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-017", FechaOS = DateTime.Parse("2024-04-25"), DescripcionProducto = "Fuente de Poder", Cantidad = 5, Ubicacion = "Almacén A", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-018", FechaOS = DateTime.Parse("2024-04-30"), DescripcionProducto = "Caja de Herramientas", Cantidad = 7, Ubicacion = "Almacén B", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-019", FechaOS = DateTime.Parse("2024-05-05"), DescripcionProducto = "Multímetro", Cantidad = 3, Ubicacion = "Almacén C", Estado = "Pendiente" },
            new OrdenSeleccion { IdOrdenSeleccion = "OS-020", FechaOS = DateTime.Parse("2024-05-10"), DescripcionProducto = "Impresora 3D", Cantidad = 1, Ubicacion = "Almacén D", Estado = "Pendiente" },
        };


    }
}
