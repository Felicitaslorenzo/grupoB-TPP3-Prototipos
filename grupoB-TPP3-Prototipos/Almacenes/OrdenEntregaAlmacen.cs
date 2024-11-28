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
            try
            {
                Directory.CreateDirectory("Datos");  // Crea el directorio si no existe
                var datos = JsonSerializer.Serialize(ordenesentrega, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(@"Datos\OrdenesEntrega.json", datos);
                Console.WriteLine("Archivo JSON de OrdenesEntrega guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Excepción capturada: {ex}"); // Para detalles en consola o logs
            }
        }

        public static void AgregarOrdenEntrega(OrdenEntregaEnt nuevaOrden)
        {
            ordenesentrega.Add(nuevaOrden);
            // Grabar();
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
