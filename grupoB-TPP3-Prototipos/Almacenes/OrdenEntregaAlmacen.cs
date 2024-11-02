using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal static class OrdenEntregaAlmacen
    {

        private static List<OrdenEntregaEnt> ordenesentrega = new List<OrdenEntregaEnt>();

        public static IReadOnlyCollection<OrdenEntregaEnt> OrdenesEntrega => ordenesentrega.AsReadOnly();

        public static void Grabar()
        {            
            var datos = JsonSerializer.Serialize(ordenesentrega);
            File.WriteAllText("OrdenesEntrega.json",datos);
        }

        public static void Leer()
        {
            if(!File.Exists("OrdenesEntrega.json"))
            {
                return;
            }
            var datos = File.ReadAllText("OrdenesEntrega.json");

            ordenesentrega = JsonSerializer.Deserialize<List<OrdenEntregaEnt>>(datos)!;

        }
    }
}
