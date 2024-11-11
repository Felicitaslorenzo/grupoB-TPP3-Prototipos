using grupoB_TPP3_Prototipos.Almacenes;
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
        /* public List<OrdenPreparacion> ObtenerOrdenesPreparacion()
        {
            return ordenesPreparacion;
        } */


        //public List<OrdenPreparacion> ObtenerOrdenesPorFechaActual()
        //{
        // Obtener la fecha actual sin la parte de la hora
        //  DateTime fechaActual = DateTime.Today;

        // Filtrar todas las órdenes que coinciden con la fecha actual
        //  var ordenes = ObtenerOrdenesPreparacion().Where(o => o.FechaEntrega.Date == fechaActual).ToList();

        // Retornar la lista de órdenes encontradas (puede ser una lista vacía si no hay coincidencias)
        //   return ordenes;
        //    }

        public List<OrdenPreparacion> ObtenerOrdenesPorEstadoPreparada()
        {
            // Filtrar todas las órdenes que están en estado "Preparada" (Estado == 3)
            var ordenesAlmacen = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(o => (int)o.Estado == 3)  // Si Estado es un enum, conviértelo a int
                .ToList();

            // Crear una lista de OrdenPreparacion para devolver
            List<OrdenPreparacion> ordenesPreparacion = new List<OrdenPreparacion>();

            // Mapear cada OrdenPreparacionEnt a una OrdenPreparacion
            foreach (var ordenEntidad in ordenesAlmacen)
            {
                OrdenPreparacion orden = new OrdenPreparacion
                {
                    IdOrden = ordenEntidad.IdOrdenPreparacion,
                    IdCliente = ordenEntidad.IdCliente,
                    FechaEntrega = ordenEntidad.FechaEntrega,
                    Estado = ordenEntidad.Estado // Asegúrate de que el Estado sea compatible o lo conviertas adecuadamente
                };

                // Agregar la orden mapeada a la lista
                ordenesPreparacion.Add(orden);
            }

            // Devolver la lista de OrdenPreparacion
            return ordenesPreparacion;
        }


        public string GenerarNuevoIDOrden()
        {
            // Leer las órdenes desde el archivo (simulamos que ya tienes la lógica para leer desde un almacenamiento)
            OrdenEntregaAlmacen.Leer();

            // Obtener el último ID de las órdenes
            var ultimoId = OrdenEntregaAlmacen.OrdenesEntrega
                .Select(o => o.IdOrdenEntrega)
                .OrderByDescending(id => id)
                .FirstOrDefault();

            // Si no existe ninguna orden, empezamos con "OP-001"
            if (string.IsNullOrEmpty(ultimoId))
            {
                return "OE-001";
            }

            // Extraemos el número al final del ID, en el formato "OP-###"
            var numero = int.Parse(ultimoId.Substring(3));  // Asumimos que el ID tiene el formato "OP-###"

            // Incrementamos el número
            numero++;

            // Generamos el nuevo ID en el formato "OP-###"
            return $"OE-{numero:D3}";  // El ":D3" asegura que el número tenga 3 dígitos
        }
    }
}
