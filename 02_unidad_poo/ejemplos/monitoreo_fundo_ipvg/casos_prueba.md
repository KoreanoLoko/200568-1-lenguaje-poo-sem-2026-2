# Monitoreo Fundo IPVG — casos de prueba esperados

Derivados por inspección de SensorAmbiental.cs, LecturaInvalidaException.cs y Program.cs. No ejecutados. Introducir decimales según la cultura de la consola.

| Opción | Entrada / condición | Resultado esperado |
|---|---|---|
| 1 | 0 | Éxito y auditoría |
| 1 | 7 | Éxito y auditoría |
| 1 | 14 | Éxito y auditoría |
| 1 | -1 | LecturaInvalidaException, mensaje de pH y valor, auditoría |
| 1 | 15 | LecturaInvalidaException, mensaje de pH y valor, auditoría |
| 2 | 0 | Éxito y auditoría |
| 2 | 22,5 (según cultura) | Éxito y auditoría |
| 2 | 45 | Éxito y auditoría |
| 2 | 46 | LecturaInvalidaException, alerta de temperatura y valor, auditoría |
| 2 | -1 | LecturaInvalidaException, alerta de temperatura y valor, auditoría |
| 1/2 | abc | FormatException capturada; mensaje de formato y auditoría |
| 3 | Lectura fija de 22.5m | InvalidOperationException capturada: sensor apagado; sin finally en esta opción |
| 4 | Salir | Fin del menú |

Prueba directa del constructor: código vacío o espacios → ArgumentNullException. No hay opción de registrar sensores nuevos en el menú. Un valor decimal fuera del rango representable puede lanzar OverflowException no capturada; no se promete continuidad para este caso.
