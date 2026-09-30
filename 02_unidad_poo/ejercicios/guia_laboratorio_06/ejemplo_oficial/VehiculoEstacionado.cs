using System;

namespace ControlEstacionamiento
{
    public class VehiculoEstacionado
    {
        // ----------------- MIEMBROS ESTÁTICOS (DE CLASE) -----------------
        private static decimal tarifaPorMinuto = 25.00m; // Sufijo 'm' para inicializar decimal
        private static decimal totalRecaudadoGlobal = 0.00m;
        private static int vehiculosEstacionadosActualmente = 0;

        // ----------------- MIEMBROS DE INSTANCIA -----------------
        public string Patente { get; }
        public int MinutosTranscurridos { get; private set; }
        public bool EstaPagado { get; private set; }

        // Constructor
        public VehiculoEstacionado(string patente)
        {
            Patente = patente.ToUpper();
            MinutosTranscurridos = 0;
            EstaPagado = false;

            // Incremento dinámico de variable estática global al nacer cada objeto en el Heap
            vehiculosEstacionadosActualmente++;
        }

        // Método de Instancia: paso del tiempo
        public void RegistrarPasoDelTiempo(int minutos)
        {
            if (minutos > 0)
            {
                MinutosTranscurridos += minutos;
                Console.WriteLine($"[Sede] Se han agregado {minutos} minutos a la patente {Patente}.");
            }
        }

        // Método de Instancia: egreso y cobro
        public decimal ProcesarSalida()
        {
            if (EstaPagado)
            {
                Console.WriteLine($"[Alerta] El vehículo {Patente} ya registra su cobro pagado.");
                return 0.00m;
            }

            decimal costoServicio = MinutosTranscurridos * tarifaPorMinuto;
            EstaPagado = true;

            // Manipulación de la memoria estática global
            vehiculosEstacionadosActualmente--;
            totalRecaudadoGlobal += costoServicio;

            return costoServicio;
        }

        public string ObtenerEstado()
        {
            string estado = EstaPagado ? "PAGADO" : "ACTIVO EN SEDE";
            return $"Patente: {Patente} | Tiempo: {MinutosTranscurridos} min | Estado: {estado}";
        }

        // ----------------- MÉTODOS ESTÁTICOS -----------------
        public static void ObtenerEstadisticasGlobales()
        {
            Console.WriteLine("\n=================== ESTADÍSTICAS GLOBALES SEDE ===================");
            Console.WriteLine($" Vehículos estacionados en este instante: {vehiculosEstacionadosActualmente}");
            Console.WriteLine($" Total acumulado en Caja Sede: ${totalRecaudadoGlobal:N2}");
            Console.WriteLine($" Tarifa de estacionamiento vigente: ${tarifaPorMinuto:N2} por minuto");
            Console.WriteLine("==================================================================\n");
        }
    }
}
