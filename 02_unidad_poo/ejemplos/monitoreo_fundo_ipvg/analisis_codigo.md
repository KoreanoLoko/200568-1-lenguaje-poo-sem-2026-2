# Monitoreo Fundo IPVG — análisis del código recibido

## Mapa de TODO

| TODO | Archivo | Implementación observada |
|---:|---|---|
| 1 | LecturaInvalidaException | Hereda de Exception. |
| 2 | LecturaInvalidaException | ValorInvalido decimal, propiedad get-only. |
| 3 | LecturaInvalidaException | Constructor (mensaje, valor) delega base(mensaje) y guarda valor. |
| 4 | SensorAmbiental | IsNullOrWhiteSpace(codigo) → ArgumentNullException(nameof(codigo), mensaje). |
| 5 | SensorAmbiental | Si !EstadoActivo → InvalidOperationException. |
| 6 | SensorAmbiental | PH: 0–14 inclusive; TEMPERATURA: 0–45 inclusive, fuera del rango → LecturaInvalidaException. |
| 7 | Program | Lista con SEN-PH01 (activo), SEN-TMP01 (activo), SEN-TMP02 (apagado). |
| 8 | Program | try contiene decimal.Parse, RegistrarLectura y salida de éxito. |
| 9 | Program | catch FormatException informa conversión inválida. |
| 10 | Program | catch LecturaInvalidaException muestra Message y ValorInvalido. |
| 11 | Program | finally imprime mensaje de auditoría para opciones 1/2. |
| 12 | Program | Opción 3 llama RegistrarLectura(22.5m) en sensor apagado, captura InvalidOperationException. |

## Flujo

Las opciones 1 y 2 comparten código y el operador ternario selecciona sensores[0] o sensores[1]. El parseo ocurre antes de validar el rango. RegistrarLectura primero comprueba estado, después tipo y rango, finalmente retorna el valor. El menú vuelve a aparecer tras capturas manejadas; opción 4 termina el do-while.

## Límites observados (análisis derivado, no corrección)

- TipoVariable se normaliza con ToUpper() sin validar null, espacios ni tipos desconocidos; estos últimos pasan sin validación de rango.
- Las propiedades autoimplementadas admiten cambios posteriores sin validar.
- decimal.Parse depende de cultura y puede producir otras excepciones (OverflowException o ArgumentNullException al recibir null); no se capturan en opciones 1/2. Nullable habilitado puede originar advertencias de Console.ReadLine().
- Opción 3 no tiene finally. No existe default en el switch ni gestión de EOF (null en ReadLine).
- La auditoría es una impresión de consola, no persistencia; no hay hardware o red conectados.
- La excepción personalizada tiene un constructor específico, no los tres de SensorAmbientalException mostrados en la diapositiva 12. No hay relanzamiento ni InnerException en el código.
- No se declara que los límites del ejercicio constituyan regulación sanitaria real.

No se altera el ejemplo recibido para subsanar estos puntos. Se distingue la materia demostrada de recomendaciones adicionales.
