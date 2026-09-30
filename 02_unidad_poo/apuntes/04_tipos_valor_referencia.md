# 04 — Tipos por valor y tipos por referencia

Apunte derivado exclusivamente del material oficial **Clases y objetos**.

> **Fuente:** `../clases/clases_y_objetos.md`

## Clasificación presentada

El material distingue entre:

```text
Tipos por Valor      → struct
Tipos por Referencia → class
```

La diferencia central se estudia a partir del comportamiento de una variable cuando se asigna a otra o se transfiere como parámetro.

## Comparación según la fuente

| Criterio | Tipo por Valor | Tipo por Referencia |
| --- | --- | --- |
| Representación utilizada | `struct` | `class` |
| Ubicación presentada | Stack | Heap para la instancia real |
| Asignación con `=` | Copia del valor | Copia de la referencia |
| Resultado de la copia | Variables independientes | Variables que comparten la misma instancia |
| Valor inicial presentado | Estado por defecto del valor | `null` para la referencia |
| Ciclo de vida presentado | Ligado al ámbito de ejecución | Administrado mediante Garbage Collector |

## Asignación por valor

El material describe la asignación como una copia completa del valor.

Conceptualmente:

```text
A = valor
B = A

A y B quedan independientes
```

## Asignación por referencia

Para una clase, el material explica que la asignación copia la referencia.

Conceptualmente:

```text
objeto real en Heap
      ▲     ▲
      │     │
      A     B
```

A y B pueden apuntar a la misma instancia.

## Relación con class y new

```csharp
Vehiculo miAuto = new Vehiculo();
```

`Vehiculo` es presentado como un tipo por referencia porque se define mediante `class`.

## Alcance

Este apunte mantiene exactamente el modelo comparativo de la fuente oficial. No incorpora casos especiales ni precisiones de implementación que no hayan sido enseñadas en este material.
