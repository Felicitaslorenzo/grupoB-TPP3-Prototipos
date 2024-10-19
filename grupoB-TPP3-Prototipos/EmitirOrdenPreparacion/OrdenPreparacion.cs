using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion
{
    internal class OrdenPreparacion
    {
        public string IDOrdenPreparacion { get; set; }
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Producto> Productos { get; set; } = new List<Producto>
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
        };
    }
}
