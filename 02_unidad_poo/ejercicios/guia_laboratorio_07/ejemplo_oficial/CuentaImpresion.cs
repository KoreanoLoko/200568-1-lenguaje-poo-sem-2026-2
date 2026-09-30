using System;

namespace ImpresionesSede
{
    public class CuentaImpresion
    {
        public string Estudiante { get; set; }
        public decimal Saldo { get; private set; }
        public string TipoCuenta { get; }

        // Constructor Sobrecargado 1: Inicialización con saldo por defecto de la sede ($1,000)
        public CuentaImpresion(string estudiante) : this(estudiante, 1000.00m, "Estándar")
        {
        }

        // Constructor Sobrecargado 2: Inicialización con saldo personalizado
        public CuentaImpresion(string estudiante, decimal saldoInicial) : this(estudiante, saldoInicial, "Preferencial")
        {
        }

        // Constructor Principal (Privado para control del negocio)
        private CuentaImpresion(string estudiante, decimal saldo, string tipo)
        {
            Estudiante = estudiante.ToUpper();
            Saldo = saldo;
            TipoCuenta = tipo;
        }

        // Método Transaccional Avanzado (Uso de ref y out)
        public bool ProcesarImpresion(int paginasSolicitadas, ref decimal tarjetaSaldo, out int paginasImpresas, out decimal costoTotal)
        {
            decimal costoPorPagina = 40.00m;
            costoTotal = paginasSolicitadas * costoPorPagina; // out obligatorio 1

            if (tarjetaSaldo >= costoTotal)
            {
                tarjetaSaldo -= costoTotal; // Se descuenta físicamente vía ref
                Saldo = tarjetaSaldo; // Sincroniza el saldo interno del objeto
                paginasImpresas = paginasSolicitadas; // out obligatorio 2
                return true;
            }
            else
            {
                paginasImpresas = 0; // out obligatorio incluso en falla
                return false;
            }
        }
    }
}
