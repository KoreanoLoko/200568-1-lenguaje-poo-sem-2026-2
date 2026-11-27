using System;
using System.Collections.Generic;
using MonitoreoFundo.Core;

namespace MonitoreoFundo.App;

class Program
{
    static void Main(string[] args)
    {
        // TODO 7: Instanciar lista de sensores con datos de prueba
        List<SensorAmbiental> sensores = new List<SensorAmbiental>()
        {
            new SensorAmbiental("SEN-PH01", "PH", true),
            new SensorAmbiental("SEN-TMP01", "TEMPERATURA", true),
            new SensorAmbiental("SEN-TMP02", "TEMPERATURA", false)
        };

        string opcion = "";
        do
        {
            Console.WriteLine("\n=== SISTEMA DE MONITOREO AMBIENTAL — FUNDO IPVG ===");
            Console.WriteLine("1. Probar Lectura de pH (SEN-PH01)");
            Console.WriteLine("2. Probar Lectura de Temperatura (SEN-TMP01)");
            Console.WriteLine("3. Intentar Lectura en Sensor Apagado (SEN-TMP02)");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                case "2":
                    SensorAmbiental sensor = (opcion == "1") ? sensores[0] : sensores[1];

                    // TODO 8: Envolver en bloque 'try' la lectura de consola y el procesamiento
                    try
                    {
                        Console.Write($"Ingrese lectura para [{sensor.CodigoSensor}]: ");
                        decimal lectura = decimal.Parse(Console.ReadLine());
                        decimal resultado = sensor.RegistrarLectura(lectura);
                        Console.WriteLine($"-> [ÉXITO] Lectura registrada: {resultado:N2}");
                    }
                    // TODO 9: Capturar 'FormatException' para errores de conversión de texto
                    catch (FormatException)
                    {
                        Console.WriteLine("-> [ERROR FORMATO] Ingrese un número válido.");
                    }
                    // TODO 10: Capturar 'LecturaInvalidaException' para alertas de rango
                    catch (LecturaInvalidaException ex)
                    {
                        Console.WriteLine($"-> [ALERTA REGLA] {ex.Message} (Valor: {ex.ValorInvalido})");
                    }
                    // TODO 11: Bloque 'finally' para registrar auditoría incondicional
                    finally
                    {
                        Console.WriteLine("-> [AUDITORÍA] Registro procesado en la bitácora.");
                    }
                    break;

                case "3":
                    // TODO 12: Probar captura de 'InvalidOperationException'
                    try
                    {
                        sensores[2].RegistrarLectura(22.5m);
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine($"-> [ESTADO INVÁLIDO] {ex.Message}");
                    }
                    break;
            }
        } while (opcion != "4");
    }
}
