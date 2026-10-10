using System;
using System.Collections.Generic;
using IPVG.Sede.Core;
using ColaboradorSede = IPVG.Sede.Core.ColaboradorSede;

namespace IPVG.Sede.App;

internal class Program
{
    static void Main(string[] args)
    {
        List<ColaboradorSede> nomina = new List<ColaboradorSede>();
        string opcion = "";

        do
        {
            Console.WriteLine("\n=== SISTEMA DE PERSONAL SEDE IPVG ===");
            Console.WriteLine("1. Registrar docente");
            Console.WriteLine("2. Listar nomina");
            Console.WriteLine("3. Calcular gasto total en sueldos");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opcion: ");
            opcion = Console.ReadLine() ?? "";

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese RUT del docente: ");
                    string rut = Console.ReadLine() ?? "";

                    Console.Write("Ingrese nombre del docente: ");
                    string nombre = Console.ReadLine() ?? "";

                    if (string.IsNullOrWhiteSpace(rut) || string.IsNullOrWhiteSpace(nombre))
                    {
                        Console.WriteLine("El RUT y el nombre no pueden estar vacios.");
                        break;
                    }

                    Console.Write("Ingrese sueldo base: ");
                    if (!decimal.TryParse(Console.ReadLine(), out decimal sueldoIngresado))
                    {
                        Console.WriteLine("Sueldo invalido. Intente nuevamente.");
                        break;
                    }

                    Console.Write("Ingrese cantidad de horas OTEC: ");
                    if (!int.TryParse(Console.ReadLine(), out int horasOtec) || horasOtec < 0)
                    {
                        Console.WriteLine("Las horas OTEC deben ser un entero no negativo.");
                        break;
                    }

                    DocenteSede docente = new DocenteSede(rut, nombre, sueldoIngresado, horasOtec);
                    nomina.Add(docente);

                    Console.WriteLine("\nDocente registrado correctamente.");
                    Console.WriteLine($"Sueldo base aplicado: ${docente.SueldoBase:N0}");
                    Console.WriteLine($"Sueldo total con bono OTEC: ${docente.CalcularSueldoTotal():N0}");
                    break;

                case "2":
                    if (nomina.Count == 0)
                    {
                        Console.WriteLine("No hay colaboradores registrados.");
                    }
                    else
                    {
                        Console.WriteLine("\n=== NOMINA DE LA SEDE ===");
                        foreach (ColaboradorSede colaborador in nomina)
                        {
                            Console.WriteLine($"RUT: {colaborador.ObtenerRut()} | Nombre: {colaborador.Nombre}");
                            Console.WriteLine($"Sueldo base: ${colaborador.SueldoBase:N0} | Sueldo total: ${colaborador.CalcularSueldoTotal():N0}");
                        }
                        Console.WriteLine($"Total de colaboradores: {nomina.Count}");
                    }
                    break;

                case "3":
                    decimal gastoTotal = 0.00m;
                    foreach (ColaboradorSede colaborador in nomina)
                    {
                        gastoTotal += colaborador.CalcularSueldoTotal();
                    }
                    Console.WriteLine($"\nGasto total en sueldos de la sede: ${gastoTotal:N0}");
                    break;

                case "4":
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }
        } while (opcion != "4");
    }
}
