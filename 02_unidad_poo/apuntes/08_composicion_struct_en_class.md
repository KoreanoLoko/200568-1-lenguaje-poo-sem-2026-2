# 08 — Composición: struct embebido en una class

Apunte derivado exclusivamente de la **Guía de Laboratorio 04**.

> **Fuente:** `../ejercicios/guia_laboratorio_04/enunciado.md`

## Objetivo del laboratorio

La guía combina en una misma estructura de software:

```text
class BandejaAlmuerzo
        │
        └── contiene
              │
              ▼
        struct DetallePago
```

Con esto se trabajan simultáneamente:

- un tipo por referencia;
- un tipo por valor;
- composición entre tipos.

## Tipo por valor: DetallePago

La arquitectura solicitada es:

```csharp
public struct DetallePago
{
    public decimal Monto;
    public string MetodoPago;
}
```

La guía introduce explícitamente el tipo:

```csharp
decimal
```

para representar el monto del pago.

## Tipo por referencia: BandejaAlmuerzo

La guía solicita una clase con:

```csharp
public string Estudiante { get; set; }
public string MenuPrincipal { get; set; }
```

y un campo:

```csharp
public DetallePago Pago;
```

## Composición

`BandejaAlmuerzo` contiene un valor de tipo `DetallePago`.

Conceptualmente:

```text
BandejaAlmuerzo
├── Estudiante
├── MenuPrincipal
└── Pago
    ├── Monto
    └── MetodoPago
```

## Copia indicada por la guía

El laboratorio solicita copiar la bandeja mediante:

```csharp
bandeja2 = bandeja1;
```

y luego modificar datos desde `bandeja2`.

El propósito declarado por la actividad es analizar el comportamiento conjunto de:

- la referencia de la clase;
- el `struct` embebido.

## Datos concretos del ejercicio

### Estado inicial

```text
Estudiante: María Carrasco
Menú: Tallarines con salsa bolognesa
Monto: $3.500
Método de pago: Junaeb
```

### Cambios solicitados mediante bandeja2

```text
Estudiante: Pedro Soto
Monto: $4.000
Método de pago: Débito
```

## Pregunta conceptual de la guía

El material solicita analizar por qué:

- el nombre del estudiante cambia en ambas variables;
- el detalle de pago, definido como `struct`, presenta un comportamiento que debe ser contrastado al alterar la estructura completa.

La guía no entrega el código final ni una salida oficial con la cual resolver esa pregunta. Por lo tanto, este apunte registra el **problema conceptual planteado**, pero no agrega una conclusión externa.

## Relación con materiales anteriores

Este laboratorio amplía los ejemplos previos de:

- `struct` frente a `class`;
- copia por valor frente a copia de referencia;
- estado compartido.

La diferencia es que ahora ambos conceptos se combinan dentro de una misma entidad mediante **composición**.

## Conceptos nuevos o reforzados

- `decimal`;
- composición;
- `struct` embebido dentro de una `class`;
- campos públicos de tipo definido por el usuario;
- modificación de datos a través de una referencia de clase;
- análisis de alias y estado compuesto.

## Alcance

Este apunte preserva la formulación oficial de la guía. No incorpora una resolución que el material no proporcione.
