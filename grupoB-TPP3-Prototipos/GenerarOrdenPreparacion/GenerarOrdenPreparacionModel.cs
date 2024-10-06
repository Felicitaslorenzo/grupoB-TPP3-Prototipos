using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion
{
    internal class GenerarOrdenPreparacionModel
    {
        public List<OrdenPreparacion> ordenes = new List<OrdenPreparacion>
        {
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD001",
                Clientes = new List<Clientes>
                {
                    new Clientes { IdCliente = "CL001", Prioridad = "Con prioridad de entrega", Transportista = "T1" }
                },
                Productos = new List<ProductoOrden>
                {
                    new ProductoOrden { IDProducto = "SKU001", DescripcionProducto = "Café Arábica", Cantidad = 2, Ubicacion = "Estante 1" },
                    new ProductoOrden { IDProducto = "SKU002", DescripcionProducto = "Azúcar", Cantidad = 1, Ubicacion = "Estante 2" },
                    new ProductoOrden { IDProducto = "SKU003", DescripcionProducto = "Leche", Cantidad = 1, Ubicacion = "Refrigerador" },
                    new ProductoOrden { IDProducto = "SKU004", DescripcionProducto = "Tazas", Cantidad = 4, Ubicacion = "Almacén" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD002",
                Clientes = new List<Clientes>
                {
                    new Clientes { IdCliente = "CL002", Prioridad = "Sin prioridad", Transportista = "T2" }
                },
                Productos = new List<ProductoOrden>
                {
                    new ProductoOrden { IDProducto = "SKU005", DescripcionProducto = "Pastel de Chocolate", Cantidad = 3, Ubicacion = "Estante 3" },
                    new ProductoOrden { IDProducto = "SKU006", DescripcionProducto = "Pastel de Vainilla", Cantidad = 2, Ubicacion = "Estante 3" },
                    new ProductoOrden { IDProducto = "SKU007", DescripcionProducto = "Cajas para Pasteles", Cantidad = 5, Ubicacion = "Almacén" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD003",
                Clientes = new List<Clientes>
                {
                    new Clientes { IdCliente = "CL003", Prioridad = "Sin prioridad", Transportista = "T3" }
                },
                Productos = new List<ProductoOrden>
                {
                    new ProductoOrden { IDProducto = "SKU008", DescripcionProducto = "Manzanas", Cantidad = 10, Ubicacion = "Estante 4" },
                    new ProductoOrden { IDProducto = "SKU009", DescripcionProducto = "Bananas", Cantidad = 5, Ubicacion = "Estante 4" },
                    new ProductoOrden { IDProducto = "SKU010", DescripcionProducto = "Naranjas", Cantidad = 8, Ubicacion = "Estante 4" },
                    new ProductoOrden { IDProducto = "SKU011", DescripcionProducto = "Uvas", Cantidad = 3, Ubicacion = "Estante 4" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD004",
                Clientes = new List<Clientes>
                {
                    new Clientes { IdCliente = "CL004", Prioridad = "Con prioridad de entrega", Transportista = "T4" }
                },
                Productos = new List<ProductoOrden>
                {
                    new ProductoOrden { IDProducto = "SKU012", DescripcionProducto = "Zanahorias", Cantidad = 6, Ubicacion = "Estante 5" },
                    new ProductoOrden { IDProducto = "SKU013", DescripcionProducto = "Tomates", Cantidad = 4, Ubicacion = "Estante 5" },
                    new ProductoOrden { IDProducto = "SKU014", DescripcionProducto = "Lechugas", Cantidad = 2, Ubicacion = "Estante 5" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD005",
                Clientes = new List<Clientes>
                {
                    new Clientes { IdCliente = "CL005", Prioridad = "Sin prioridad", Transportista = "T5" }
                },
                Productos = new List<ProductoOrden>
                {
                    new ProductoOrden { IDProducto = "SKU015", DescripcionProducto = "Agua Mineral", Cantidad = 5, Ubicacion = "Estante 6" },
                    new ProductoOrden { IDProducto = "SKU016", DescripcionProducto = "Jugo de Naranja", Cantidad = 3, Ubicacion = "Refrigerador" },
                    new ProductoOrden { IDProducto = "SKU017", DescripcionProducto = "Cerveza", Cantidad = 12, Ubicacion = "Almacén" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD006",
                Clientes = new List<Clientes>
                {
                    new Clientes { IdCliente = "CL006", Prioridad = "Sin prioridad", Transportista = "T6" }
                },
                Productos = new List<ProductoOrden>
                {
                    new ProductoOrden { IDProducto = "SKU018", DescripcionProducto = "Papas Fritas", Cantidad = 4, Ubicacion = "Estante 7" },
                    new ProductoOrden { IDProducto = "SKU019", DescripcionProducto = "Galletas", Cantidad = 3, Ubicacion = "Estante 7" },
                    new ProductoOrden { IDProducto = "SKU020", DescripcionProducto = "Frutos Secos", Cantidad = 2, Ubicacion = "Estante 7" },
                    new ProductoOrden { IDProducto = "SKU021", DescripcionProducto = "Chocolate", Cantidad = 5, Ubicacion = "Estante 7" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD007",
                Clientes = new List<Clientes>
                {
                    new Clientes { IdCliente = "CL007", Prioridad = "Con prioridad de entrega", Transportista = "T7" }
                },
                Productos = new List<ProductoOrden>
                {
                    new ProductoOrden { IDProducto = "SKU022", DescripcionProducto = "Hamburguesas", Cantidad = 6, Ubicacion = "Refrigerador" },
                    new ProductoOrden { IDProducto = "SKU023", DescripcionProducto = "Panes de Hamburguesa", Cantidad = 6, Ubicacion = "Almacén" },
                    new ProductoOrden { IDProducto = "SKU024", DescripcionProducto = "Queso", Cantidad = 4, Ubicacion = "Refrigerador" },
                    new ProductoOrden { IDProducto = "SKU025", DescripcionProducto = "Salsas", Cantidad = 2, Ubicacion = "Almacén" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD008",
                Clientes = new List<Clientes>
                {
                    new Clientes { IdCliente = "CL008", Prioridad = "Sin prioridad", Transportista = "T8" }
                },
                Productos = new List<ProductoOrden>
                {
                    new ProductoOrden { IDProducto = "SKU026", DescripcionProducto = "Pollo", Cantidad = 3, Ubicacion = "Congelador" },
                    new ProductoOrden { IDProducto = "SKU027", DescripcionProducto = "Res", Cantidad = 2, Ubicacion = "Congelador" },
                    new ProductoOrden { IDProducto = "SKU028", DescripcionProducto = "Cerdo", Cantidad = 1, Ubicacion = "Congelador" },
                    new ProductoOrden { IDProducto = "SKU029", DescripcionProducto = "Salchichas", Cantidad = 10, Ubicacion = "Congelador" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD009",
                Clientes = new List<Clientes>
                {
                    new Clientes { IdCliente = "CL009", Prioridad = "Sin prioridad", Transportista = "T9" }
                },
                Productos = new List<ProductoOrden>
                {
                    new ProductoOrden { IDProducto = "SKU030", DescripcionProducto = "Leche", Cantidad = 5, Ubicacion = "Refrigerador" },
                    new ProductoOrden { IDProducto = "SKU031", DescripcionProducto = "Yogur", Cantidad = 6, Ubicacion = "Refrigerador" },
                    new ProductoOrden { IDProducto = "SKU032", DescripcionProducto = "Mantequilla", Cantidad = 3, Ubicacion = "Refrigerador" }
                }
            }
        };
    }
}
