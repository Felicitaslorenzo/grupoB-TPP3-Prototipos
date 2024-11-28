using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal static class OrdenSeleccionAlmacen
    {

        private static List<OrdenSeleccionEnt> ordenesseleccion = new List<OrdenSeleccionEnt>();

        public static IReadOnlyCollection<OrdenSeleccionEnt> OrdenesSeleccion => ordenesseleccion.AsReadOnly();

        public static void AgregarOrdenSeleccion(OrdenSeleccionEnt nuevaOrden)
        {
            ordenesseleccion.Add(nuevaOrden);
            /*try
            {
                string filePath = @"Datos\OrdenesSeleccion.json"; // Asegúrate de que esta ruta sea correcta
                string json = JsonSerializer.Serialize(ordenesseleccion, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir en el archivo JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            // Grabar();
        }
        public static void Grabar()
        {            
            var datos = JsonSerializer.Serialize(ordenesseleccion);
            File.WriteAllText(@"Datos\OrdenesSeleccion.json", datos);
        }

        public static void Leer()
        {
            if(!File.Exists(@"Datos\OrdenesSeleccion.json"))
            {
                return;
            }
            var datos = File.ReadAllText(@"Datos\OrdenesSeleccion.json");

            ordenesseleccion = JsonSerializer.Deserialize<List<OrdenSeleccionEnt>>(datos)!;
        }
        /*
        public static void AgregarOrdenSeleccion(OrdenSeleccionEnt ordenesseleccion)
        {
            ordenesseleccion.Add(ordenesseleccion);
        }*/
    }
}
