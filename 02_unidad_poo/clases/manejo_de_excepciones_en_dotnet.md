# Manejo de Excepciones en .NET y C#

**Fuente primaria:** presentación docente «Manejo_de_Excepciones_en_.NET.pdf», 14 diapositivas.  
**Subtítulo:** Arquitectura de Resiliencia para el Sistema de Monitoreo Sanitario y Calidad Ambiental — Fundo IPVG.  
**PDF original:** [Manejo_de_Excepciones_en_.NET.pdf](Manejo_de_Excepciones_en_.NET.pdf) (pendiente de subida manual; 3.784.833 bytes; SHA-256 `e8a3a099ca8c6a7cb1c6dfc4cb1e33ac3a6d02720ff46c5d603d6d0a74fda7aa`).  
**Lectura:** revisión visual de las 14 páginas, ya que el archivo no aporta una capa de texto útil. La fecha de creación del PDF es 13-11-2026; no acredita la fecha de la clase.

Este resumen derivado respeta el orden de la presentación. El código de las diapositivas es ilustrativo; el ejemplo C# adjunto se conserva por separado.

## Mapa de las diapositivas

| Pág. | Contenido |
|---:|---|
| 1 | Presentación del manejo de excepciones aplicado al monitoreo sanitario y ambiental. |
| 2 | Escenario crítico del Fundo IPVG: pérdida de conexión de sensores de pH, temperatura y humedad, bloqueo durante escritura y valores físicamente inválidos. La resiliencia busca contener fallos. |
| 3 | Contraste entre códigos de retorno de error (ej. -1) y excepciones como objetos de .NET; el flujo normal se interrumpe ante un fallo y la lógica de manejo se separa de la operación. |
| 4 | Jerarquía System.Object → System.Exception; ramas System.SystemException y System.ApplicationException. Ejemplos NullReferenceException, ArgumentException, InvalidOperationException. El material indica que C# no exige checked exceptions como Java. |
| 5 | Anatomía try/catch/finally: operación susceptible de fallar, captura y tratamiento, y limpieza tanto en éxito como en error. |
| 6 | Caso de conexión serial: Open("COM3") y LeerDatos() dentro de try, Logger.Error en catch y Close() en finally; fragmento ilustrativo, no hardware real del ejemplo. |
| 7 | Regla del embudo: evaluar catch de arriba hacia abajo, desde el tipo más específico hacia el general; un catch general anterior vuelve inalcanzables capturas derivadas sin filtros. |
| 8 | Multicatch: orden incorrecto Exception antes de TimeoutException; orden ilustrativo TimeoutException, ArgumentOutOfRangeException y Exception al final. |
| 9 | Integridad mediante throw: RegistrarLecturaPH(double valorPH) rechaza valores fuera de 0–14 con ArgumentOutOfRangeException y nameof(valorPH). |
| 10 | Relanzamiento: preferir throw; dentro de catch a throw ex; para preservar el origen de la traza. |
| 11 | Excepciones propias para expresar el dominio: ejemplos SensorDescalibradoException y CalidadAguaCriticaException. |
| 12 | Ejemplo SensorAmbientalException : Exception con tres constructores: sin parámetros, mensaje y mensaje + innerException; delegación a base. |
| 13 | Flujo de arquitectura: hardware lanza excepción, lógica intermedia registra y relanza, interfaz captura y comunica, finally limpia recursos. |
| 14 | Principios: reservar excepciones para fallos, no silenciar errores con catch vacío, liberar recursos (finally/using), preservar StackTrace con throw;. |

## Relación con el código recibido

El [proyecto MonitoreoFundoIPVG](../ejemplos/monitoreo_fundo_ipvg/README.md) aplica una excepción propia denominada `LecturaInvalidaException`, no `SensorAmbientalException`. Añade el valor rechazado como propiedad de solo lectura, utiliza `decimal`, y prueba pH y temperatura. No implementa hardware, humedad, base de datos, logger real, relanzamiento ni liberación de un puerto. Su finally imprime una línea de auditoría, no escribe un archivo.

## Precisiones de lectura (análisis derivado)

- La propagación de una excepción no garantiza que una aplicación continúe: debe existir una captura adecuada; un fallo no capturado puede terminar el proceso.
- El finally se ejecuta en el flujo normal de salida del bloque y en el desenrollado habitual por excepción; no es garantía frente a toda terminación abrupta del proceso.
- Los tres constructores de la diapositiva 12 son un ejemplo de diseño y no constituyen por sí solos una implementación de serialización. El proyecto recibido tiene un constructor específico del dominio.
- Los rangos del ejemplo son reglas del ejercicio, no certificación de normativa sanitaria.

[Apunte 32](../apuntes/32_manejo_excepciones_try_catch_finally.md) · [Apunte 33](../apuntes/33_excepciones_personalizadas_throw_y_trazas.md).
