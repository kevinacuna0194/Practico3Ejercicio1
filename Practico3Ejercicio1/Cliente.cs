using Practico3Ejercicio1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3Ejercicio1
{
    internal class Cliente : IValidar
    {

        private static int _idCliente = 1;
        private int _id;
        private string? _nombreCompleto;
        private string? _documentoIdentidad;
        private CuentaBancaria _cuenta;

        internal Cliente(string nombreCompleto, string documentoIdentidad, CuentaBancaria cuenta)
        {
            _id = Cliente._idCliente++;
            _nombreCompleto = nombreCompleto;
            _documentoIdentidad = documentoIdentidad;
            _cuenta = cuenta;
        }

        public override string ToString()
        {
            string mensaje = $"ID: {_id} - ";
            mensaje += $"Nombre: {_nombreCompleto} - ";
            mensaje += $"CI: {_documentoIdentidad} - ";
            mensaje += $"{_cuenta}";

            return mensaje;
        }

        public void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
