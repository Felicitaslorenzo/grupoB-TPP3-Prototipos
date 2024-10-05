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
                IdOrden = 1,
                IdCliente = 1,
                Nombre = "Porter SA",
                Estado = "Preparada",
                Fecha = DateTime.Now.AddDays(-2),
                Prioridad = "Con prioridad de entrega"
            },
            new OrdenPreparacion
            {
                IdOrden = 2,
                IdCliente = 2,
                Nombre = "Ferreteria SRL",
                Estado = "Preparada",
                Fecha = DateTime.Now.AddDays(-5),
                Prioridad = "Con prioridad de entrega"
            },
            new OrdenPreparacion
            {
                IdOrden = 3,
                IdCliente = 3,
                Nombre = "Orbital SA",
                Estado = "Preparada",
                Fecha = DateTime.Now.AddDays(-1),
                Prioridad = "Sin prioridad de entrega"
            },
            new OrdenPreparacion
            {
                IdOrden = 4,
                IdCliente = 4,
                Nombre = "Techno Corp",
                Estado = "Preparada",
                Fecha = DateTime.Now.AddDays(-10),
                Prioridad = "Sin prioridad de entrega"
            },
            new OrdenPreparacion
            {
                IdOrden = 5,
                IdCliente = 5,
                Nombre = "Construcciones Beta",
                Estado = "Preparada",
                Fecha = DateTime.Now.AddDays(-7),
                Prioridad = "Con prioridad de entrega"
            },
            new OrdenPreparacion
            {
                IdOrden = 6,
                IdCliente = 6,
                Nombre = "Distribuciones Alfa",
                Estado = "Preparada",
                Fecha = DateTime.Now.AddDays(-12),
                Prioridad = "Sin prioridad de entrega"
            },
            new OrdenPreparacion
            {
                IdOrden = 7,
                IdCliente = 7,
                Nombre = "Electro SA",
                Estado = "Preparada",
                Fecha = DateTime.Now.AddDays(-4),
                Prioridad = "Con prioridad de entrega"
            },
            new OrdenPreparacion
            {
                IdOrden = 8,
                IdCliente = 8,
                Nombre = "Alimentos Granjeros",
                Estado = "Preparada",
                Fecha = DateTime.Now.AddDays(-6),
                Prioridad = "Sin prioridad de entrega"
            },
            new OrdenPreparacion
            {
                IdOrden = 9,
                IdCliente = 9,
                Nombre = "Textiles Delta",
                Estado = "Preparada",
                Fecha = DateTime.Now.AddDays(-8),
                Prioridad = "Con prioridad de entrega"
            },
            new OrdenPreparacion
            {
                IdOrden = 10,
                IdCliente = 10,
                Nombre = "Autopartes Gamma",
                Estado = "Preparada",
                Fecha = DateTime.Now.AddDays(-3),
                Prioridad = "Sin prioridad de entrega"
            }
            };
        }

    }
}
