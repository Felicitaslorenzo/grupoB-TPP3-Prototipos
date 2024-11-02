using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal class InventarioMercaderiaAlmacen
    {
        private static List<InventarioMercaderiaEnt> inventariomercaderias = new List<InventarioMercaderiaEnt>();

        public static IReadOnlyCollection<InventarioMercaderiaEnt> InventarioMercaderias => inventariomercaderias.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(inventariomercaderias);
            File.WriteAllText("InventarioMercaderias.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("InventarioMercaderias.json"))
            {
                return;
            }
            var datos = File.ReadAllText("InventarioMercaderias.json");

            inventariomercaderias = JsonSerializer.Deserialize<List<InventarioMercaderiaEnt>>(datos)!;

        }
    }
}
