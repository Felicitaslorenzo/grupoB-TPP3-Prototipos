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

        public static void AgregarOrdenPreparacion(OrdenPreparacionEnt nuevaOrden)
        {
            nuevaOrden.IdDeposito = DepositoAlmacen.DepositoActual.IdDeposito;
            ordenespreparacion.Add(nuevaOrden);
            /*
            try
            {
                string filePath = @"Datos\OrdenesPreparacion.json"; // Asegúrate de que esta ruta sea correcta
                string json = JsonSerializer.Serialize(ordenespreparacion, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
                Console.WriteLine("Escritura en JSON completada."); // Confirmación en consola
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje en caso de error
                MessageBox.Show($"Error al escribir en el archivo JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Excepción capturada: {ex}"); // Para detalles en consola o logs
            }
            */
            // Grabar();
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


        public static OrdenPreparacionEnt ObtenerOrdenPreparacion(string idOrdenPreparacion)
        {
            return ordenespreparacion.FirstOrDefault(op => op.IdOrdenPreparacion == idOrdenPreparacion);
        }
    }
}