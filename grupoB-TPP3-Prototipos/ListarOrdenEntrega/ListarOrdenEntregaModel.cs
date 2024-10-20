using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.ListarOrdenEntrega
{
    internal class ListarOrdenEntregaModel
    {

        public List<OrdenEntrega> OrdenesEntregadas = new List<OrdenEntrega>
        {
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
            new OrdenEntrega { IdOrdenEntrega = "OS004", FechaEmision = DateTime.Parse("2024-02-10"), FechaEstado = DateTime.Parse("2024-02-18"), Estado = "En selección",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP006",
                        IdCliente = "CL010",
                        Transportista = "TR022",
                        FechaEstado = DateTime.Parse("2024-02-18")
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP007",
                        IdCliente = "CL009",
                        Transportista = "TR020",
                        FechaEstado = DateTime.Parse("2024-02-18")
                    },
                }
            },
            new OrdenEntrega { IdOrdenEntrega = "OS005", FechaEmision = DateTime.Parse("2024-02-15"), FechaEstado = DateTime.Parse("2024-02-18"), Estado = "Pendiente",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP008",
                        IdCliente = "CL008",
                        Transportista = "TR019",
                        FechaEstado = DateTime.Parse("2024-02-18")
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP009",
                        IdCliente = "CL010",
                        Transportista = "TR023",
                        FechaEstado = DateTime.Parse("2024-02-18")
                    },
                }
            },
            new OrdenEntrega { IdOrdenEntrega = "OS006", FechaEmision = DateTime.Parse("2024-02-16"), FechaEstado = DateTime.Parse("2024-02-19"), Estado = "Pendiente",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP010",
                        IdCliente = "CL004",
                        Transportista = "TR008",
                        FechaEstado = DateTime.Parse("2024-02-19")
                    },
                }
            },
            new OrdenEntrega { IdOrdenEntrega = "OS007", FechaEmision = DateTime.Parse("2024-02-20"), FechaEstado = DateTime.Parse("2024-02-22"), Estado = "Seleccionada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP011",
                        IdCliente = "CL001",
                        Transportista = "TR003",
                        FechaEstado = DateTime.Parse("2024-02-22")
                    },
                }
            },
            new OrdenEntrega { IdOrdenEntrega = "OS008", FechaEmision = DateTime.Parse("2024-02-22"), FechaEstado = DateTime.Parse("2024-02-25"), Estado = "Preparada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP012",
                        IdCliente = "CL002",
                        Transportista = "TR005",
                        FechaEstado = DateTime.Parse("2024-02-25")
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP013",
                        IdCliente = "CL003",
                        Transportista = "TR006",
                        FechaEstado = DateTime.Parse("2024-02-25")
                    },
                }
            },
            new OrdenEntrega { IdOrdenEntrega = "OS009", FechaEmision = DateTime.Parse("2024-02-25"), FechaEstado = DateTime.Parse("2024-02-27"), Estado = "Despachada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP014",
                        IdCliente = "CL004",
                        Transportista = "TR011",
                        FechaEstado = DateTime.Parse("2024-02-27")
                    },
                }
            },
            new OrdenEntrega { IdOrdenEntrega = "OS010", FechaEmision = DateTime.Parse("2024-02-26"), FechaEstado = DateTime.Parse("2024-02-28"), Estado = "En selección",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP015",
                        IdCliente = "CL005",
                        Transportista = "TR012",
                        FechaEstado = DateTime.Parse("2024-02-28")
                    },
                }
            },
            new OrdenEntrega { IdOrdenEntrega = "OS011", FechaEmision = DateTime.Parse("2024-02-29"), FechaEstado = DateTime.Parse("2024-03-01"), Estado = "Preparada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP016",
                        IdCliente = "CL006",
                        Transportista = "TR014",
                        FechaEstado = DateTime.Parse("2024-03-01")
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP017",
                        IdCliente = "CL007",
                        Transportista = "TR016",
                        FechaEstado = DateTime.Parse("2024-03-01")
                    },
                }
            },
            new OrdenEntrega { IdOrdenEntrega = "OS012", FechaEmision = DateTime.Parse("2024-03-01"), FechaEstado = DateTime.Parse("2024-03-03"), Estado = "Seleccionada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP018",
                        IdCliente = "CL008",
                        Transportista = "TR018",
                        FechaEstado = DateTime.Parse("2024-03-03")
                    },
                }
            },
            new OrdenEntrega { IdOrdenEntrega = "OS013", FechaEmision = DateTime.Parse("2024-03-03"), FechaEstado = DateTime.Parse("2024-03-07"), Estado = "Preparada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP019",
                        IdCliente = "CL009",
                        Transportista = "TR021",
                        FechaEstado = DateTime.Parse("2024-03-07")
                    },
                }
            },
            new OrdenEntrega { IdOrdenEntrega = "OS014", FechaEmision = DateTime.Parse("2024-03-05"), FechaEstado = DateTime.Parse("2024-03-10"), Estado = "Despachada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP020",
                        IdCliente = "CL010",
                        Transportista = "TR023",
                        FechaEstado = DateTime.Parse("2024-03-10")
                    },
                    new OrdenPreparacion
                    {
                        IdOrden = "OP021",
                        IdCliente = "CL003",
                        Transportista = "TR007",
                        FechaEstado = DateTime.Parse("2024-03-10")
                    }
                }
            },
            new OrdenEntrega { IdOrdenEntrega = "OS015", FechaEmision = DateTime.Parse("2024-03-10"), FechaEstado = DateTime.Parse("2024-03-14"), Estado = "Preparada",
                OrdenesPreparacion = new List<OrdenPreparacion>
                {
                    new OrdenPreparacion
                    {
                        IdOrden = "OP021",
                        IdCliente = "CL006",
                        Transportista = "TR015",
                        FechaEstado = DateTime.Parse("2024-03-14")
                    }
                }
            }
        };

        public List<OrdenEntrega> ObtenerOrdenesEntrega()
        {
            return OrdenesEntregadas;
        }
    }
}
