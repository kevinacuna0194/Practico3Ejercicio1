namespace Practico3Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso
            TipoCambio.ModificarTipoCambio(42.5m);

            CuentaBancaria cuenta = new CuentaBancaria(1234567890, TipoMoneda.UYU, 100000, TipoCambio.TipoCambioUSD);
            cuenta.Depositar(50000);
            cuenta.Retirar(30000);

            Cliente cliente = new Cliente("Kevin Acuña", "01234567", cuenta);

            Console.WriteLine(cliente.ToString());

            Console.WriteLine($"Saldo en Dólares: {cuenta.ObtenerSaldoEnDolares()} \n");

            CuentaBancaria cuenta2 = new CuentaBancaria(1234567890, TipoMoneda.USD, 500, TipoCambio.TipoCambioUSD);
            cuenta2.Depositar(300);
            cuenta2.Retirar(100);
            
            Cliente cliente2 = new Cliente("Agustin Acuña", "01234567", cuenta2);

            Console.WriteLine(cliente2.ToString());

            Console.WriteLine($"Saldo en Dólares: {cuenta2.ObtenerSaldoEnDolares()}");
        }
    }
}
