# 09 — Tipos primitivos, decimal e inferencia con var

Apunte derivado exclusivamente del material oficial **Variables Primitivas e Inferencias de Tipo en C#**.

> **Fuente:** `../clases/variables_primitivas_inferencia_tipo_csharp.md`

## Tipado estático

La fuente presenta a C# como un lenguaje de tipado estático y seguro.

En el nivel trabajado aquí, cada variable tiene un tipo conocido durante la compilación.

## Tipos incluidos en el material

| Tipo | Uso presentado |
| --- | --- |
| `int` | conteos e inventario |
| `double` | cálculos generales o físicos |
| `decimal` | cálculos financieros y comerciales |
| `string` | nombres y códigos |
| `bool` | estados verdadero/falso |

## decimal

La fuente utiliza:

```csharp
2500.50m
```

para mostrar un literal `decimal`.

También acepta:

```csharp
2500.50M
```

El material establece como regla de desarrollo utilizar `decimal` en precios y saldos de caja.

## var

```csharp
var
```

permite que el compilador infiera el tipo de una variable local a partir del valor asignado.

Conceptualmente:

```csharp
var cantidad = 10;
```

se interpreta dentro del enfoque de la fuente como una variable cuyo tipo es determinado por el compilador, no como una variable dinámica.

## Diferencia conceptual

```text
tipo explícito
int cantidad = 10;

inferencia
var cantidad = 10;
```

En ambos casos, según el material, el tipo permanece estático después de la compilación.

## Alcance

Este apunte mantiene la recomendación monetaria y la terminología utilizadas por la fuente oficial.
