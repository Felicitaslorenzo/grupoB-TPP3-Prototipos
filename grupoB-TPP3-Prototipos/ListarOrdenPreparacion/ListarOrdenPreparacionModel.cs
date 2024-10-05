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
        new OrdenPreparacion { IdOrden = "OP-0001", IdCliente = 1, Nombre = "Porter SA", Estado = "Preparada", Fecha = DateTime.Parse("2024-09-30"), Prioridad = "Con prioridad de entrega" },
        new OrdenPreparacion { IdOrden = "OP-0002", IdCliente = 2, Nombre = "Ferreteria SRL", Estado = "Preparada", Fecha = DateTime.Parse("2024-09-25"), Prioridad = "Con prioridad de entrega" },
        new OrdenPreparacion { IdOrden = "OP-0003", IdCliente = 3, Nombre = "Orbital SA", Estado = "Preparada", Fecha = DateTime.Parse("2024-10-01"), Prioridad = "Sin prioridad de entrega" },
        new OrdenPreparacion { IdOrden = "OP-0004", IdCliente = 4, Nombre = "Techno Corp", Estado = "Preparada", Fecha = DateTime.Parse("2024-09-21"), Prioridad = "Sin prioridad de entrega" },
        new OrdenPreparacion { IdOrden = "OP-0005", IdCliente = 5, Nombre = "Construcciones Beta", Estado = "Preparada", Fecha = DateTime.Parse("2024-09-24"), Prioridad = "Con prioridad de entrega" },
        new OrdenPreparacion { IdOrden = "OP-0006", IdCliente = 6, Nombre = "Distribuciones Alfa", Estado = "Preparada", Fecha = DateTime.Parse("2024-09-19"), Prioridad = "Sin prioridad de entrega" },
        new OrdenPreparacion { IdOrden = "OP-0007", IdCliente = 7, Nombre = "Electro SA", Estado = "Preparada", Fecha = DateTime.Parse("2024-09-26"), Prioridad = "Con prioridad de entrega" },
        new OrdenPreparacion { IdOrden = "OP-0008", IdCliente = 8, Nombre = "Alimentos Granjeros", Estado = "Preparada", Fecha = DateTime.Parse("2024-09-22"), Prioridad = "Sin prioridad de entrega" },
        new OrdenPreparacion { IdOrden = "OP-0009", IdCliente = 9, Nombre = "Textiles Delta", Estado = "Preparada", Fecha = DateTime.Parse("2024-09-23"), Prioridad = "Con prioridad de entrega" },
        new OrdenPreparacion { IdOrden = "OP-0010", IdCliente = 10, Nombre = "Autopartes Gamma", Estado = "Preparada", Fecha = DateTime.Parse("2024-09-27"), Prioridad = "Sin prioridad de entrega" }
    };
       
        }

    }
}
