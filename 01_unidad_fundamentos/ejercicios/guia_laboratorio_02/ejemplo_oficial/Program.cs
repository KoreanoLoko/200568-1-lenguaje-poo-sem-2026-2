using System;

// 1. Entrada de datos del profesional
Console.Write("Ingrese el nombre completo del desarrollador/a: ");
string nombreDesarrollador = Console.ReadLine();

Console.Write("Ingrese el título del proyecto de software: ");
string nombreProyecto = Console.ReadLine();

// 2. Entrada de datos numéricos con su respectivo parseo
Console.Write("Ingrese la cantidad total de horas estimadas de desarrollo: ");
string entradaHoras = Console.ReadLine();
int horasEstimadas = int.Parse(entradaHoras); // Parseo a entero

Console.Write("Ingrese el valor por hora en pesos chilenos ($): ");
string entradaValorHora = Console.ReadLine();
double valorHora = double.Parse(entradaValorHora); // Parseo a decimal

// 3. Cálculos secuenciales lógicos
double subtotalNeto = horasEstimadas * valorHora;
double tasaIva = 0.19; // 19% IVA correspondiente a la legislación chilena
double impuestoIva = subtotalNeto * tasaIva;
double totalCotizacion = subtotalNeto + impuestoIva;

// 4. Inferencia de tipo opcional para validación de estado
var cotizacionEsViable = totalCotizacion > 0;

// 5. Salida de datos en consola con formato e interpolación
Console.WriteLine("\n========================================================");
Console.WriteLine("             RESUMEN DE COTIZACIÓN DE SOFTWARE");
Console.WriteLine("========================================================");
Console.WriteLine($"Proyecto:             {nombreProyecto}");
Console.WriteLine($"Desarrollador/a:      {nombreDesarrollador}");
Console.WriteLine($"Horas Estimadas:      {horasEstimadas} hrs.");
Console.WriteLine($"Valor por Hora:       {valorHora:C0} CLP");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine($"Subtotal Neto:        {subtotalNeto:C0} CLP");
Console.WriteLine($"IVA (19%):            {impuestoIva:C0} CLP");
Console.WriteLine($"TOTAL PRESUPUESTO:    {totalCotizacion:C0} CLP");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine($"¿Estado de Viabilidad?: {cotizacionEsViable}");
Console.WriteLine("========================================================\n");

Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadKey();
