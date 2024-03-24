using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3Ejercicio1
{
    internal class TipoCambio
    {
        public static decimal TipoCambioUSD { get; set; }

        public static void ModificarTipoCambio(decimal nuevoTipoCambio)
        {
            TipoCambioUSD = nuevoTipoCambio;
        }
    }
}
