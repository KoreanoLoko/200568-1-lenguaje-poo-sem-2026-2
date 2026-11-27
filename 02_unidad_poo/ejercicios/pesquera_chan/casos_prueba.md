# Pesquera Chan — resultados esperados por las reglas de los TODO

Cálculos derivados manualmente de los comentarios de PezCultivo, LoteSalmon y LoteEspecieMarina. **No son salidas de ejecución.** Los importes están en pesos según la notación del ejercicio.

| Lote | Peso efectivo | Operación | Valor comercial esperado |
|---|---:|---|---:|
| SAL-101 | 850 kg | (850 × 4.000 + 150.000) × 1,25 | $4.437.500 |
| SAL-102 | 420 kg | 420 × 4.000 | $1.680.000 |
| PEC-201 | 350 kg | (350 × 3.000 × 1,18) + 100.000 | $1.339.000 |
| PEC-202 | 50 kg (ingresa 40) | 50 × 3.000 | $150.000 |
| **Suma comercial de los cuatro** | | | **$7.606.500** |
| SAL-103 (opción 1) | 600 kg | (600 × 4.000 + 150.000) × 1,25 | $3.187.500 |
| PEC-203 (opción 2) | 250 kg | 250 × 3.000 × 1,18 | $885.000 |

Casos de frontera: peso 0, 40 y 50 deben almacenar 50; peso 50,1 permanece 50,1; 500 unidades no añaden bono, 501 sí. Tipo SALADA sin ASC recibe solo recargo fijo; ASC con DULCE aplica solo el factor del 25 %. En especie ORGANICA el recargo del 18 % precede al bono por unidades.

No se equipara la suma comercial al patrimonio final de la opción 4, porque ProcesarTasacion y bonificacionEspecial no están especificados por completo.
