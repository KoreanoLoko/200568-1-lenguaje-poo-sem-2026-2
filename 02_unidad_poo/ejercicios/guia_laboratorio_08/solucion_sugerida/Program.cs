using System;

namespace SimuladorCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialización de acumuladores locales para usar con 'ref'
            decimal montoTotalBanco = 0.0m;

            Console.WriteLine("=== SISTEMA DE SIMULACIÓN DE CRÉDITO SEMANA 4 ===\n");

            ProcesadorCredito procesador = new ProcesadorCredito();

            Console.Write("Ingrese Nombre del Cliente: ");
            procesador.NombreCliente = Console.ReadLine();

            Console.Write("Ingrese Sueldo Líquido Mensual ($): ");
            decimal sueldo = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese Monto Solicitado del Crédito ($): ");
            decimal monto = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese Cantidad de Cuotas (meses): ");
            int cuotas = Convert.ToInt32(Console.ReadLine());

            // Variables de salida para usar con 'out' (No requieren inicializarse aquí)
            decimal valorCuota;
            decimal interesGenerado;

            // Llamada al método con 'out'
            bool aprobado = procesador.EvaluarCredito(
                sueldo, monto, cuotas, out valorCuota, out interesGenerado);

            // Llamada al método con 'ref'
            if (aprobado)
            {
                procesador.RegistrarOperacionHistorica(ref montoTotalBanco, monto);
                Console.WriteLine("\n>>> RESULTADO: SIMULACIÓN APROBADA <<<");
                Console.WriteLine($"Cliente: {procesador.NombreCliente}");
                Console.WriteLine($"Cuota Mensual: ${valorCuota:N2}");
                Console.WriteLine($"Interés Total Cobrado: ${interesGenerado:N2}");
                Console.WriteLine($"Monto Total a Devolver: ${(monto + interesGenerado):N2}");
            }
            else
            {
                Console.WriteLine("\n>>> RESULTADO: SIMULACIÓN RECHAZADA <<<");
                Console.WriteLine("Motivo: El valor de la cuota mensual calculada supera el 30% del sueldo.");
                Console.WriteLine($"Cuota Estimada: ${valorCuota:N2} | Límite Máximo Permitido: ${sueldo * 0.30m:N2}");
            }

            Console.WriteLine($"\n[Control de Auditoría] Acumulado de Cartera Aprobada en el Banco: ${montoTotalBanco:N2}");
            Console.WriteLine("\nSimulación finalizada. Presione una tecla para salir.");
            Console.ReadKey();
        }
    }
}
