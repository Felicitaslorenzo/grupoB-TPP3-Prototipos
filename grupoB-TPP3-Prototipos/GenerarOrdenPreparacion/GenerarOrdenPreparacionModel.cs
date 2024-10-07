using grupoB_TPP3_Prototipos.ListarOrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
                Clientes = new List<Cliente>
                {
                    new Cliente { IdCliente = "CL001", Prioridad = "Con prioridad de entrega", Transportista = "T1" }
                },
                Productos = new List<Producto>
                {
                    new Producto { IDProducto = "SKU001", DescripcionProducto = "Café Arábica", Cantidad = 2, Ubicacion = "Estante 1" },
                    new Producto { IDProducto = "SKU002", DescripcionProducto = "Azúcar", Cantidad = 1, Ubicacion = "Estante 2" },
                    new Producto { IDProducto = "SKU003", DescripcionProducto = "Leche", Cantidad = 1, Ubicacion = "Refrigerador" },
                    new Producto { IDProducto = "SKU004", DescripcionProducto = "Tazas", Cantidad = 4, Ubicacion = "Almacén" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD002",
                Clientes = new List<Cliente>
                {
                    new Cliente { IdCliente = "CL002", Prioridad = "Sin prioridad", Transportista = "T2" }
                },
                Productos = new List<Producto>
                {
                    new Producto { IDProducto = "SKU005", DescripcionProducto = "Pastel de Chocolate", Cantidad = 3, Ubicacion = "Estante 3" },
                    new Producto { IDProducto = "SKU006", DescripcionProducto = "Pastel de Vainilla", Cantidad = 2, Ubicacion = "Estante 3" },
                    new Producto { IDProducto = "SKU007", DescripcionProducto = "Cajas para Pasteles", Cantidad = 5, Ubicacion = "Almacén" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD003",
                Clientes = new List<Cliente>
                {
                    new Cliente { IdCliente = "CL003", Prioridad = "Sin prioridad", Transportista = "T3" }
                },
                Productos = new List<Producto>
                {
                    new Producto { IDProducto = "SKU008", DescripcionProducto = "Manzanas", Cantidad = 10, Ubicacion = "Estante 4" },
                    new Producto { IDProducto = "SKU009", DescripcionProducto = "Bananas", Cantidad = 5, Ubicacion = "Estante 4" },
                    new Producto { IDProducto = "SKU010", DescripcionProducto = "Naranjas", Cantidad = 8, Ubicacion = "Estante 4" },
                    new Producto { IDProducto = "SKU011", DescripcionProducto = "Uvas", Cantidad = 3, Ubicacion = "Estante 4" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD004",
                Clientes = new List<Cliente>
                {
                    new Cliente { IdCliente = "CL004", Prioridad = "Con prioridad de entrega", Transportista = "T4" }
                },
                Productos = new List<Producto>
                {
                    new Producto { IDProducto = "SKU012", DescripcionProducto = "Zanahorias", Cantidad = 6, Ubicacion = "Estante 5" },
                    new Producto { IDProducto = "SKU013", DescripcionProducto = "Tomates", Cantidad = 4, Ubicacion = "Estante 5" },
                    new Producto { IDProducto = "SKU014", DescripcionProducto = "Lechugas", Cantidad = 2, Ubicacion = "Estante 5" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD005",
                Clientes = new List<Cliente>
                {
                    new Cliente { IdCliente = "CL005", Prioridad = "Sin prioridad", Transportista = "T5" }
                },
                Productos = new List<Producto>
                {
                    new Producto { IDProducto = "SKU015", DescripcionProducto = "Agua Mineral", Cantidad = 5, Ubicacion = "Estante 6" },
                    new Producto { IDProducto = "SKU016", DescripcionProducto = "Jugo de Naranja", Cantidad = 3, Ubicacion = "Refrigerador" },
                    new Producto { IDProducto = "SKU017", DescripcionProducto = "Cerveza", Cantidad = 12, Ubicacion = "Almacén" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD006",
                Clientes = new List<Cliente>
                {
                    new Cliente { IdCliente = "CL006", Prioridad = "Sin prioridad", Transportista = "T6" }
                },
                Productos = new List<Producto>
                {
                    new Producto { IDProducto = "SKU018", DescripcionProducto = "Papas Fritas", Cantidad = 4, Ubicacion = "Estante 7" },
                    new Producto { IDProducto = "SKU019", DescripcionProducto = "Galletas", Cantidad = 3, Ubicacion = "Estante 7" },
                    new Producto { IDProducto = "SKU020", DescripcionProducto = "Frutos Secos", Cantidad = 2, Ubicacion = "Estante 7" },
                    new Producto { IDProducto = "SKU021", DescripcionProducto = "Chocolate", Cantidad = 5, Ubicacion = "Estante 7" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD007",
                Clientes = new List<Cliente>
                {
                    new Cliente { IdCliente = "CL007", Prioridad = "Con prioridad de entrega", Transportista = "T7" }
                },
                Productos = new List<Producto>
                {
                    new Producto { IDProducto = "SKU022", DescripcionProducto = "Hamburguesas", Cantidad = 6, Ubicacion = "Refrigerador" },
                    new Producto { IDProducto = "SKU023", DescripcionProducto = "Panes de Hamburguesa", Cantidad = 6, Ubicacion = "Almacén" },
                    new Producto { IDProducto = "SKU024", DescripcionProducto = "Queso", Cantidad = 4, Ubicacion = "Refrigerador" },
                    new Producto { IDProducto = "SKU025", DescripcionProducto = "Salsas", Cantidad = 2, Ubicacion = "Almacén" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD008",
                Clientes = new List<Cliente>
                {
                    new Cliente { IdCliente = "CL008", Prioridad = "Sin prioridad", Transportista = "T8" }
                },
                Productos = new List<Producto>
                {
                    new Producto { IDProducto = "SKU026", DescripcionProducto = "Pollo", Cantidad = 3, Ubicacion = "Congelador" },
                    new Producto { IDProducto = "SKU027", DescripcionProducto = "Res", Cantidad = 2, Ubicacion = "Congelador" },
                    new Producto { IDProducto = "SKU028", DescripcionProducto = "Cerdo", Cantidad = 1, Ubicacion = "Congelador" },
                    new Producto { IDProducto = "SKU029", DescripcionProducto = "Salchichas", Cantidad = 10, Ubicacion = "Congelador" }
                }
            },
            new OrdenPreparacion
            {
                IDOrdenPreparacion = "ORD009",
                Clientes = new List<Cliente>
                {
                    new Cliente { IdCliente = "CL009", Prioridad = "Sin prioridad", Transportista = "T9" }
                },
                Productos = new List<Producto>
                {
                    new Producto { IDProducto = "SKU030", DescripcionProducto = "Leche", Cantidad = 5, Ubicacion = "Refrigerador" },
                    new Producto { IDProducto = "SKU031", DescripcionProducto = "Yogur", Cantidad = 6, Ubicacion = "Refrigerador" },
                    new Producto { IDProducto = "SKU032", DescripcionProducto = "Mantequilla", Cantidad = 3, Ubicacion = "Refrigerador" }
                }
            }

        };
        public (bool, string, string) BuscarProductoEnOrdenes(string idProducto)
        {
            foreach (var orden in ordenes)
            {
                foreach (var producto in orden.Productos)
                {
                    if (producto.IDProducto == idProducto)
                    {
                        return (true, producto.DescripcionProducto, producto.Ubicacion);
                    }
                }
            }
            return (false, string.Empty, string.Empty);
        }

        public string GenerarNuevaOrden(string idCliente, string prioridad, string transportista, ListView productosListView)
        {
            string nuevoIDOrden = GenerarNuevoIDOrden();

            List<Producto> productosOrden = new List<Producto>();
            foreach (ListViewItem productoItem in productosListView.Items)
            {
                productosOrden.Add(new Producto
                {
                    IDProducto = productoItem.SubItems[0].Text,
                    DescripcionProducto = productoItem.SubItems[1].Text,
                    Cantidad = int.Parse(productoItem.SubItems[2].Text),
                    Ubicacion = productoItem.SubItems[3].Text
                });
            }

            OrdenPreparacion nuevaOrden = new OrdenPreparacion
            {
                IDOrdenPreparacion = nuevoIDOrden,
                Clientes = new List<Cliente>
                {
                    new Cliente { IdCliente = idCliente, Prioridad = prioridad, Transportista = transportista }
                },
                Productos = productosOrden
            };

            ordenes.Add(nuevaOrden);

            return $"Orden {nuevoIDOrden} creada exitosamente.";
        }

        public bool CambiarCliente(ref List<Producto> productosOrden, string nuevoCliente)
        {
            if (productosOrden.Count > 0)
            {
                productosOrden.Clear();
                return true;
            }
            return false;
        }

        private string GenerarNuevoIDOrden()
        {
            int nuevoId = 1;
            if (ordenes.Count > 0)
            {
                var ultimaOrden = ordenes.Last();
                string ultimoIdOrden = ultimaOrden.IDOrdenPreparacion;
                nuevoId = int.Parse(ultimoIdOrden.Substring(3)) + 1;
            }
            return "ORD00" + nuevoId.ToString();
        }

        internal void CargarCliente(ComboBox IdClienteCombo, ComboBox TransportistaCombo, ComboBox ProductosCombo)
        {
            var clientes = ObtenerCliente();

            // Carga de los clientes en el ComboBox
            foreach (var cliente in clientes)
            {
                IdClienteCombo.Items.Add(cliente);
            }

            IdClienteCombo.DisplayMember = "IdCliente";

            // Evento cuando se selecciona un cliente
            IdClienteCombo.SelectedIndexChanged += (s, e) =>
            {
                if (IdClienteCombo.SelectedItem is Cliente selectedCliente)
                {
                    // Cargar transportistas y productos al seleccionar un cliente
                    CargarTransportistas(selectedCliente, TransportistaCombo);
                    CargarProductos(selectedCliente, ProductosCombo);
                }
            };
        }

        internal void CargarTransportistas(Cliente cliente, ComboBox TransportistaCombo)
        {
            // Limpia los transportistas anteriores
            TransportistaCombo.Items.Clear();

            // Agrega el transportista del cliente seleccionado
            TransportistaCombo.Items.Add(cliente.Transportista);
            TransportistaCombo.SelectedIndex = 0; // Selecciona el primer elemento automáticamente
        }

        internal void CargarProductos(Cliente cliente, ComboBox ProductosCombo)
        {
            // Limpia los productos anteriores
            ProductosCombo.Items.Clear();

            // Carga los productos devueltos por la función BuscarProductoCliente
            var productos = BuscarProductoCliente(cliente);
            foreach (var producto in productos)
            {
                ProductosCombo.Items.Add(producto);
            }

            ProductosCombo.DisplayMember = "IDProducto";
        }

        internal List<Producto> BuscarProductoCliente(Cliente cliente)
        {
            if (cliente.IdCliente == "CL001")
            {
                return new List<Producto> 
                {
                    new Producto { IDProducto = "SKU001", DescripcionProducto = "Ropa" },
                    new Producto { IDProducto = "SKU001", DescripcionProducto = "Mueble" },
                    new Producto { IDProducto = "SKU002", DescripcionProducto = "Electrodomestico" }
                };
            }
            else if (cliente.IdCliente == "CL002")
            {
                return new List<Producto>
                {
                    new Producto { IDProducto = "SKU001", DescripcionProducto = "Ropa" },
                    new Producto { IDProducto = "SKU004", DescripcionProducto = "Ladrillos" },
                    new Producto { IDProducto = "SKU005", DescripcionProducto = "Cemento" }
                };
            }
            else if (cliente.IdCliente == "CL003")
            {
                return new List<Producto>
                {
                    new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulo de decoración" },
                    new Producto { IDProducto = "SKU008", DescripcionProducto = "Ladrillos" },
                    new Producto { IDProducto = "SKU009", DescripcionProducto = "Cemento" }
                };
            }
            else if (cliente.IdCliente == "CL004")
            {
                return new List<Producto>
                {
                    new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulo de decoración" },
                    new Producto { IDProducto = "SKU010", DescripcionProducto = "Metales" },
                    new Producto { IDProducto = "SKU011", DescripcionProducto = "Producto farmacéutico" }
                };
            }
            else if (cliente.IdCliente == "CL005")
            {
                return new List<Producto>
                {
                    new Producto { IDProducto = "SKU011", DescripcionProducto = "Producto farmacéutico" },
                    new Producto { IDProducto = "SKU012", DescripcionProducto = "Inventario de lujo" },
                    new Producto { IDProducto = "SKU013", DescripcionProducto = "Material sensible" }
                };
            }
            else if (cliente.IdCliente == "CL006")
            {
                return new List<Producto>
                {
                    new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulos de decoración" },
                    new Producto { IDProducto = "SKU010", DescripcionProducto = "Metales" },
                    new Producto { IDProducto = "SKU014", DescripcionProducto = "Dispositivo electronico" }
                };
            }
            else if (cliente.IdCliente == "CL007")
            {
                return new List<Producto>
                {
                    new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulos de decoración" },
                    new Producto { IDProducto = "SKU015", DescripcionProducto = "Maquinas" },
                    new Producto { IDProducto = "SKU016", DescripcionProducto = "Muebles" }
                };
            }
            else if (cliente.IdCliente == "CL008")
            {
                return new List<Producto>
                {
                    new Producto { IDProducto = "SKU017", DescripcionProducto = "Herramienta industrial" },
                    new Producto { IDProducto = "SKU018", DescripcionProducto = "Calzado" },
                    new Producto { IDProducto = "SKU019", DescripcionProducto = "Accesorio" }
                };
            }
            else if (cliente.IdCliente == "CL009")
            {
                return new List<Producto>
                {
                    new Producto { IDProducto = "SKU015", DescripcionProducto = "Maquinas" },
                    new Producto { IDProducto = "SKU016", DescripcionProducto = "Muebles" }
                };
            }
            else
            {
                return new List<Producto>(); // Devuelve lista vacía si no coincide
            }
        }

        public List<Cliente> ObtenerCliente()
        {
            return new List<Cliente>
    {
        new Cliente { IdCliente = "CL001", Transportista = "TR001" },
        new Cliente { IdCliente = "CL002", Transportista = "TR002" },
        new Cliente { IdCliente = "CL003", Transportista = "TR003" },
        new Cliente { IdCliente = "CL004", Transportista = "TR004" },
    };
        }


    }
}





