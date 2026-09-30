using System;

namespace ControlEstacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE ESTACIONAMIENTO - SEDE IPVG ===");

            // Instanciamos tres objetos independientes en el Heap de memoria
            VehiculoEstacionado auto1 = new VehiculoEstacionado("KCDD-54");
            VehiculoEstacionado auto2 = new VehiculoEstacionado("PJYT-89");
            VehiculoEstacionado auto3 = new VehiculoEstacionado("LKWQ-12");

            // Imprimimos el estado inicial global
            VehiculoEstacionado.ObtenerEstadisticasGlobales();

            Console.WriteLine("--- SIMULACIÓN DE FLUJO HORARIO ---");
            auto1.RegistrarPasoDelTiempo(45);  // Asiste a 1 bloque de clases
            auto2.RegistrarPasoDelTiempo(120); // Asiste a 3 bloques pedagógicos
            auto3.RegistrarPasoDelTiempo(15);  // Visita exprés para retirar credencial

            // Imprime estado particular del auto 2
            Console.WriteLine($"\nDetalle particular: {auto2.ObtenerEstado()}");

            // Procesamiento de salidas físicas de la sede
            Console.WriteLine("\n--- PROCESAMIENTO DE SALIDAS (PAGOS) ---");
            decimal pago1 = auto1.ProcesarSalida();
            Console.WriteLine($"[Boleta] Vehículo {auto1.Patente} pagó: ${pago1:N2}");

            decimal pago3 = auto3.ProcesarSalida();
            Console.WriteLine($"[Boleta] Vehículo {auto3.Patente} pagó: ${pago3:N2}");

            // Verificamos el impacto en el estado global estático
            VehiculoEstacionado.ObtenerEstadisticasGlobales();

            // Modificación de tiempo extra e intento de doble salida
            auto1.ProcesarSalida();

            auto2.RegistrarPasoDelTiempo(40);
            decimal pago2 = auto2.ProcesarSalida();
            Console.WriteLine($"[Boleta] Vehículo {auto2.Patente} pagó: ${pago2:N2}");

            // Cierre del día (0 activos)
            VehiculoEstacionado.ObtenerEstadisticasGlobales();

            Console.WriteLine("La simulación de estacionamiento ha finalizado con éxito.");
        }
    }
}
