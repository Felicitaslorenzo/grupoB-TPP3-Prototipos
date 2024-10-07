using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.GenerarOrdenPreparacion
{
    internal class OrdenPreparacion
    {
        public string IDOrdenPreparacion { get; set; }
        
        public List<Cliente> Clientes { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
