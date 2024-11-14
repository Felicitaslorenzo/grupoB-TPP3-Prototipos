using grupoB_TPP3_Prototipos.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace grupoB_TPP3_Prototipos.DespacharOrdenEntrega
{
    internal class DespacharOrdenEntregaModel
    {
        private List<Cliente> clientes;
        private List<OrdenEntrega> ordenesEntrega;

        public DespacharOrdenEntregaModel()
        {
            clientes = ObtenerClientes();
            // ordenesEntrega = ObtenerOrdenesEntrega();
        }

        public List<string> ObtenerTransportistas()
        {
            // Filtra las órdenes de preparación que tienen transportistas asignados y están en estado "Preparada", y cuya fecha de entrega sea hoy
            var depositoActual = DepositoAlmacen.DepositoActual.IdDeposito;

            var transportistas = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(o => !string.IsNullOrEmpty(o.IdTransportista)
                    && o.IdDeposito == depositoActual
                    && o.Estado == EstadoOrdenPrepEnum.Preparada
                    && o.FechaEntrega.Date == DateTime.Now.Date)  // Filtrar por fecha de entrega (hoy)
                .Select(o => o.IdTransportista)    // Extrae el ID del transportista
                .Distinct()                        // Elimina duplicados
                .ToList();                         // Convierte a lista

            return transportistas;

            // return clientes.SelectMany(c => c.Transportistas).Distinct().ToList();
        }

        /* public string ObtenerClientePorTransportista(string idTransportista)
        {
            var cliente = clientes.FirstOrDefault(c => c.Transportistas.Contains(idTransportista));
            return cliente?.IdCliente; 
        } */

        public List<Cliente> ObtenerClientes()
        {
            var listarClientes = new List<Cliente>();

            foreach (var ordenCliente in ClienteAlmacen.Clientes)
            {
                // Crear una nueva instancia de Cliente
                var ordenModelo = new Cliente
                {
                    IdCliente = ordenCliente.IdCliente,
                    // Asumiendo que Cliente tiene una propiedad llamada Transportistas que es una lista de enteros (IdTransportista)
                    Transportistas = TransportistaAlmacen.Transportistas
                        .Where(t => t.IdCliente == ordenCliente.IdCliente)
                        .Select(t => t.IdTransportista)
                        .ToList()
                };

                // Agregar el cliente con sus transportistas a la lista
                listarClientes.Add(ordenModelo);
            }

            // Devolver la lista de clientes con sus respectivos transportistas
            return listarClientes;
        }

        public List<OrdenEntrega> ObtenerOrdenesEntregaPorTransportista(string transportista)
        {
            // Obtener las órdenes de preparación desde el almacén (como una lista de OrdenPreparacionEnt)
            var ordenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(o => o.IdTransportista == transportista && (int)o.Estado == 4)  // Filtrar por transportista y estado 4 (Preparada)
                .ToList();

            // Convertir la lista de OrdenPreparacionEnt en una lista de OrdenEntrega
            List<OrdenEntrega> ordenesEntrega = new List<OrdenEntrega>();

            foreach (var ordenPrep in ordenesPreparacion)
            {
                // Mapear cada OrdenPreparacionEnt a una OrdenEntrega
                OrdenEntrega orden = new OrdenEntrega(
                    ordenPrep.IdOrdenPreparacion,  // idOrden
                    ordenPrep.IdCliente.ToString(), // idCliente (convertido a string si es necesario)
                    ordenPrep.Estado.ToString()    // estado (convertido a string desde Enum)
                );

                // Agregar la nueva orden a la lista
                ordenesEntrega.Add(orden);
            }

            return ordenesEntrega;
        }

        public string GenerarNuevoIDRemito()
        {
            // Obtener el último ID de las órdenes
            var ultimoId = RemitoAlmacen.Remitos
                .Select(o => o.IdRemito)
                .OrderByDescending(id => id)
                .FirstOrDefault();

            // Si no existe ninguna orden, empezamos con "RM001"
            if (string.IsNullOrEmpty(ultimoId))
            {
                return "RM-001";
            }

            // Extraemos el número al final del ID, en el formato "RM###"
            var numero = int.Parse(ultimoId.Substring(3));  // Asumimos que el ID tiene el formato "RM###" (después de "RM")

            // Incrementamos el número
            numero++;

            // Generamos el nuevo ID en el formato "RM###"
            var nuevoIDRemito = $"RM-{numero:D3}";  // El ":D3" asegura que el número tenga 3 dígitos, por ejemplo "RM002"

            // Grabar cambios en el archivo JSON
            RemitoAlmacen.Grabar();

            return nuevoIDRemito;
        }

        /*
       public List<OrdenEntrega> ObtenerOrdenesEntrega()
       {
           var listarOrden = new List<OrdenEntrega>();

           foreach (var ordenEntidad in OrdenPreparacionAlmacen.OrdenesPreparacion)
           {
               // Filtrar por fecha de entrega (hoy)
               if (ordenEntidad.FechaEntrega.Date != DateTime.Now.Date)
                   continue; // Solo agregamos las órdenes cuya fecha de entrega sea hoy

               var idCliente = ClienteAlmacen.Clientes
                   .Where(c => c.IdCliente == ordenEntidad.IdCliente)
                   .Select(c => c.IdCliente)
                   .FirstOrDefault();

               var estado = ordenEntidad.Estado.ToString();

               var ordenModelo = new OrdenEntrega(
                   ordenEntidad.IdOrdenPreparacion,
                   idCliente,
                   estado
               );

               listarOrden.Add(ordenModelo);
           }

           return listarOrden;
       }

       /* public List<OrdenEntrega> ObtenerOrdenesEntregaPorCliente(string idCliente)
       {
           return ordenesEntrega.Where(o => o.IdCliente == idCliente).ToList();
       } */

    }
}
