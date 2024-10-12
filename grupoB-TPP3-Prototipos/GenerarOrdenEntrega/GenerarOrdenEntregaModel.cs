using System;
using System.Collections.Generic;
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
