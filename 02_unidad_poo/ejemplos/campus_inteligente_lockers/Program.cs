using System;
using System.Collections.Generic;
using IPVG.Sede.Equipamiento;
using CasilleroSede = IPVG.Sede.Equipamiento.Locker;

namespace IPVG.Sede.App;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA INTEGRADO DE LOCKERS - SEDE IPVG ===");

        // Gestión mediante Colección Genérica Tipada List<T>
        List<CasilleroSede> listaLockers = new List<CasilleroSede>()
        {
            new CasilleroSede(101, 3500.00m),
            new CasilleroSede(102, 3500.00m)
        };

        string opcion = "";
        do
        {
            Console.WriteLine("-- - MENÚ DE CONTROL-- - ");
            Console.WriteLine("1. Listar Lockers (foreach)");
            Console.WriteLine("2. Agregar Nuevo Locker (List.Add)");
            Console.WriteLine("3. Arrendar (List.Find y 'out')");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    foreach (CasilleroSede locker in listaLockers)
                        Console.WriteLine(locker.ObtenerFicha());
                        Console.WriteLine($"Total Registrados: {listaLockers.Count}");
                    break;

                case "2":
                    Console.Write("Número: ");
                    int num = int.Parse(Console.ReadLine());
                    listaLockers.Add(new CasilleroSede(num, 3500.00m));
                    Console.WriteLine("¡Locker agregado a la colección dinámicamente!");
                    break;

                case "3":
                    Console.Write("Codigo a buscar: ");
                    int codigoABuscar = int.Parse(Console.ReadLine());
                    CasilleroSede casilleroEncontrado = listaLockers.Find(elCodigo => elCodigo.NumeroLocker == codigoABuscar);
                    if (casilleroEncontrado != null && casilleroEncontrado.Arrendar("19.876.543-2", out decimal cobro))
                        Console.WriteLine($"[ÉXITO] Cobro realizado: ${cobro:N2}");
                        Console.WriteLine($"Total recaudado hasta ahora es ${Locker.ObtenerRecaudoGlobal():N2}");
                    break;
            }
        } while (opcion != "4");
    }
}
