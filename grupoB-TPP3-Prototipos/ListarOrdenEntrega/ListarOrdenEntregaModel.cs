using grupoB_TPP3_Prototipos.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.ListarOrdenEntrega
{
    internal class ListarOrdenEntregaModel
    {

        public List<OrdenEntrega> OrdenesEntregadas = OrdenEntregaAlmacen.OrdenesEntrega.Select(oe => new OrdenEntrega
        {
            IdOrdenEntrega = oe.IdOrdenEntrega,
            FechaEmision = oe.FechaEmision,
            FechaEntrega = oe.FechaEntrega,
            // Estado = oe.Estado, // No está en la entidad

            // Asocia las órdenes de preparación usando la lista de identificadores en oe.OrdenesPreparacion
            OrdenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
            .Where(op => oe.OrdenesPreparacion.Contains(op.IdOrdenPreparacion)) // Filtra las órdenes de preparación que coincidan con los IDs en OrdenesPreparacion de OrdenEntrega
            .Select(op => new OrdenPreparacion
            {
                IdOrden = op.IdOrdenPreparacion,
                IdCliente = op.IdCliente,
                Transportista = op.IdTransportista,
                FechaEstado = op.FechaEntrega
            }).ToList()
        }).ToList();

        /*
           new OrdenEntrega { IdOrdenEntrega = "OS001", FechaEmision = DateTime.Parse("2024-01-15"), FechaEstado = DateTime.Parse("2024-01-18"), Estado = "Seleccionada",
               OrdenesPreparacion = new List <OrdenPreparacion>
               {
                   new OrdenPreparacion
                   {
                       IdOrden = "OP001",
                       IdCliente = "CL001",
                       Transportista = "TR001",
                       FechaEstado = DateTime.Parse("2024-01-18")
                   },
                   new OrdenPreparacion
                   {
                       IdOrden = "OP002",
                       IdCliente = "CL002",
                       Transportista = "TR005",
                       FechaEstado = DateTime.Parse("2024-01-18")
                   },
               }
           },
           new OrdenEntrega { IdOrdenEntrega = "OS002", FechaEmision = DateTime.Parse("2024-01-20"), FechaEstado = DateTime.Parse("2024-01-22"), Estado = "Despachada",
               OrdenesPreparacion = new List <OrdenPreparacion>
               {
                   new OrdenPreparacion
                   {
                       IdOrden = "OP003",
                       IdCliente = "CL001",
                       Transportista = "TR002",
                       FechaEstado = DateTime.Parse("2024-01-22")
                   }
               }
           },
           new OrdenEntrega { IdOrdenEntrega = "OS003", FechaEmision = DateTime.Parse("2024-02-05"), FechaEstado = DateTime.Parse("2024-02-06"), Estado = "Preparada",
               OrdenesPreparacion = new List<OrdenPreparacion>
               {
                   new OrdenPreparacion
                   {
                       IdOrden = "OP004",
                       IdCliente = "CL005",
                       Transportista = "TR013",
                       FechaEstado = DateTime.Parse("2024-02-06")
                   },
                   new OrdenPreparacion
                   {
                       IdOrden = "OP005",
                       IdCliente = "CL004",
                       Transportista = "TR010",
                       FechaEstado = DateTime.Parse("2024-02-06")
                   },
               }
           },

       }; */

        public List<OrdenEntrega> ObtenerOrdenesEntrega()
        {
            return OrdenesEntregadas;
        }

     

    }
}
