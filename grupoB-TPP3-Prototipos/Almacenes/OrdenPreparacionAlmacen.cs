using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal static class OrdenPreparacionAlmacen
    {

        private static List<OrdenPreparacionEnt> ordenespreparacion = new List<OrdenPreparacionEnt>();

        public static IReadOnlyCollection<OrdenPreparacionEnt> OrdenesPreparacion => ordenespreparacion.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(ordenespreparacion);
            File.WriteAllText(@"Datos\OrdenesPreparacion.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists(@"Datos\OrdenesPreparacion.json"))
            {
                return;
            }
            var datos = File.ReadAllText(@"Datos\OrdenesPreparacion.json");

            // Deserializa el JSON usando las opciones configuradas
            ordenespreparacion = JsonSerializer.Deserialize<List<OrdenPreparacionEnt>>(datos)!;
        }
    }
}