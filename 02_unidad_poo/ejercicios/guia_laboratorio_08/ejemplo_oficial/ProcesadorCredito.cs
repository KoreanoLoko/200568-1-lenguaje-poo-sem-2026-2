using System;

namespace SimuladorCredito
{
    public class ProcesadorCredito
    {
        // Propiedad autoimplementada
        public string NombreCliente { get; set; }

        // 1. Método con parámetros por VALOR
        public decimal CalcularInteresSimple(decimal capital, decimal tasaAnual, int meses)
        {
            // capital, tasaAnual y meses se copian por valor
            decimal interesFraction = tasaAnual / 100 / 12;
            return capital * interesFraction * meses;
        }

        // 2. Método utilizando el parámetro 'ref' para mantener saldo histórico
        public void RegistrarOperacionHistorica(ref decimal acumuladorSaldos, decimal nuevoMonto)
        {
            // ref requiere que el acumuladorSaldos esté inicializado fuera del método
            acumuladorSaldos += nuevoMonto;
        }

        // 3. Método utilizando 'out' para retornar múltiples valores (aprobación y desglose)
        public bool EvaluarCredito(
            decimal sueldoCliente,
            decimal montoSolicitado,
            int cuotas,
            out decimal valorCuotaBase,
            out decimal interesTotal)
        {
            // OBLIGATORIO: Asignar valores a los parámetros out antes de salir
            decimal tasaSimulada = 1.8m; // 1.8% mensual fijo
            interesTotal = montoSolicitado * (tasaSimulada / 100) * cuotas;
            decimal totalAPagar = montoSolicitado + interesTotal;
            valorCuotaBase = totalAPagar / cuotas;

            // Regla de aprobación organizacional: Cuota no debe exceder el 30% del sueldo
            decimal limiteCuota = sueldoCliente * 0.30m;
            return valorCuotaBase <= limiteCuota;
        }
    }
}
