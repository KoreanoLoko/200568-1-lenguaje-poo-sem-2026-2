# 23 — Simulador de crédito: valor, ref, out y regla del 30%

Apunte derivado exclusivamente de la **Guía de Laboratorio 08**.

> **Fuente:** `../ejercicios/guia_laboratorio_08/enunciado.md`

## Tres mecanismos en una misma clase

`ProcesadorCredito` utiliza:

```text
por valor
ref
out
```

en tres métodos distintos.

## Paso por valor

```csharp
public decimal CalcularInteresSimple(
    decimal capital,
    decimal tasaAnual,
    int meses)
```

Los tres parámetros se reciben por valor.

La fórmula entregada por la guía es:

```csharp
decimal interesFraction = tasaAnual / 100 / 12;
return capital * interesFraction * meses;
```

## Acumulación mediante ref

```csharp
public void RegistrarOperacionHistorica(
    ref decimal acumuladorSaldos,
    decimal nuevoMonto)
```

La variable externa debe inicializarse antes:

```csharp
decimal montoTotalBanco = 0.0m;
```

y luego puede modificarse:

```csharp
acumuladorSaldos += nuevoMonto;
```

## Evaluación mediante out

```csharp
public bool EvaluarCredito(
    decimal sueldoCliente,
    decimal montoSolicitado,
    int cuotas,
    out decimal valorCuotaBase,
    out decimal interesTotal)
```

Los dos parámetros `out` son asignados dentro del método.

## Retorno principal y resultados adicionales

El método genera:

```text
bool
→ aprobación o rechazo

out valorCuotaBase
→ cuota calculada

out interesTotal
→ interés total
```

## Regla del 30%

La guía define:

```csharp
decimal limiteCuota = sueldoCliente * 0.30m;
return valorCuotaBase <= limiteCuota;
```

La aprobación depende de que la cuota calculada no supere el 30% del sueldo.

## Convert

La propuesta sugerida incorpora:

```csharp
Convert.ToDecimal(Console.ReadLine())
Convert.ToInt32(Console.ReadLine())
```

Por lo tanto, `Convert.ToDecimal` y `Convert.ToInt32` quedan respaldados por este material como mecanismos utilizados en la asignatura.

## Formato monetario

La salida utiliza:

```csharp
:N2
```

para mostrar dos decimales.

## Separación de responsabilidades

```text
ProcesadorCredito
→ lógica de negocio

Program
→ entrada, invocación y presentación
```

## Particularidad del material

`CalcularInteresSimple` está definido como parte de la clase, pero no se utiliza en la propuesta de `Program.cs`.

Este apunte registra esa situación sin completar llamadas adicionales.

## Alcance

Se conserva exactamente la lógica y las reglas presentadas en la Guía de Laboratorio 08.
