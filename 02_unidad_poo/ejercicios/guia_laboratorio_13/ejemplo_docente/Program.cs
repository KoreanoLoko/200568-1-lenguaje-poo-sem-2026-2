using System;
using System.Collections.Generic;
using AuditoriaAgroindustrial.Core;

namespace AuditoriaAgroindustrial.App;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE AUDITORÍA Y CERTIFICACIÓN — FUNDO IPVG === ");

        // Polimorfismo por Interface: Almacena objetos heterogéneos (Bovino y Maquinaria)
        List<IValorable> inventariosFundo = new List<IValorable>
        {
            new Bovino("BOV-901", 480m, "Angus", "China", true),
            new Bovino("BOV-902", 510m, "Hereford", "Japón", false),
            new MaquinariaAgricola("MAQ-301", "Tractor John Deere 6120M", 45000000m, 2022, "Brasil"),
            new MaquinariaAgricola("MAQ-302", "Cosechadora New Holland", 65000000m, 2018, "Argentina")
        };

        decimal patrimonioTotal = 0m;

        Console.WriteLine("--- 1. AUDITORÍA PATRIMONIAL GENERAL (List) ---");
        foreach (IValorable item in inventariosFundo)
        {
            Console.WriteLine($" • {item.ObtenerFichaAuditoria()}");
            patrimonioTotal += item.CalcularTasacionComercial();
        }

        Console.WriteLine($" >> PATRIMONIO TOTAL AUDITADO FUNDO IPVG: ${patrimonioTotal:N2} ");

        Console.WriteLine("--- 2. EMISIÓN DE CERTIFICADOS DE EXPORTACIÓN (List) ---");
        // Pattern Matching para filtrar elementos que implementan IExportable
        foreach (IValorable item in inventariosFundo)
        {
            if (item is IExportable exportable)
            {
                Console.WriteLine($" [EXPORT] {exportable.GenerarCertificadoExportacion()}");
            }
        }
    }
}
