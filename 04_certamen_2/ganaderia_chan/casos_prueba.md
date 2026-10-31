# Casos de prueba calculados — Ganadería Chan

**Estado:** resultados obtenidos por aplicación de las fórmulas del enunciado a datos de muestra; **no se ejecutó el proyecto**. Los registros iniciales de prueba fueron propuestos en la conversación y no se atribuyen al docente.

| Código | Instancia ilustrativa | Operación | Resultado esperado |
| --- | --- | --- | ---: |
| BOV-101 | Bovino Holstein, 420 kg, LECHE, Pedigree | (420×2500 + 150000)×1.20 | $1.440.000 |
| BOV-102 | Bovino Angus, 350 kg, CARNE, no Pedigree | 350×2500 + 200000 | $1.075.000 |
| POR-201 | Porcino Duroc, 200 kg, PASTOREO, 6 lechones | (200×1800)×1.15 + 80000 | $494.000 |
| POR-202 | Porcino Landrace, 180 kg, INTENSIVA, 4 lechones | 180×1800 | $324.000 |
| **Lote** | **4 animales de prueba** | **Suma** | **$3.333.000** |

## Bordes críticos de la rúbrica

| Prueba | Expectativa |
| --- | --- |
| Peso 99m / 100m | `PesoKilos == 100m` |
| Peso 100.01m | Conserva `100.01m` |
| Bovino de 300 kg, CARNE, Pedigree | (300×2500+200000)×1.20 = **$1.140.000** |
| Porcino de 200 kg, PASTOREO, 6 lechones | (200×1800)×1.15+80000 = **$494.000** |
| Porcino INTENSIVA con 5 lechones | No se suma bono reproductor |
| Porcino INTENSIVA con 6 lechones | Suma bono de $80.000 |
| `List<AnimalChan>` y `foreach` | Las fichas deben especializarse por el tipo concreto |
| `ProcesarPesajeOVenta` | Debe asignar `out` y actualizar el acumulador mediante `ref` |

## Cálculo condicional del ejemplo Program.cs

En la **propuesta no oficial** el `out` es el exceso positivo respecto de `peso*2000m`: BOV-101 $600.000, BOV-102 $375.000, POR-201 $94.000, POR-202 $0. Esta definición **no aparece en el enunciado**, y no debe utilizarse como respuesta oficial sin confirmación.

El ejemplo de Program reinicia patrimonio antes del arqueo: al consultar el mismo lote dos veces muestra $3.333.000 ambas veces. La plantilla original no lo reinicia: repetir la opción acumularía $6.666.000. **La intención exacta no está fijada por el texto de la evaluación**, por lo que este comportamiento requiere una decisión informada.

## Limitaciones de esta comprobación

No hay salida real de consola, informe de compilación, test automatizado, `.csproj`, ZIP de entrega ni constancia de nota. Los montos son aritmética de control, no resultados de ejecución.
