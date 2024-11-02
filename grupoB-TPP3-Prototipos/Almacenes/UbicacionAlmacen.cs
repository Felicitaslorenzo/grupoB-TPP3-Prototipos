using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal class UbicacionAlmacen
    {
        private static List<UbicacionEnt> ubicaciones = new List<UbicacionEnt>();

        public static IReadOnlyCollection<UbicacionEnt> Ubicaciones => ubicaciones.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(ubicaciones);
            File.WriteAllText("Ubicaciones.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("Ubicaciones.json"))
            {
                return;
            }
            var datos = File.ReadAllText("Ubicaciones.json");

            ubicaciones = JsonSerializer.Deserialize<List<UbicacionEnt>>(datos)!;

        }
    }
}
