using System;
using System.Collections.Generic;
using System.Text;

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
            this.NumeroCuenta = "CTA-" + 202600 + contadorCuentas;
            this.Titular = titular;
            this.Saldo = saldoInicial;
        }

        // Métodos de Instancia (Comportamiento)

        /// <summary>
        /// Deposita un monto en la cuenta bancaria.
        /// </summary>
        /// <param name="monto"></param>
        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                this.Saldo += monto;
                Console.WriteLine($"Depósito exitoso. Nuevo Saldo: ${Saldo}");
            }
        }

        /// <summary>
        /// Retira un monto de la cuenta bancaria si hay fondos suficientes.
        /// </summary>
        /// <param name="monto"></param>
        /// <returns></returns>
        public bool Retirar(decimal monto)
        {
            if (monto > 0 && monto <= this.Saldo)
            {
                this.Saldo -= monto;
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
