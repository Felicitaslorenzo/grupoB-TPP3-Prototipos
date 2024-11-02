using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal static class OrdenPreparacionAlmacen
    {

        private static List<OrdenPreparacionEnt> ordenespreparacion = new List<OrdenPreparacionEnt>();

        public static IReadOnlyCollection<OrdenPreparacionEnt> OrdenesPreparacion => ordenespreparacion.AsReadOnly();

        public static void Grabar()
        {            
            var datos = JsonSerializer.Serialize(ordenespreparacion);
            File.WriteAllText("OrdenesPreparacion.json",datos);
        }

        public static void Leer()
        {
            if(!File.Exists("OrdenesPreparacion.json"))
            {
                return;
            }
            var datos = File.ReadAllText("OrdenesPreparacion.json");

            ordenespreparacion = JsonSerializer.Deserialize<List<OrdenPreparacionEnt>>(datos)!;

        }
    }
}
