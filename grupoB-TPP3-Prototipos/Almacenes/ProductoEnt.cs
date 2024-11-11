using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal class ProductoEnt
    {

        public string SKUProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string IdCliente {  get; set; }
        public List<InventarioMercaderia> Inventario { get; set; } = new();
    
    //public override string ToString() => $"{IDProducto} - {DescripcionProducto}"; Ver si va o no

}
}
