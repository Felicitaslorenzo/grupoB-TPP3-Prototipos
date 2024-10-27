using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal class ProductoEntidad
    {

        public string IDProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }

        //public string IdCliente { get; set; } Ver si va o no

        //public string Ubicacion { get; set; } Ver si va o no
        //public override string ToString() => $"{IDProducto} - {DescripcionProducto}"; Ver si va o no

    }
}
