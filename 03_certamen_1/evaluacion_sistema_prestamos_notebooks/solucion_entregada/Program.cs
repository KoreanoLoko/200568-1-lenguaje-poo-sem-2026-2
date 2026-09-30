namespace SistemaPrestamosNotebookIPVG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotebookSede prestamoNotebook = null;

            int opcion = 0;

            int stockSede = 15;

            do
            {
                Console.WriteLine("\n=== SISTEMA DE PRESTAMOS DE NOTEBOOKS IPVG ===");
                Console.WriteLine("1. Registrar nuevo prestamo de Notebook");
                Console.WriteLine("2. Procesar devolucion del Notebook");
                Console.WriteLine("3. Visualizar estadisticas del stock e ingreso");
                Console.WriteLine("4. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (prestamoNotebook == null)
                        {
                            if (stockSede > 0)
                            {
                                Console.Write("Ingrese nombre del estudiante: ");
                                string estudiante = Console.ReadLine();

                                Console.Write("Ingrese identificador del notebook: ");
                                string identificadorNotebook = Console.ReadLine();

                                prestamoNotebook = new NotebookSede(estudiante, identificadorNotebook);

                                stockSede = stockSede - 1;

                                Console.WriteLine("\nPrestamo registrado correctamente.");
                                Console.WriteLine($"Estudiante: {prestamoNotebook.Estudiante}");
                                Console.WriteLine($"Notebook: {prestamoNotebook.IdentificadorNotebook}");
                                Console.WriteLine($"Minutos de retraso: {prestamoNotebook.MinutosRetraso}");
                            }
                            else
                            {
                                Console.WriteLine("No hay notebooks disponibles.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ya existe un prestamo activo.");
                        }

                        break;

                    case 2:
                        if (prestamoNotebook != null)
                        {
                            Console.Write("Ingrese los minutos de retraso: ");
                            int minutosRetraso = Convert.ToInt32(Console.ReadLine());

                            string estudianteDevolucion = prestamoNotebook.Estudiante;
                            string notebookDevolucion = prestamoNotebook.IdentificadorNotebook;

                            prestamoNotebook = new NotebookSede(estudianteDevolucion, notebookDevolucion, minutosRetraso);

                            decimal multaCalculada;

                            bool exito = prestamoNotebook.ProcesarDevolucion(minutosRetraso, ref stockSede, out multaCalculada);

                            if (exito)
                            {
                                Console.WriteLine("\nDevolucion procesada correctamente.");
                                Console.WriteLine($"Multa calculada: ${multaCalculada}");
                                Console.WriteLine($"Stock actual de la sede: {stockSede}");

                                prestamoNotebook = null;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No existe un prestamo registrado.");
                        }
                        break;

                    case 3:
                        NotebookSede.ObtenerEstadisticasGlobales();
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
