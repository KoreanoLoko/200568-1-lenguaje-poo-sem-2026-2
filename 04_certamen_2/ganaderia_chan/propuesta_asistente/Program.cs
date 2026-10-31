// TODO 11: Importar Namespace y Alias 'AnimalChan'
using System;
using System.Collections;
using System.Collections.Generic;
using GanaderiaChan.Core;
using AnimalChan = GanaderiaChan.Core.AnimalGanado;

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
        decimal valor = animal.CalcularValorComercial();
        decimal valorBase = animal.PesoKilos * 2000m;

        // HIPÓTESIS DEL ASISTENTE: el enunciado no define la bonificación especial.
        bonificacionEspecial = valor - valorBase;

        if (bonificacionEspecial < 0m)
            bonificacionEspecial = 0m;

        patrimonioGanaderia += valor;

        return valor;
    }

    static void Main(string[] args)
    {
        decimal patrimonioTotalChan = 0.00m;

        // TODO 13: Declarar List hatoGanadero
        List<AnimalChan> hatoGanadero = new List<AnimalChan>();

        // Los códigos son exigidos por la guía; los demás datos son ejemplos propuestos.
        hatoGanadero.Add(new Bovino("BOV-101", "Holstein", 420m, "LECHE", true));
        hatoGanadero.Add(new Bovino("BOV-102", "Angus", 350m, "CARNE", false));
        hatoGanadero.Add(new Porcino("POR-201", "Duroc", 200m, "PASTOREO", 6));
        hatoGanadero.Add(new Porcino("POR-202", "Landrace", 180m, "INTENSIVA", 4));

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
                // TODO 14: Registrar animales en la lista (rótulo explicativo)
                case "1":
                    Console.Write("Ingrese código del bovino: ");
                    string codigoBovino = Console.ReadLine();

                    Console.Write("Ingrese raza: ");
                    string razaBovino = Console.ReadLine();

                    Console.Write("Ingrese peso en kilos: ");
                    decimal pesoBovino = decimal.Parse(Console.ReadLine());

                    Console.Write("Tipo de producción (CARNE/LECHE): ");
                    string tipoProduccion = Console.ReadLine();

                    Console.Write("¿Tiene Pedigree? (S/N): ");
                    string respuestaPedigree = Console.ReadLine().ToUpper();

                    bool esPedigree = respuestaPedigree == "S";

                    hatoGanadero.Add(new Bovino(
                        codigoBovino,
                        razaBovino,
                        pesoBovino,
                        tipoProduccion,
                        esPedigree
                    ));

                    Console.WriteLine("Bovino registrado correctamente.");
                    break;

                case "2":
                    Console.Write("Ingrese código del porcino: ");
                    string codigoPorcino = Console.ReadLine();

                    Console.Write("Ingrese raza: ");
                    string razaPorcino = Console.ReadLine();

                    Console.Write("Ingrese peso en kilos: ");
                    decimal pesoPorcino = decimal.Parse(Console.ReadLine());

                    Console.Write("Tipo de alimentación (PASTOREO/INTENSIVA): ");
                    string tipoAlimentacion = Console.ReadLine();

                    Console.Write("Ingrese cantidad de lechones: ");
                    int cantidadLechones = int.Parse(Console.ReadLine());

                    hatoGanadero.Add(new Porcino(
                        codigoPorcino,
                        razaPorcino,
                        pesoPorcino,
                        tipoAlimentacion,
                        cantidadLechones
                    ));

                    Console.WriteLine("Porcino registrado correctamente.");
                    break;

                // TODO 15: Recorrido polimórfico del hato (rótulo explicativo)
                case "3":
                    Console.WriteLine("--- FICHA GENERAL DEL HATO GANADERO ---");
                    foreach (AnimalChan animal in hatoGanadero)
                    {
                        Console.WriteLine($" • {animal.ObtenerFicha()}");
                    }
                    Console.WriteLine($"Total Ejemplares (Count): {hatoGanadero.Count}");
                    break;

                case "4":
                    decimal totalTasacion = 0.00m;
                    // DECISIÓN DEL ASISTENTE: prevenir conteo repetido al consultar varias veces.
                    patrimonioTotalChan = 0.00m;

                    Console.WriteLine("--- PROCESANDO BALANCE Y ARQUEO ---");

                    foreach (AnimalChan animal in hatoGanadero)
                    {
                        decimal bono;
                        decimal valor = ProcesarPesajeOVenta(
                            animal,
                            ref patrimonioTotalChan,
                            out bono
                        );

                        totalTasacion += valor;

                        Console.WriteLine($"Valor: ${valor:N2} | Bonificación especial: ${bono:N2}");
                    }

                    Console.WriteLine($"Total Lote Actual: ${totalTasacion:N2}");
                    Console.WriteLine($"Patrimonio Acumulado (ref): ${patrimonioTotalChan:N2}");
                    break;

                case "5":
                    Console.WriteLine("Cerrando sistema de Ganadería Chan...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != "5");
    }
}
