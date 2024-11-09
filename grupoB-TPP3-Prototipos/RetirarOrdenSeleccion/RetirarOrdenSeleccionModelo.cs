using grupoB_TPP3_Prototipos.Almacenes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.RetirarOrdenSeleccion
{
    internal class RetirarOrdenSeleccionModelo
    {
        public List<OrdenSeleccion> OrdenesSeleccionadas
        {
            get
            {
                // Lista que contendrá las ordenes seleccionadas
                var listarOrdenesSeleccion = new List<OrdenSeleccion>();

                // Recorrer todas las OrdenesSeleccion que estén pendientes.
                foreach (var ordenEntidad in OrdenSeleccionAlmacen.OrdenesSeleccion)
                {
                    var ordenModelo = new OrdenSeleccion();
                    ordenModelo.IdOrdenSeleccion = ordenEntidad.IdOrdenSeleccion;

                    /*
                        ORDEN SELECCION:
                        	-Orden prep 1
                                - Producto A...
                        		-Producto B
                            - Orden prep 2
                                - Producto A...
                        		-Producto B...
                        	-...n
                        
                        El TOTAL es de 120 remeras y 50 zapatillas. -- -
                        
                        Para cada producto ...
                        	Para cada ubicacion del producto....Retiro lo que me falta del producto o la cantidad que haya en la ubicacion y agrego un item a la lista de resultado.
                        
                            Sigo recorriendo ubicaciones hasta que haya retirado todo lo necesario.
                        
                        
                        
                        Devuelvo la lista de ubicaciones y cantidades que utilicé.
                        UBICACION A => SACA 100 Remeras
                        UBICACION B => SACA 20 Remeras
                        UBICACION C => SACA 50 Zapatillas*/


                    listarOrdenesSeleccion.Add(ordenModelo);
                }

                // Devolver la lista de ordenes seleccionadas con sus respectivas ordenes de preparación
                return listarOrdenesSeleccion;
            }
        }

        internal void Confirmar(string? idSeleccionado)
        {
            //TODO: impactar en inventario con los valores ya calculados.
        }
    }
}
