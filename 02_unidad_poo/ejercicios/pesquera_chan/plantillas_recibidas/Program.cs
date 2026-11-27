using System;
using System.Collections.Generic;

// TODO 11: Importar Namespace PesqueraChan.Core y crear Alias de Tipo 'PezChan'


namespace PesqueraChan.App;

class Program
{
    // TODO 12: Método transaccional 'ProcesarTasacion'
    // Recibe: (PezChan lote, ref decimal patrimonioPesquera, out decimal bonificacionEspecial)

    static void Main(string[] args)
    {
        decimal patrimonioTotalPesquera = 0.00m;

        // TODO 13: Declarar e instanciar List<PezChan> e incluir 4 registros de prueba precargados


        //  REGISTROS DE PRUEBA PRECARGADOS PARA VERIFICACIÓN RÁPIDA CLI
        biomasaTotal.Add(new LoteSalmon("SAL-101", "Salmón Atlántico", 850.0m, "SALADA", true)); // Salmón ASC en Mar
        biomasaTotal.Add(new LoteSalmon("SAL-102", "Trucha Arcoíris", 420.0m, "DULCE", false));   // Salmónido Piscifactoría
        biomasaTotal.Add(new LoteEspecieMarina("PEC-201", "Corvina de Cultivo", 350.0m, "ORGANICA", 650)); // Orgánica con Bono
        biomasaTotal.Add(new LoteEspecieMarina("PEC-202", "Turbot / Rodaballo", 40.0m, "ESTANDAR", 200));   // Valida piso mín. (50 kg)

        string opcion = "";
        do
        {
            Console.WriteLine("\n=== SISTEMA DE GESTIÓN Y TASACIÓN ACUÍCOLA — PESQUERA CHAN ===");
            Console.WriteLine("1. Registrar Nuevo Lote de Salmónidos");
            Console.WriteLine("2. Registrar Nuevo Lote de Especie Marina");
            Console.WriteLine("3. Ver Ficha General de Biomasa (Polimorfismo - 4 Registros Precargados)");
            Console.WriteLine("4. Calcular Valorización y Arqueo Patrimonial (ref / out)");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción (1-5): ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    biomasaTotal.Add(new LoteSalmon("SAL-103", "Salmón Coho", 600.0m, "SALADA", true));
                    Console.WriteLine("-> ¡Lote de Salmón registrado e ingresado al sistema!");
                    break;

                case "2":
                    biomasaTotal.Add(new LoteEspecieMarina("PEC-203", "Tilapia de Cultivo", 250.0m, "ORGANICA", 400));
                    Console.WriteLine("-> ¡Lote de Especie Marina registrado exitosamente!");
                    break;

                case "3":
                    Console.WriteLine("\n--- FICHA GENERAL DE BIOMASA (POLIMORFISMO EN FOREACH) ---");
                    // TODO 14: Recorrer biomasaTotal imprimiendo lote.ObtenerFicha()

                    Console.WriteLine($"Total Lotes Registrados (Count): {biomasaTotal.Count}");
                    break;

                case "4":
                    decimal totalTasacion = 0.00m;
                    Console.WriteLine("\n--- PROCESANDO BALANCE Y ARQUEO PATRIMONIAL --- ");
                    // TODO 15: Recorrer biomasaTotal invocando ProcesarTasacion con ref y out

                    Console.WriteLine($"Total Valorización Lote Actual: ${totalTasacion:N2}");
                    Console.WriteLine($"Patrimonio Acumulado Pesquera (ref): ${patrimonioTotalPesquera:N2}");
                    break;

                case "5":
                    Console.WriteLine("\nCerrando sistema de Pesquera Chan...");
                    break;
            }
        } while (opcion != "5");
    }
}

