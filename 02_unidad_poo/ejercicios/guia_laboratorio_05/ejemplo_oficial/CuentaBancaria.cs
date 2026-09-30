using System;

namespace SistemaBancario
{
    public class CuentaBancaria
    {
        // Miembros Estáticos
        private static int contadorCuentas = 0;
        private static decimal tasaMantenimientoGlobal = 500.00m;

        // Propiedades Autoimplementadas (Miembros de Instancia)
        public string NumeroCuenta { get; }
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }

        // Constructor
        public CuentaBancaria(string titular, decimal saldoInicial)
        {
            contadorCuentas++;
            // Generar correlativo de cuenta automático
            NumeroCuenta = "CTA-" + 202600 + contadorCuentas;
            Titular = titular;
            Saldo = saldoInicial;
        }

        // Métodos de Instancia (Comportamiento)
        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                Saldo += monto;
                Console.WriteLine($"Depósito exitoso. Nuevo Saldo: ${Saldo}");
            }
        }

        public bool Retirar(decimal monto)
        {
            if (monto > 0 && monto <= Saldo)
            {
                Saldo -= monto;
                Console.WriteLine($"Retiro exitoso. Nuevo Saldo: ${Saldo}");
                return true;
            }
            Console.WriteLine("Fondos insuficientes o monto inválido.");
            return false;
        }

        // Método Estático (De clase)
        public static int ObtenerCantidadCuentas()
        {
            return contadorCuentas;
        }
    }
}
