using System;
// Importación estándar
using IPVG.Sede.Equipamiento;

// Creación de Alias para resolver ambigüedades
using CasilleroSede = IPVG.Sede.Equipamiento.Locker;

namespace GestionLockersIPVG;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== GESTIÓN DE LOCKERS - SEDE IPVG ===");

        // Instanciación usando la clase directa o mediante Alias
        CasilleroSede casillero1 = new CasilleroSede(101);
        casillero1.Asignar("19.876.543-2");

        Console.WriteLine($"Locker {casillero1.NumeroLocker}: Asignado a RUT {casillero1.RutEstudiante}");
    }
}
