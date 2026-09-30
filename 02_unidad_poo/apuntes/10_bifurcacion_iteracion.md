# 10 — Bifurcación e iteración

Apunte derivado exclusivamente del material oficial **Variables Primitivas e Inferencias de Tipo en C#**.

> **Fuente:** `../clases/variables_primitivas_inferencia_tipo_csharp.md`

## if / else if / else

La fuente utiliza esta familia de estructuras para decidir entre caminos alternativos según condiciones booleanas.

Esquema:

```text
condición
   │
   ├── verdadera → camino A
   └── falsa     → camino B
```

El ejemplo conceptual indicado es validar si existe stock suficiente.

## switch

Se presenta como una estructura de selección múltiple.

Esquema conceptual:

```text
valor
 ├── opción 1
 ├── opción 2
 ├── opción 3
 └── ...
```

## do-while

La fuente caracteriza `do-while` por ejecutar primero el bloque y evaluar después la condición.

Esquema:

```text
ejecutar bloque
      ↓
evaluar condición
      ↓
repetir si corresponde
```

Por ello garantiza al menos una ejecución.

El material lo relaciona con:

- menús de consola;
- interacción con usuarios;
- situaciones donde se espera al menos una acción.

## Conceptos habilitados por esta fuente

A partir de este material quedan explícitamente incorporadas a la asignatura:

- `if`;
- `else if`;
- `else`;
- `switch`;
- `do-while`.

## Alcance

Este documento no agrega sintaxis específica ni variantes que la página no desarrolla.
