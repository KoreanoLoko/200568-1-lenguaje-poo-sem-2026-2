# Desafío Pre-Certamen 1 — Simulador de Crédito

Fuente: **Guía de Laboratorio 08**.

## Contexto

La guía presenta este desafío como evaluación formativa previa al Certamen 1.

El proyecto base es:

```text
SimuladorCredito
```

con la clase:

```text
ProcesadorCredito
```

## Requerimiento 1 — Interacción en Program.cs

Solicitar por consola:

- nombre del cliente;
- sueldo líquido;
- monto solicitado;
- cantidad de cuotas.

## Requerimiento 2 — Control de acumulación con ref

Definir:

```csharp
decimal montoTotalBanco = 0.0m;
```

e invocar:

```csharp
RegistrarOperacionHistorica(
    ref montoTotalBanco,
    monto)
```

para verificar la mutación del acumulador.

## Requerimiento 3 — Salidas con out

Declarar variables sin inicialización previa para recibir:

- cuota calculada;
- intereses totales.

Invocar:

```csharp
EvaluarCredito(
    sueldo,
    monto,
    cuotas,
    out valorCuota,
    out interesGenerado)
```

## Veredicto

El programa debe mostrar si la simulación fue:

```text
APROBADA
```

o:

```text
RECHAZADA
```

La regla de aprobación entregada por la guía es que la cuota no supere el 30% del sueldo.

## Solución sugerida disponible

La propia Guía de Laboratorio 08 incluye una **Propuesta de Solución Sugerida** para `Program.cs`, conservada en:

```text
02_unidad_poo/ejercicios/guia_laboratorio_08/solucion_sugerida/Program.cs
```

Este archivo de Certamen registra el desafío como material de preparación y no duplica toda la solución.

## Conceptos que prepara

- paso por valor;
- `ref`;
- `out`;
- retorno `bool`;
- variables `decimal`;
- regla de negocio;
- acumulación histórica;
- interacción de consola;
- separación entre lógica de negocio y punto de entrada.
