# 06 — Experimento de copia: struct vs. class

Apunte derivado exclusivamente del PDF **Anatomía de Clases, Puntos de Entrada y Memoria en C#**.

> **Fuente:** `../clases/Anatomía de Clases, Puntos de Entrada y Memoria en C#.pdf`

## Objetivo

El material propone comprobar experimentalmente la diferencia de comportamiento entre:

```text
struct → tipo por valor
class  → tipo por referencia
```

## Paso 1: estructuras de prueba

### Tipo por valor

```csharp
public struct Punto
{
    public int X { get; set; }
}
```

### Tipo por referencia

```csharp
public class Jugador
{
    public int Puntaje { get; set; }
}
```

## Paso 2: copiar y mutar

### Experimento con struct

```csharp
Punto p1 = new Punto { X = 10 };
Punto p2 = p1;
p2.X = 99;
```

Según el resultado mostrado por el material:

```text
p1.X = 10
```

La modificación realizada sobre `p2` no cambia `p1`.

### Experimento con class

```csharp
Jugador j1 = new Jugador { Puntaje = 10 };
Jugador j2 = j1;
j2.Puntaje = 99;
```

Según el resultado mostrado:

```text
j1.Puntaje = 99
```

La modificación realizada mediante `j2` es visible mediante `j1`.

## Explicación visual utilizada por el PDF

### Struct

```text
p1 ── valor 10

p2 = p1

p1 ── valor 10
p2 ── valor 10

p2.X = 99

p1 ── valor 10
p2 ── valor 99
```

El material describe esto como una copia/clonación de datos.

### Class

```text
j1 ─┐
    ├──▶ una instancia Jugador
j2 ─┘
```

Ambas variables se presentan como referencias a la misma instancia.

## Concepto de mutación compartida

Dentro del modelo enseñado:

- copiar un valor produce una copia independiente;
- copiar una referencia permite acceder al mismo estado compartido.

Por eso el PDF concluye que comprender esta diferencia es importante para evitar modificaciones inesperadas de datos.

## Alcance

Este documento conserva únicamente el experimento y su interpretación tal como aparecen en la fuente oficial.
