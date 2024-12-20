﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupoB_TPP3_Prototipos.Almacenes
{
    internal class DepositoAlmacen
    {
        private static List<DepositoEnt> depositos = new List<DepositoEnt>();

        public static IReadOnlyCollection<DepositoEnt> Depositos => depositos.AsReadOnly();

        private static DepositoEnt? depositoActual;
        //TODO: Alguna pantalla tiene que darle al usuario la posibilidad de cambiar esto.
        //Por ahora (y hasta el final) lo dejamos hard-coded, y una vez que terminemos le agregamos
        //en la pantalla de menu principal la posibilidad de cambiar de deposito.
        public static DepositoEnt DepositoActual
        {
            get
            {
                // Usamos el campo privado para evitar recursión infinita
                if (depositoActual == null)
                {
                    depositoActual = depositos.FirstOrDefault(d => d.IdDeposito == "GBAS1");
                }
                return depositoActual!;
            }
            set
            {
                if (depositos.Contains(value))
                {
                    depositoActual = value;
                }
            }
        }

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(depositos);
            File.WriteAllText(@"Datos\Depositos.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists(@"Datos\Depositos.json"))
            {
                return;
            }
            var datos = File.ReadAllText(@"Datos\Depositos.json");

            depositos = JsonSerializer.Deserialize<List<DepositoEnt>>(datos)!;

        }
    }
}
