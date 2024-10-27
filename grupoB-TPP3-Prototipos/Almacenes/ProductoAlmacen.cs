using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal static class ProductoAlmacen
    {
        private static List<ProductoEntidad> productos = new List<ProductoEntidad>();

        public static IReadOnlyCollection<ProductoEntidad> Productos => productos.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(productos);
            File.WriteAllText("Productos.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("Productos.json"))
            {
                return;
            }
            var datos = File.ReadAllText("Productos.json");

            productos = JsonSerializer.Deserialize<List<ProductoEntidad>>(datos)!;

        }

    }
}
