# 16 — Estado global static y estado individual en objetos

Apunte derivado exclusivamente de la **Guía de Laboratorio 06**.

> **Fuente:** `../ejercicios/guia_laboratorio_06/enunciado.md`

## Objetivo

La guía utiliza un sistema de estacionamiento para contrastar:

```text
estado de cada objeto
vs.
estado global compartido por la clase
```

## Estado individual

Cada `VehiculoEstacionado` conserva:

```csharp
Patente
MinutosTranscurridos
EstaPagado
```

Esto permite que tres objetos tengan tiempos y estados diferentes.

## Estado estático global

La clase comparte:

```csharp
tarifaPorMinuto
totalRecaudadoGlobal
vehiculosEstacionadosActualmente
```

Estos valores no pertenecen a un vehículo particular.

## Constructor y contador global

Cada vez que se crea un objeto:

```csharp
vehiculosEstacionadosActualmente++;
```

Por tanto, crear tres vehículos produce un contador global de tres activos.

## Procesamiento de salida

Al procesar una salida por primera vez:

```csharp
vehiculosEstacionadosActualmente--;
totalRecaudadoGlobal += costoServicio;
```

Esto modifica datos compartidos por todas las instancias.

## Prevención de doble cobro

```csharp
if (EstaPagado)
{
    return 0.00m;
}
```

La propiedad `EstaPagado` funciona como estado interno que evita procesar dos veces la misma salida.

## Operador ternario

La guía incorpora:

```csharp
string estado = EstaPagado ? "PAGADO" : "ACTIVO EN SEDE";
```

Su estructura es:

```text
condición ? valor_si_verdadero : valor_si_falso
```

## Normalización con ToUpper

El constructor utiliza:

```csharp
Patente = patente.ToUpper();
```

para convertir la patente recibida a mayúsculas.

## Formato N2

Los valores monetarios se imprimen con:

```csharp
:N2
```

por ejemplo:

```csharp
$"{totalRecaudadoGlobal:N2}"
```

## decimal en el cálculo

El costo se calcula mediante:

```csharp
decimal costoServicio = MinutosTranscurridos * tarifaPorMinuto;
```

La fuente mantiene `decimal` para tarifa, costo y acumulador global.

## Flujo global del ejemplo

```text
crear auto1, auto2, auto3
        ↓
activos globales = 3
        ↓
registrar minutos individuales
        ↓
procesar auto1
activos = 2
recaudación += pago1
        ↓
procesar auto3
activos = 1
recaudación += pago3
        ↓
intento doble sobre auto1
sin nuevo cobro
        ↓
procesar auto2
activos = 0
recaudación += pago2
```

## Conceptos habilitados por este material

- operador ternario `?:`;
- `ToUpper()`;
- estado individual vs. estado global;
- contador estático dinámico;
- prevención de doble procesamiento;
- formato `:N2`;
- múltiples objetos independientes que afectan estadísticas compartidas.

## Alcance

Este apunte conserva únicamente las técnicas demostradas en la Guía de Laboratorio 06.
