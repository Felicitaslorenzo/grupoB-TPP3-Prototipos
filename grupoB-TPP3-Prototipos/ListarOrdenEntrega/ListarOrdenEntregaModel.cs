using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.ListarOrdenEntrega
{
    internal class ListarOrdenEntregaModel
    {

        public List<OrdenEntrega> ObtenerOrdenesEntrega()
        {
                    return new List<OrdenEntrega>
            {
                new OrdenEntrega { IdOrden = "OP-0001", IdCliente = 1, Nombre = "Porter SA", Estado = "Preparada", FechaEstado = DateTime.Parse("2024-09-30"), FechaEmision = DateTime.Parse("2024-09-20"), Prioridad = "Con prioridad de entrega" },
                new OrdenEntrega { IdOrden = "OP-0002", IdCliente = 2, Nombre = "Ferreteria SRL", Estado = "Preparada",  FechaEstado = DateTime.Parse("2024-09-25"), FechaEmision = DateTime.Parse("2024-09-22"), Prioridad = "Con prioridad de entrega" },
                new OrdenEntrega { IdOrden = "OP-0003", IdCliente = 3, Nombre = "Orbital SA", Estado = "Preparada", FechaEstado = DateTime.Parse("2024-09-18"), FechaEmision = DateTime.Parse("2024-10-01"), Prioridad = "Sin prioridad de entrega" },
                new OrdenEntrega { IdOrden = "OP-0004", IdCliente = 4, Nombre = "Techno Corp", Estado = "Preparada", FechaEstado = DateTime.Parse("2024-09-22"), FechaEmision = DateTime.Parse("2024-09-21"), Prioridad = "Sin prioridad de entrega" },
                new OrdenEntrega { IdOrden = "OP-0005", IdCliente = 5, Nombre = "Construcciones Beta", Estado = "Preparada", FechaEstado = DateTime.Parse("2024-09-24"), FechaEmision = DateTime.Parse("2024-09-09"), Prioridad = "Con prioridad de entrega" },
                new OrdenEntrega { IdOrden = "OP-0006", IdCliente = 6, Nombre = "Distribuciones Alfa", Estado = "Preparada",  FechaEstado = DateTime.Parse("2024-09-19"), FechaEmision = DateTime.Parse("2024-09-02"), Prioridad = "Sin prioridad de entrega" },
                new OrdenEntrega { IdOrden = "OP-0007", IdCliente = 7, Nombre = "Electro SA", Estado = "Preparada",  FechaEstado = DateTime.Parse("2024-09-30"), FechaEmision = DateTime.Parse("2024-09-26"), Prioridad = "Con prioridad de entrega" },
                new OrdenEntrega { IdOrden = "OP-0008", IdCliente = 8, Nombre = "Alimentos Granjeros", Estado = "Preparada",  FechaEstado = DateTime.Parse("2024-09-28"), FechaEmision = DateTime.Parse("2024-09-22"), Prioridad = "Sin prioridad de entrega" },
                new OrdenEntrega { IdOrden = "OP-0009", IdCliente = 9, Nombre = "Textiles Delta", Estado = "Preparada",  FechaEstado = DateTime.Parse("2024-09-23"), FechaEmision = DateTime.Parse("2024-09-01"), Prioridad = "Con prioridad de entrega" },
                new OrdenEntrega{ IdOrden = "OP-0010", IdCliente = 10, Nombre = "Autopartes Gamma", Estado = "Preparada",  FechaEstado = DateTime.Parse("2024-09-27"), FechaEmision = DateTime.Parse("2024-09-11"), Prioridad = "Sin prioridad de entrega" }
            };
        }


    }
}
