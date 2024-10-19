using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.GenerarOrdenEntrega
{
    internal class EmitirOrdenEntregaModel
    {
        public List<OrdenEntrega> ordenesEntrega = new List<OrdenEntrega>
        {
            new OrdenEntrega()
        };
        // Lista de órdenes de preparación
        private List<OrdenPreparacion> ordenesPreparacion = new List<OrdenPreparacion>();

        // Método para obtener la lista de órdenes de preparación
        public List<OrdenPreparacion> ObtenerOrdenesPreparacion()
        {
            return ordenesPreparacion;
        }

        public List<OrdenPreparacion> ObtenerOrdenesPorFechaActual()
        {
            // Obtener la fecha actual sin la parte de la hora
            DateTime fechaActual = DateTime.Today;

            // Filtrar todas las órdenes que coinciden con la fecha actual
            var ordenes = ObtenerOrdenesPreparacion().Where(o => o.FechaEntrega.Date == fechaActual).ToList();

            // Retornar la lista de órdenes encontradas (puede ser una lista vacía si no hay coincidencias)
            return ordenes;
        }




        private string GenerarIdOrden()
        {
            int id = 1;
            if (ordenesEntrega.Count > 0)
            {
                var idexistente = ordenesEntrega
                .Where(o => o != null && o.IdOdenEntrega != null && o.IdOdenEntrega.Length >= 6) // Verificar que el objeto y la propiedad no sean nulos
                .Select(o => int.Parse(o.IdOdenEntrega.Substring(3))) // Obtener solo la parte numérica
                .ToList();

                // Verificar si hay IDs existentes y calcular el nuevo ID
                if (idexistente.Count > 0)
                {
                    id = idexistente.Max() + 1;
                }
            }
            return "OE" + id;


        }
        public string GenerarNuevaOrden()
        {
            string idorden = GenerarIdOrden();

            // Obtener las órdenes de preparación para la fecha de hoy
            var ordenesPreparacionHoy = ObtenerOrdenesPorFechaActual();

            if (ordenesPreparacionHoy.Count == 0)
            {
                return "No hay órdenes de preparación para la fecha actual.";
            }

            // Crear una nueva orden de entrega con las órdenes de preparación de hoy
            OrdenEntrega ordenNueva = new OrdenEntrega
            {
                IdOdenEntrega = idorden,
                OrdenesPreparacion = ordenesPreparacionHoy
            };

            // Agregar la nueva orden a la lista de órdenes de entrega
            ordenesEntrega.Add(ordenNueva);

            return $"Nueva orden de entrega generada con ID: {idorden}";
        }
    }
}
