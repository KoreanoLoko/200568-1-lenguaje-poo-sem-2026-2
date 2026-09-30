# Guía de Laboratorio 08

Material oficial transcrito desde la tarea **Guía de Laboratorio 08** publicada en Canvas para la asignatura.

## Datos de la actividad

- **Fecha de entrega:** no hay fecha de entrega.
- **Puntos:** 0.
- **Calificación:** la tarea no cuenta para la calificación final.

# Planteamiento de Negocio: Sistema de Simulación de Créditos

La guía plantea una aplicación de consola en C# para simular cuotas de créditos de consumo dentro de un escenario financiero.

El sistema debe trabajar con:

- saldo acumulado;
- cálculo de intereses;
- validación de montos aprobados;
- métodos con parámetros por valor;
- parámetros `ref`;
- parámetros `out`;
- retorno booleano.

## Guía Paso a Paso del Laboratorio Guiado

### Paso 1: Crear el proyecto

Crear un directorio de trabajo denominado:

```text
SimuladorCredito
```

### Paso 2: Declarar la clase de negocio

Crear:

```text
ProcesadorCredito.cs
```

La clase utiliza:

- propiedades autoimplementadas;
- métodos utilitarios;
- firmas con modificadores de parámetros.

### Paso 3: Implementar firmas de métodos

La guía solicita:

1. un método que acumule montos mediante `ref`;
2. un método que realice el desglose de un crédito;
3. retorno de aprobación mediante `bool`;
4. devolución de valores desglosados mediante `out`.

# Código Fuente de ProcesadorCredito.cs

El código oficial se conserva en:

```text
ejemplo_oficial/ProcesadorCredito.cs
```

## Propiedad autoimplementada

```csharp
public string NombreCliente { get; set; }
```

## Método 1 — Parámetros por valor

```csharp
public decimal CalcularInteresSimple(
    decimal capital,
    decimal tasaAnual,
    int meses)
```

La fuente indica que `capital`, `tasaAnual` y `meses` se copian por valor.

El cálculo mostrado es:

```csharp
decimal interesFraction = tasaAnual / 100 / 12;
return capital * interesFraction * meses;
```

## Método 2 — Acumulación histórica con ref

```csharp
public void RegistrarOperacionHistorica(
    ref decimal acumuladorSaldos,
    decimal nuevoMonto)
```

La guía enfatiza que:

```csharp
acumuladorSaldos
```

debe estar inicializado fuera del método antes de utilizarse con `ref`.

La mutación se realiza mediante:

```csharp
acumuladorSaldos += nuevoMonto;
```

## Método 3 — Evaluación con múltiples out

La firma oficial es:

```csharp
public bool EvaluarCredito(
    decimal sueldoCliente,
    decimal montoSolicitado,
    int cuotas,
    out decimal valorCuotaBase,
    out decimal interesTotal)
```

La guía utiliza una tasa simulada fija:

```csharp
decimal tasaSimulada = 1.8m;
```

y calcula:

```csharp
interesTotal = montoSolicitado * (tasaSimulada / 100) * cuotas;
decimal totalAPagar = montoSolicitado + interesTotal;
valorCuotaBase = totalAPagar / cuotas;
```

## Regla de aprobación

La regla organizacional indicada es:

> La cuota no debe exceder el 30% del sueldo.

Se implementa mediante:

```csharp
decimal limiteCuota = sueldoCliente * 0.30m;
return valorCuotaBase <= limiteCuota;
```

# Desafío Autónomo e Individual

La guía presenta este desafío como preparación formativa en vísperas del Certamen 1.

## Requerimiento 1 — Interacción en Program.cs

Solicitar por consola:

- nombre del cliente;
- sueldo líquido;
- monto del crédito;
- cantidad de cuotas.

## Requerimiento 2 — Control de acumulación

Crear en `Main`:

```csharp
decimal montoTotalBanco = 0.0m;
```

y pasarlo mediante `ref` a:

```csharp
RegistrarOperacionHistorica
```

para observar la mutación del acumulador.

## Requerimiento 3 — Salidas con out

Invocar:

```csharp
EvaluarCredito
```

con variables sin inicialización previa para recibir:

- valor de la cuota;
- interés generado.

# Propuesta de Solución Sugerida

Canvas incluye una **Propuesta de Solución Sugerida** para `Program.cs`.

Se conserva separada en:

```text
solucion_sugerida/Program.cs
```

La solución utiliza:

- `Convert.ToDecimal(Console.ReadLine())`;
- `Convert.ToInt32(Console.ReadLine())`;
- variables `out` declaradas sin inicialización;
- llamada a `EvaluarCredito`;
- llamada condicional a `RegistrarOperacionHistorica`;
- formato monetario `:N2`;
- `Console.ReadKey()`.

## Flujo de aprobación

```text
leer datos
   ↓
EvaluarCredito(...)
   ↓
bool aprobado
   ├── true
   │    ├── RegistrarOperacionHistorica(ref montoTotalBanco, monto)
   │    └── mostrar cuota, interés y total
   │
   └── false
        └── mostrar rechazo y límite del 30%
```

## Observaciones de fidelidad

- El método `CalcularInteresSimple` aparece en `ProcesadorCredito.cs`, pero la propuesta de `Program.cs` no lo invoca.
- La fuente utiliza `Convert.ToDecimal` y `Convert.ToInt32` en la solución sugerida, aunque materiales anteriores también han utilizado `Parse` y `TryParse`.
- La guía utiliza el término **amortización** para el caso de estudio, pero el código mostrado calcula los valores exactamente con las fórmulas incluidas en Canvas. No se reemplazan ni reinterpretan esas fórmulas.

## Relación con Certamen 1

El desafío también queda registrado como material de preparación en:

```text
03_certamen_1/ejercicios/desafio_pre_certamen_1_simulador_credito.md
```

## Conceptos incorporados o reforzados

- paso por valor;
- `ref`;
- múltiples parámetros `out`;
- retorno `bool`;
- acumulador por referencia;
- `decimal`;
- regla de negocio;
- porcentaje con `0.30m`;
- `Convert.ToDecimal`;
- `Convert.ToInt32`;
- formato `:N2`;
- propiedad autoimplementada;
- métodos de negocio;
- separación entre clase de negocio y `Program.cs`.

## Alcance

Este documento conserva el enunciado, código oficial y solución sugerida de la Guía de Laboratorio 08 sin sustituir sus cálculos por fórmulas externas.
