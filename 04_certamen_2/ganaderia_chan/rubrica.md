# Rúbrica — Certamen 2 Ganadería Chan

**Origen:** rúbrica de Canvas transcrita por el estudiante en la conversación. **Total:** 100 puntos. **Exigencia:** 51 % (51 puntos = nota 4,0).

| Criterio | TODO | Máximo |
| --- | --- | ---: |
| 1. Clase base y encapsulamiento (AnimalGanado.cs) | 1–4 | 25 |
| 2. Subclase vacunos (Bovino.cs) | 5–7 | 25 |
| 3. Subclase cerdos (Porcino.cs) | 8–10 | 25 |
| 4. Consola, menú y transacción (Program.cs) | 11–15 | 25 |
| **Total** | **15 TODO** | **100** |

## Criterio 1 — AnimalGanado.cs

- **25 (Se excede):** namespace file-scoped `GanaderiaChan.Core`; campos `codigoAnimal` y `raza` `protected`; propiedad completa `PesoKilos` con setter que asigna 100 al recibir un valor ≤100; `CalcularValorComercial()` a 2000m/kg y `ObtenerFicha()` ambos `virtual`.
- **18 (Dominio):** namespace y propiedad, pero error menor en `<` frente a `<=` o firma virtual.
- **13 (Cerca):** campos con visibilidad errónea o propiedad autoimplementada sin validación.
- **0 (Sin evidencia):** no se entrega el archivo, no compila o no se resuelven TODO 1–4.

## Criterio 2 — Bovino.cs

- **25:** herencia, namespace, constructor `: base(...)`, `override` de tasación 2500m/kg + 150000m LECHE/200000m CARNE + 20 % Pedigree aplicado al subtotal; `override ObtenerFicha()` con `base.ObtenerFicha()`.
- **18:** herencia y base correctas, pero error numérico o recargo aplicado solo al precio base.
- **13:** hereda pero no invoca constructor base, o falta `override`.
- **0:** no se entrega, no compila o TODO 5–7 irresueltos.

## Criterio 3 — Porcino.cs

- **25:** herencia, `: base(...)`, tasación `1800m` por kg, 15 % Pastoreo, 80000m si `CantidadLechones > 5`, sobrescrituras de valor y ficha.
- **18:** implementación general correcta, pero error al usar `>= 5` o aplicar el 15 %.
- **13:** falta `override` o no se reutiliza `base.ObtenerFicha()`.
- **0:** archivo ausente, no compilable o TODO 8–10 irresueltos.

## Criterio 4 — Program.cs

- **25:** `using` y alias `AnimalChan`; método transaccional con `ref` y `out`; `List<AnimalChan>` con 4 registros; recorrido polimórfico y transaccional.
- **18:** lista/menú presentes pero errores de asignación `out`, `ref` o falta de datos precargados.
- **13:** lista sin recorrido polimórfico o menú con problemas al ejecutar `dotnet run`.
- **0:** no se entrega, no compila o TODO 11–15 irresueltos.

## Nota de fidelidad

Se reorganizó la redacción en una tabla y cuatro secciones, conservando los puntajes, condiciones, operadores estrictos y umbrales de la rúbrica facilitada. **No representa una calificación obtenida ni una verificación de cumplimiento.**
