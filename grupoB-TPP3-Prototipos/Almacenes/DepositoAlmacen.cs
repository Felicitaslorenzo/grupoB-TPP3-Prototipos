using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal class DepositoAlmacen
    {
        private static List<DepositoEnt> depositos = new List<DepositoEnt>();

        public static IReadOnlyCollection<DepositoEnt> Depositos => depositos.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(depositos);
            File.WriteAllText(@"Datos\Depositos.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists(@"Datos\Depositos.json"))
            {
                return;
            }
            var datos = File.ReadAllText(@"Datos\Depositos.json");

            depositos = JsonSerializer.Deserialize<List<DepositoEnt>>(datos)!;

        }
    }
}
