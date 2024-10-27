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

        private static List<ClienteEntidad> clientes = new List<ClienteEntidad>();

        public static IReadOnlyCollection<ClienteEntidad> Clientes => clientes.AsReadOnly();

        public static void Grabar()
        {            
            var datos = JsonSerializer.Serialize(clientes);
            File.WriteAllText("Clientes.json",datos);
        }

        public static void Leer()
        {
            if(!File.Exists("Clientes.json"))
            {
                return;
            }
            var datos = File.ReadAllText("Clientes.json");

            clientes = JsonSerializer.Deserialize<List<ClienteEntidad>>(datos)!;

        }
    }
}
