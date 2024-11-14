using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal class RemitoAlmacen
    {
        private static List<RemitoEnt> remitos = new List<RemitoEnt>();

        public static IReadOnlyCollection<RemitoEnt> Remitos => remitos.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(remitos);
            File.WriteAllText(@"Datos\Remitos.json", datos);
        }

        public static void AgregarRemito(RemitoEnt nuevaOrden)
        {
            remitos.Add(nuevaOrden);
        }

        public static void Leer()
        {
            if (!File.Exists(@"Datos\Remitos.json"))
            {
                return;
            }
            var datos = File.ReadAllText(@"Datos\Remitos.json");

            remitos = JsonSerializer.Deserialize<List<RemitoEnt>>(datos)!;

        }
    }
}
