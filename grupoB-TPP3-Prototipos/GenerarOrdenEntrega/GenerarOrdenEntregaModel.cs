using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.GenerarOrdenEntrega
{
    internal class GenerarOrdenEntregaModel
    {
        public List<OrdenEntrega> ordenesEntrega = new List<OrdenEntrega>
        {
            new OrdenEntrega()
        };
        private List<OrdenPreparacion> ordenesPreparacion;
        

        public OrdenPreparacion ObtenerOrdenPorFechaActual()
        {
            // Obtener la fecha actual sin la parte de la hora
            DateTime fechaActual = DateTime.Today;

            // Buscar una orden cuya FechaEntrega coincida con la fecha actual
            var orden = ObtenerOrdenesPreparacion().FirstOrDefault(o => o.FechaEntrega.Date == fechaActual);

            // Retornar la orden encontrada (o null si no hay ninguna)
            return orden;
        }



        private string GenerarIdOrden()
        {
            int id = 1;
            if(ordenesEntrega.Count > 0)
            {
                var idexistente = ordenesEntrega
                .Where(o => o != null && o.IdOdenEntrega != null && o.IdOdenEntrega.Length >= 6) // Verificar que el objeto y la propiedad no sean nulos
                .Select(o => int.Parse(o.IdOdenEntrega.Substring(3))) // Obtener solo la parte numérica
                .ToList();

                // Verificar si hay IDs existentes y calcular el nuevo ID
                if(idexistente.Count > 0)
                {
                    id=idexistente.Max() + 1;
                }
            }
            return "OE" + id;


        }
        public string GenerarNuevaOrden()
        {
            string idorden = GenerarIdOrden();

            OrdenEntrega ordennueva = new OrdenEntrega();
            
            return "a";
        }
    }
}



