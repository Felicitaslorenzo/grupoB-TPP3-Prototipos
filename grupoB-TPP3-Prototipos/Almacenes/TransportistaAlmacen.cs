using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal static class TransportistaAlmacen
    {

        private static List<TransportistaEntidad> transportistas = new List<TransportistaEntidad>();

        public static IReadOnlyCollection<TransportistaEntidad> Transportistas => transportistas.AsReadOnly();

        public static void Grabar()
        {            
            var datos = JsonSerializer.Serialize(transportistas);
            File.WriteAllText("Transportistas.json",datos);
        }

        public static void Leer()
        {
            if(!File.Exists("Transportistas.json"))
            {
                return;
            }
            var datos = File.ReadAllText("Transportistas.json");

            transportistas = JsonSerializer.Deserialize<List<TransportistaEntidad>>(datos)!;

        }
    }
}
