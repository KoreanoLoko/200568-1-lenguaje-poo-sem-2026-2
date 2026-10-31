// TODO 11: Importar Namespace y Alias 'AnimalChan'
using System;
using System.Collections;
using System.Collections.Generic;
using AnimalChan;

namespace GanaderiaChan.App;

class Program
{
    // TODO 12: Método transaccional con parámetros ref y out
    // Implementar el método ProcesarPesajeOVenta que
    // actualiza el patrimonio acumulado por referencia (ref)
    // y devuelve la bonificación especial obtenida mediante
    // parámetro de salida (out).
    static decimal ProcesarPesajeOVenta(AnimalChan animal, ref decimal patrimonioGanaderia, out decimal bonificacionEspecial)
    {
       
    }

    static void Main(string[] args)
    {
        decimal patrimonioTotalChan = 0.00m;

        // TODO 13: Declarar List hatoGanadero
        
        string opcion = "";
        do
        {
            Console.WriteLine("=== SISTEMA DE GESTIÓN Y VALORACIÓN — GANADERÍA CHAN === ");
            Console.WriteLine("1. Registrar Bovino (Vacuno)");
            Console.WriteLine("2. Registrar Porcino (Cerdo)");
            Console.WriteLine("3. Ver Ficha General del Hato");
            Console.WriteLine("4. Calcular Valorización y Arqueo (ref / out)");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    
                    break;

                case "2":
                    break;

                case "3":
                    Console.WriteLine("-- - FICHA GENERAL DEL HATO GANADERO - --");
                    foreach (AnimalChan animal in hatoGanadero)
                    {
                        Console.WriteLine($" • {animal.ObtenerFicha()}");
                    }
                    Console.WriteLine($"Total Ejemplares (Count): {hatoGanadero.Count}");
                    break;

                case "4":
                    decimal totalTasacion = 0.00m;
                    Console.WriteLine("-- - PROCESANDO BALANCE Y ARQUEO - -- ");
                    foreach (AnimalChan animal in hatoGanadero)
                    {
                        decimal bono;
                        decimal valor = ProcesarPesajeOVenta(animal, ref patrimonioTotalChan, out bono);
                        totalTasacion += valor;
                    }
                    Console.WriteLine($"Total Lote Actual: ${totalTasacion:N2}");
                    Console.WriteLine($"Patrimonio Acumulado (ref): ${patrimonioTotalChan:N2}");
                    break;

                case "5":
                    Console.WriteLine("Cerrando sistema de Ganadería Chan...");
                    break;
            }

        } while (opcion != "5");
    }
}
