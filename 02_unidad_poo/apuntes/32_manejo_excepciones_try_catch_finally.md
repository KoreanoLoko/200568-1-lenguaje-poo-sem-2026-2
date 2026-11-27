# Apunte 32 — Manejo de excepciones: try, catch y finally

**Fuentes:** [presentación, páginas 3–9 y 14](../clases/manejo_de_excepciones_en_dotnet.md); [Program.cs del ejemplo](../ejemplos/monitoreo_fundo_ipvg/ejemplo_recibido/Program.cs). Apunte derivado para estudio.

## Conceptos

Una excepción es un objeto que expresa un fallo e interrumpe la ejecución ordinaria. El runtime busca una captura compatible; la ejecución no continúa en la instrucción fallida. `System.Exception` es la raíz común de las excepciones del material.

- `try`: instrucciones que pueden fallar.
- `catch (Tipo ex)`: intercepta la excepción compatible. `ex.Message` permite conocer el mensaje.
- `finally`: acción de cierre o auditoría al abandonar el bloque por las vías habituales, haya ocurrido una excepción o no.
- Orden del embudo: capturas específicas antes de una captura base que pudiera absorberlas.

## Ejemplo de consola basado en el docente

```csharp
try
{
    Console.Write("Ingrese lectura: ");
    decimal lectura = decimal.Parse(Console.ReadLine());
    decimal resultado = sensor.RegistrarLectura(lectura);
    Console.WriteLine($"Lectura registrada: {resultado:N2}");
}
catch (FormatException)
{
    Console.WriteLine("Ingrese un número válido.");
}
catch (LecturaInvalidaException ex)
{
    Console.WriteLine($"{ex.Message} (Valor: {ex.ValorInvalido})");
}
finally
{
    Console.WriteLine("Registro procesado.");
}
```

Fragmento adaptado para estudiar: presupone `sensor` instanciado y la clase de excepción importada. No es un programa autónomo ni una nueva fuente oficial.

| Tipo | Caso enseñado |
|---|---|
| FormatException | Texto no convertible mediante decimal.Parse. |
| ArgumentNullException | Código de sensor nulo, vacío o espacios según la regla del constructor. |
| ArgumentOutOfRangeException | pH inválido en el fragmento de la diapositiva 9. |
| InvalidOperationException | Operación sobre un sensor apagado. |
| LecturaInvalidaException | Lectura fuera de escala del ejemplo adjunto. |
| Exception | Tipo general; si se captura junto a derivados, se ubica al final. |

## Menú y continuidad

El ejemplo real usa `do { ... } while (opcion != "4");`, un `switch` y bloques try/catch dentro de las opciones. Las excepciones capturadas no cierran el menú. La opción 3 tiene su propio try/catch y no un finally. El código no captura todos los fallos posibles (por ejemplo OverflowException durante decimal.Parse).

## Criterio para ejercicios

Usar if/else para decisiones normales, excepciones para condiciones inválidas que deben abortar una operación. No dejar catch vacío. Para una aplicación de consola, distinguir parseo de entrada y validación de reglas de negocio. Véanse también [apunte 15](15_validacion_tryparse_sobrecarga_metodos.md) y [apunte 12](12_bucles_for_while_do_while.md). No se deduce una exigencia de usar una excepción personalizada en todos los trabajos futuros.
