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
            File.WriteAllText(@"Datos\OrdenesEntrega.json", datos);
        }

        public static void AgregarOrdenEntrega(OrdenEntregaEnt nuevaOrden)
        {
            ordenesentrega.Add(nuevaOrden);
            Grabar();
        }

        public static void Leer()
        {
            if(!File.Exists(@"Datos\OrdenesEntrega.json"))
            {
                return;
            }
            var datos = File.ReadAllText(@"Datos\OrdenesEntrega.json");

            ordenesentrega = JsonSerializer.Deserialize<List<OrdenEntregaEnt>>(datos)!;

        }
    }
}
