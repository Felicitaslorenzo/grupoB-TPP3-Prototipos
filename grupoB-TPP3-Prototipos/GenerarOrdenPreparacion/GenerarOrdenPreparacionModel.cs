using grupoB_TPP3_Prototipos.ListarOrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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
        Productos = new List<Producto>
        {
            new Producto { IDProducto = "SKU001", DescripcionProducto = "Ropa" },
            new Producto { IDProducto = "SKU002", DescripcionProducto = "Mueble" },
            new Producto { IDProducto = "SKU003", DescripcionProducto = "Electrodomestico" },
            new Producto { IDProducto = "SKU004", DescripcionProducto = "Ladrillos" },
            new Producto { IDProducto = "SKU005", DescripcionProducto = "Cemento" },
            new Producto { IDProducto = "SKU006", DescripcionProducto = "Herramienta" },
            new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulo de decoración" },
            new Producto { IDProducto = "SKU008", DescripcionProducto = "Electrodoméstico pequeño" },
            new Producto { IDProducto = "SKU009", DescripcionProducto = "Cocina" },
            new Producto { IDProducto = "SKU010", DescripcionProducto = "Metales" },
            new Producto { IDProducto = "SKU011", DescripcionProducto = "Producto farmacéutico" },
            new Producto { IDProducto = "SKU012", DescripcionProducto = "Inventario de lujo" },
            new Producto { IDProducto = "SKU013", DescripcionProducto = "Material sensible" },
            new Producto { IDProducto = "SKU014", DescripcionProducto = "Dispositivo electrónico" },
            new Producto { IDProducto = "SKU015", DescripcionProducto = "Máquinas" },
            new Producto { IDProducto = "SKU016", DescripcionProducto = "Muebles" },
            new Producto { IDProducto = "SKU017", DescripcionProducto = "Herramienta industrial" },
            new Producto { IDProducto = "SKU018", DescripcionProducto = "Calzado" },
            new Producto { IDProducto = "SKU019", DescripcionProducto = "Accesorio" },
            new Producto { IDProducto = "SKU020", DescripcionProducto = "Juguete" }
        }
    }
};

        public (bool, string) BuscarProductoEnOrdenes(string idProducto)
        {
            foreach (var orden in ordenes)
            {
                foreach (var producto in orden.Productos)
                {
                    if (producto.IDProducto == idProducto)
                    {
                        return (true, producto.DescripcionProducto); 
                    }
                }
            }
            return (false, string.Empty); 
        }

        public string GenerarNuevaOrden(string idCliente, string prioridad, string transportista, ListView productosListView)
        {
            string nuevoIDOrden = GenerarNuevoIDOrden();
            List<Producto> productosOrden = new List<Producto>();

            foreach (ListViewItem productoItem in productosListView.Items)
            {
                if (int.TryParse(productoItem.SubItems[2].Text, out int cantidad))
                {
                    productosOrden.Add(new Producto
                    {
                        IDProducto = productoItem.SubItems[0].Text,
                        DescripcionProducto = productoItem.SubItems[1].Text,
                        Cantidad = cantidad,
                        // Ubicacion = productoItem.SubItems[3].Text
                    });
                }
                else
                {
                    return $"Error: La cantidad para el producto {productoItem.SubItems[1].Text} no es válida.";
                }
            }

            OrdenPreparacion nuevaOrden = new OrdenPreparacion
            {
                IDOrdenPreparacion = nuevoIDOrden,
                Clientes = new List<Cliente>
        {
            new Cliente { IdCliente = idCliente, Prioridad = prioridad, Transportistas = new List<string> { transportista }}
        },
                Productos = productosOrden
            };

            ordenes.Add(nuevaOrden);
            return $"Orden {nuevoIDOrden} creada exitosamente.";
        }

        private string GenerarNuevoIDOrden()
        {
            int nuevoId = 1; 

            if (ordenes.Count > 0)
            {
                // obtener ID y convertir a int
                var idsExistentes = ordenes
                .Where(o => o != null && o.IDOrdenPreparacion != null && o.IDOrdenPreparacion.Length >= 6) // Verificar que el objeto y la propiedad no sean nulos
                .Select(o => int.Parse(o.IDOrdenPreparacion.Substring(3))) // Obtener solo la parte numérica
                .ToList();


                // Verificar si hay IDs existentes y calcular el nuevo ID
                if (idsExistentes.Count > 0)
                {
                    nuevoId = idsExistentes.Max() + 1; 
                }
            }

            
            return "OP" + nuevoId.ToString("D3"); 
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
            TransportistaCombo.Items.Clear();

            // Cargar todos los transportistas del cliente seleccionado
            foreach (var transportista in cliente.Transportistas)
            {
                TransportistaCombo.Items.Add(transportista);
            }

            // No establecer ninguna opción seleccionada, dejar el combo vacío
            TransportistaCombo.SelectedIndex = -1;
        }


        internal void CargarProductos(Cliente cliente, ComboBox ProductosCombo)
        {
            
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
            switch (cliente.IdCliente)
            {
                case "CL001":
                    return new List<Producto>
            {
                new Producto { IDProducto = "SKU001", DescripcionProducto = "Ropa" },
                new Producto { IDProducto = "SKU002", DescripcionProducto = "Mueble" },
                new Producto { IDProducto = "SKU003", DescripcionProducto = "Electrodomestico" },
                new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulo de decoración" },
            };

                case "CL002":
                    return new List<Producto>
            {
                new Producto { IDProducto = "SKU001", DescripcionProducto = "Ropa" },
                new Producto { IDProducto = "SKU004", DescripcionProducto = "Ladrillos" },
                new Producto { IDProducto = "SKU005", DescripcionProducto = "Cemento" }
            };

                case "CL003":
                    return new List<Producto>
            {
                new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulo de decoración" },
                new Producto { IDProducto = "SKU008", DescripcionProducto = "Ladrillos" },
                new Producto { IDProducto = "SKU009", DescripcionProducto = "Cemento" }
            };

                case "CL004":
                    return new List<Producto>
            {
                new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulo de decoración" },
                new Producto { IDProducto = "SKU010", DescripcionProducto = "Metales" },
                new Producto { IDProducto = "SKU011", DescripcionProducto = "Producto farmacéutico" }
            };

                case "CL005":
                    return new List<Producto>
            {
                new Producto { IDProducto = "SKU011", DescripcionProducto = "Producto farmacéutico" },
                new Producto { IDProducto = "SKU012", DescripcionProducto = "Inventario de lujo" },
                new Producto { IDProducto = "SKU013", DescripcionProducto = "Material sensible" }
            };

                case "CL006":
                    return new List<Producto>
            {
                new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulos de decoración" },
                new Producto { IDProducto = "SKU010", DescripcionProducto = "Metales" },
                new Producto { IDProducto = "SKU014", DescripcionProducto = "Dispositivo electronico" }
            };

                case "CL007":
                    return new List<Producto>
            {
                new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulos de decoración" },
                new Producto { IDProducto = "SKU015", DescripcionProducto = "Maquinas" },
                new Producto { IDProducto = "SKU016", DescripcionProducto = "Muebles" }
            };

                case "CL008":
                    return new List<Producto>
            {
                new Producto { IDProducto = "SKU017", DescripcionProducto = "Herramienta industrial" },
                new Producto { IDProducto = "SKU018", DescripcionProducto = "Calzado" },
                new Producto { IDProducto = "SKU019", DescripcionProducto = "Accesorio" }
            };

                case "CL009":
                    return new List<Producto>
            {
                new Producto { IDProducto = "SKU015", DescripcionProducto = "Maquinas" },
                new Producto { IDProducto = "SKU016", DescripcionProducto = "Muebles" }
            };

                case "CL010":
                    return new List<Producto>
            {
                new Producto { IDProducto = "SKU007", DescripcionProducto = "Articulos de decoración" },
                new Producto { IDProducto = "SKU018", DescripcionProducto = "Calzado" },
                new Producto { IDProducto = "SKU019", DescripcionProducto = "Accesorio" },
                new Producto { IDProducto = "SKU014", DescripcionProducto = "Dispositivo electronico" }
            };

                default:
                    return new List<Producto>();
            }
        }

        public List<Cliente> ObtenerCliente()
        {
            return new List<Cliente>
            {
                new Cliente { IdCliente = "CL001", Transportistas = new List<string> {"TR001", "TR002", "TR003", "CL001"}},
                new Cliente { IdCliente = "CL002", Transportistas = new List<string> {"TR004", "TR005", "CL002"}},
                new Cliente { IdCliente = "CL003", Transportistas = new List<string> {"TR006", "TR007", "CL003"}},
                new Cliente { IdCliente = "CL004", Transportistas = new List<string> {"TR008", "TR009", "TR010", "TR011", "CL004"}},
                new Cliente { IdCliente = "CL005", Transportistas = new List<string> {"TR012", "TR013", "CL005"}},
                new Cliente { IdCliente = "CL006", Transportistas = new List<string> {"TR014", "TR015", "CL006"}},
                new Cliente { IdCliente = "CL007", Transportistas = new List<string> {"TR016", "TR017", "CL007"}},
                new Cliente { IdCliente = "CL008", Transportistas = new List<string> {"TR018", "TR019", "CL008"}},
                new Cliente { IdCliente = "CL009", Transportistas = new List<string> {"TR020", "TR021", "CL009"}},
                new Cliente { IdCliente = "CL010", Transportistas = new List<string> {"TR022", "TR023", "CL010"}},
            };
        }
    }
}