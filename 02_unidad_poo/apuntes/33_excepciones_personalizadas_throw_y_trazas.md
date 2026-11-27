# Apunte 33 — throw, excepciones personalizadas y trazas

**Fuentes:** [presentación, páginas 9–14](../clases/manejo_de_excepciones_en_dotnet.md) y [LecturaInvalidaException.cs](../ejemplos/monitoreo_fundo_ipvg/ejemplo_recibido/LecturaInvalidaException.cs).

## Rechazar una operación inválida

```csharp
if (string.IsNullOrWhiteSpace(codigo))
    throw new ArgumentNullException(nameof(codigo), "El código del sensor es obligatorio.");
```

La instrucción throw crea/lanza la excepción; nameof devuelve el nombre del parámetro. La llamada al constructor no finaliza normalmente si el código es inválido. En el ejemplo, un sensor apagado lanza InvalidOperationException; una lectura inválida lanza la excepción de dominio.

## Contrato de la excepción propia

La clase recibida hereda de Exception, define `public decimal ValorInvalido { get; }` y recibe `string mensaje, decimal valor`. El constructor delega `base(mensaje)` y asigna la propiedad de solo lectura. Así el catch puede acceder a Message y al dato que ocasionó el fallo.

```csharp
catch (LecturaInvalidaException ex)
{
    Console.WriteLine($"Alerta: {ex.Message} (Valor: {ex.ValorInvalido})");
}
```

Fragmento de estudio adaptado; ver fuente para el texto exacto.

La diapositiva 12 presenta un diseño distinto, `SensorAmbientalException : Exception`, con constructores sin argumentos, con mensaje y con mensaje más Exception innerException. La última variante delega a base para conservar una causa interna. No se agregan esos constructores al ejemplo recibido.

## Propagación y traza

En una captura intermedia, `throw;` vuelve a lanzar la excepción conservando la traza original. `throw ex;` altera el punto de lanzamiento reflejado en la traza y puede ocultar información de diagnóstico. La interfaz puede capturar la excepción propagada y mostrar un mensaje; la limpieza se puede situar en finally.

## Cuatro principios de la presentación

1. Excepcionalidad: no usar excepciones para reemplazar decisiones ordinarias.
2. No silenciar fallos con capturas vacías.
3. Higiene de recursos: finally o using.
4. Preservación de trazas: throw; al relanzar.

## Relación con la materia anterior

La excepción personalizada reutiliza herencia y constructor base, y la captura por tipos se apoya en relaciones de tipos. Véanse [apunte 29](29_herencia_base_virtual_override.md) y [apunte 32](32_manejo_excepciones_try_catch_finally.md). El código de sensores no contiene un relanzamiento ni una InnerException: son conocimientos de la presentación, no características implementadas del proyecto.
