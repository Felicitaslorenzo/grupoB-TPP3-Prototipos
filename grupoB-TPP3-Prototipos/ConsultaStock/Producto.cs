using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.ConsultaStock
{
    internal class Producto
    {
        public string SKUProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string IdCliente { get; set; }
        public int TotalCantidad { get; set; }
        public int TotalComprometido { get; set; }
        public new List<Inventario> Inventario { get; set; }
    }
}
