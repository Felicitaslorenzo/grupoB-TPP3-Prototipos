using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal static class ClienteAlmacen
    {

        private static List<ClienteEnt> clientes = new List<ClienteEnt>();

        public static IReadOnlyCollection<ClienteEnt> Clientes => clientes.AsReadOnly();

        public static void Grabar()
        {            
            var datos = JsonSerializer.Serialize(clientes);
            File.WriteAllText(@"Datos\Clientes.json",datos);
        }

        public static void Leer()
        {
            if(!File.Exists(@"Datos\Clientes.json"))
            {
                return;
            }
            var datos = File.ReadAllText(@"Datos\Clientes.json");

            clientes = JsonSerializer.Deserialize<List<ClienteEnt>>(datos)!;

        }
    }
}
