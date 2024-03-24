using Practico3Ejercicio1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practico3Ejercicio1
{
    internal class CuentaBancaria : IValidar
    {
        private int _numeroCuenta;
        private TipoMoneda _tipoMoneda;
        private decimal _saldo;
        private decimal _tipoCambioUSD;

        public CuentaBancaria(int numeroCuenta, TipoMoneda tipoMoneda, decimal saldo, decimal tipoCambio)
        {
            _numeroCuenta = numeroCuenta;
            _tipoMoneda = tipoMoneda;
            _saldo = saldo;
            _tipoCambioUSD = tipoCambio;
        }

        public decimal ObtenerSaldoEnDolares()
        {
            if (_tipoMoneda == TipoMoneda.USD)
            {
                return _saldo;
            }
            else
            {
                return _saldo / _tipoCambioUSD;
            }
        }

        public void ModificarTipoCambio(decimal nuevoTipoCambio)
        {
            _tipoCambioUSD = nuevoTipoCambio;
        }

        public bool Retirar(decimal monto)
        {
            if (monto <= 0 || monto > _saldo)
            {
                return false;
            }

            _saldo -= monto;
            return true;
        }

        public bool Depositar(decimal monto)
        {
            if (monto <= 0 || monto > (_tipoMoneda == TipoMoneda.USD ? 1000 : 50000))
            {
                throw new Exception("No se puedo realizar Depósito. No supere los $ 50000 o U$S 1000. ");
            }

            _saldo += monto;
            return true;
        }

        internal int NumeroCuenta
        {
            get { return _numeroCuenta; }
            set { _numeroCuenta = value; }
        }

        public void Validar()
        {
            Console.WriteLine("Validando...");
        }

        internal void ValidarNumeroCuenta()
        {
            if (_numeroCuenta <= 0) throw new Exception("Numero de Cuenta Incorrecto");
        }

        public override string ToString()
        {
            string mensaje = $"Número de Cuenta: {_numeroCuenta} - ";
            mensaje += $"Tipo Moneda: {_tipoMoneda} - ";
            mensaje += $"Saldo: {_saldo} - ";
            mensaje += $"Tipo de Cambio USD: {_tipoCambioUSD}";

            return mensaje;
        }
    }


}
