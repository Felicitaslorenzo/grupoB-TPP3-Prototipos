using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal static class OrdenDePreparacionAlmacen
    {

        private static List<OrdenDePreparacionEnt> ordenespreparacion = new List<OrdenDePreparacionEnt>();

        public static IReadOnlyCollection<OrdenDePreparacionEnt> OrdenesPreparacion => ordenespreparacion.AsReadOnly();

        public static void Grabar()
        {            
            var datos = JsonSerializer.Serialize(ordenespreparacion);
            File.WriteAllText("OrdenesDePreparacion.json",datos);
        }

        public static void Leer()
        {
            if(!File.Exists("OrdenesDePreparacion.json"))
            {
                return;
            }
            var datos = File.ReadAllText("OrdenesDePreparacion.json");

            ordenespreparacion = JsonSerializer.Deserialize<List<OrdenDePreparacionEnt>>(datos)!;

        }
    }
}
