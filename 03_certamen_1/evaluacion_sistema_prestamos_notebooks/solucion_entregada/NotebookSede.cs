using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrestamosNotebookIPVG
{
    internal class NotebookSede
    {
        private static int notebooksDisponiblesSede = 15;
        private static decimal montoMultasRecaudadas = 0.00m;

        public string Estudiante { get; private set; }
        public string IdentificadorNotebook { get; private set; }
        public int MinutosRetraso { get; private set; }

        public NotebookSede(string estudiante, string identificadorNotebook) : this(estudiante, identificadorNotebook, 0)
        {
            notebooksDisponiblesSede = notebooksDisponiblesSede - 1;
        }

        public NotebookSede(string estudiante, string identificadorNotebook, int minutosRetraso)
        {
            Estudiante = estudiante;
            IdentificadorNotebook = identificadorNotebook;
            MinutosRetraso = minutosRetraso;
        }

        public bool ProcesarDevolucion(int minutosRetraso, ref int stockSede, out decimal multaCalculada)
        {
            multaCalculada = 0.00m;

            if (minutosRetraso > 0)
            {
                multaCalculada = minutosRetraso * 120.00m;
            }

            stockSede = stockSede + 1;

            notebooksDisponiblesSede = stockSede;

            montoMultasRecaudadas = montoMultasRecaudadas + multaCalculada;

            return true;
        }

        public static void ObtenerEstadisticasGlobales()
        {
            Console.WriteLine("\n=== ESTADISTICAS DE LA SEDE ===");
            Console.WriteLine($"Notebooks disponibles: {notebooksDisponiblesSede}");
            Console.WriteLine($"Monto de multas recaudadas: ${montoMultasRecaudadas}");
        }
    }
}
