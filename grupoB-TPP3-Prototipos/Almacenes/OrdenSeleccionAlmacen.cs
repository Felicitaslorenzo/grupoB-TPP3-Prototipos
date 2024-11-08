using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal static class OrdenSeleccionAlmacen
    {

        private static List<OrdenSeleccionEnt> ordenesseleccion = new List<OrdenSeleccionEnt>();

        public static IReadOnlyCollection<OrdenSeleccionEnt> OrdenesSeleccion => ordenesseleccion.AsReadOnly();

        public static void Grabar()
        {            
            var datos = JsonSerializer.Serialize(ordenesseleccion);
            File.WriteAllText("OrdenesSeleccion.json",datos);
        }

        public static void Leer()
        {
            if(!File.Exists(@"OrdenesSeleccion.json"))
            {
                return;
            }
            var datos = File.ReadAllText("OrdenesSeleccion.json");

            ordenesseleccion = JsonSerializer.Deserialize<List<OrdenSeleccionEnt>>(datos)!;

        }
    }
}
