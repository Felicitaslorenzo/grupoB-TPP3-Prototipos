using grupoB_TPP3_Prototipos.Almacenes;
using grupoB_TPP3_Prototipos.DespacharOrdenEntrega;
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
            // Filtrar todas las órdenes que están en estado "Empaquetada" (Estado == 3)
            var depositoActual = DepositoAlmacen.DepositoActual.IdDeposito;

            var ordenesAlmacen = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(o => (int)o.Estado == 3 && o.IdDeposito == depositoActual)  // Si Estado es un enum, conviértelo a int
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

        public void CambiarEstadoOrden(List<string> idsOrdenes)
        {
            foreach (var idOrden in idsOrdenes)
            {
                var ordenEntidad = OrdenPreparacionAlmacen.OrdenesPreparacion
                    .FirstOrDefault(o => o.IdOrdenPreparacion.ToString() == idOrden);
                if (ordenEntidad != null)
                {
                    ordenEntidad.Estado = EstadoOrdenPrepEnum.Seleccionada; // Cambiar el estado
                }
            }
        }

        public void GenerarNuevaOrdenEntrega(List<string> idsSeleccionados)
        {
            // Crear ID de la nueva OrdenEntrega
            string nuevoIdOrdenEntrega = GenerarNuevoIDOrden(); // Esto genera el nuevo ID de la orden de entrega

            // Crear la nueva OrdenEntrega
            OrdenEntrega nuevaOrdenEntrega = new OrdenEntrega
            {
                IdOrdenEntrega = nuevoIdOrdenEntrega, // Asignar el nuevo ID
                FechaEmision = DateTime.Now, // Fecha actual
                FechaEntrega = DateTime.Now, // Fecha de entrega
                OrdenesPreparacion = new List<OrdenPreparacion>() // Inicializar la lista de órdenes de preparación
            };

            // Obtener las órdenes de preparación completas basadas en los IDs seleccionados
            var ordenesPreparacionSeleccionadas = ObtenerOrdenesPorEstadoPreparada()
                .Where(op => idsSeleccionados.Contains(op.IdOrden.ToString()))  // Filtramos por los IDs seleccionados
                .ToList();

            // Verificar que se están obteniendo las órdenes completas
            if (ordenesPreparacionSeleccionadas.Any())
            {
                Console.WriteLine($"Se encontraron {ordenesPreparacionSeleccionadas.Count} órdenes de preparación seleccionadas.");
            }
            else
            {
                Console.WriteLine("No se encontraron órdenes de preparación seleccionadas.");
            }

            // Agregar las órdenes completas a la nueva OrdenEntrega
            nuevaOrdenEntrega.OrdenesPreparacion.AddRange(ordenesPreparacionSeleccionadas);

            // Verificar que las órdenes fueron agregadas correctamente
            if (nuevaOrdenEntrega.OrdenesPreparacion.Any())
            {
                Console.WriteLine($"Se agregaron {nuevaOrdenEntrega.OrdenesPreparacion.Count} órdenes de preparación a la nueva orden de entrega.");
            }

            OrdenEntregaEnt nuevaOrdenEntregaEnt = new OrdenEntregaEnt
            {
                IdOrdenEntrega = nuevaOrdenEntrega.IdOrdenEntrega,
                FechaEmision = nuevaOrdenEntrega.FechaEmision,
                FechaEntrega = nuevaOrdenEntrega.FechaEntrega,
                OrdenesPreparacion = nuevaOrdenEntrega.OrdenesPreparacion
        .Select(op => op.IdOrden.ToString())  // Convertir cada objeto OrdenPreparacion a su ID
        .ToList()  // Esto convertirá la lista de OrdenPreparacion a una lista de strings
            };


            // Guardar la nueva OrdenEntregaEnt en el almacenamiento
            OrdenEntregaAlmacen.AgregarOrdenEntrega(nuevaOrdenEntregaEnt);

            // (Opcional) Mostrar que la orden fue guardada
            Console.WriteLine($"Nueva orden de entrega generada y guardada: {nuevoIdOrdenEntrega}");
        }

    }
}
