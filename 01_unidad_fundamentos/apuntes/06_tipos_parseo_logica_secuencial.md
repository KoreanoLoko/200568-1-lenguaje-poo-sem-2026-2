# 06 — Tipos de datos, parseo y lógica secuencial

Apunte derivado exclusivamente de la **Guía de Laboratorio 02**.

> **Fuente:** `../ejercicios/guia_laboratorio_02/enunciado.md`

## Tipado fuerte

La guía presenta a C# como un lenguaje de **tipado fuerte**. En el nivel trabajado aquí, cada variable posee un tipo conocido en tiempo de compilación.

Se muestran dos formas de declaración:

### Tipo explícito

```csharp
string nombreDesarrollador;
int horasEstimadas;
double valorHora;
bool estado;
```

### Inferencia con var

```csharp
var cotizacionEsViable = totalCotizacion > 0;
```

La guía utiliza `var` como inferencia de tipo realizada por el compilador.

## Convención camelCase

Los nombres de variables se escriben siguiendo la convención institucional **camelCase**.

Ejemplos tomados del material:

```text
nombreDesarrollador
nombreProyecto
horasEstimadas
valorHora
subtotalNeto
impuestoIva
totalCotizacion
```

## Tipos de datos trabajados

| Tipo | Ejemplo de uso en la guía |
| --- | --- |
| `string` | nombres, títulos y entradas leídas desde consola |
| `int` | cantidad de horas o cantidades enteras |
| `double` | valores monetarios, tarifas y resultados decimales |
| `bool` | estados verdadero/falso |

## Entrada de datos

La instrucción presentada es:

```csharp
Console.ReadLine()
```

La guía enseña que su resultado se trabaja como texto (`string`).

## Parseo

Para transformar una entrada textual a un número se presentan:

```csharp
int.Parse(texto)
double.Parse(texto)
```

Ejemplo del material:

```csharp
string entradaHoras = Console.ReadLine();
int horasEstimadas = int.Parse(entradaHoras);

string entradaValorHora = Console.ReadLine();
double valorHora = double.Parse(entradaValorHora);
```

La guía advierte específicamente que `int.Parse` genera un error de ejecución cuando el texto no es numérico.

## Lógica secuencial

La secuencia se ejecuta de arriba hacia abajo.

El patrón utilizado es:

```text
Entrada
  ↓
Conversión
  ↓
Cálculo
  ↓
Salida
```

### Ejemplo de cálculos del material

```csharp
double subtotalNeto = horasEstimadas * valorHora;
double tasaIva = 0.19;
double impuestoIva = subtotalNeto * tasaIva;
double totalCotizacion = subtotalNeto + impuestoIva;
```

## Operadores utilizados

En esta guía aparecen operaciones como:

- multiplicación: `*`;
- suma: `+`;
- comparación mayor que: `>`.

El ejemplo:

```csharp
var cotizacionEsViable = totalCotizacion > 0;
```

produce un valor booleano.

## Interpolación y formato monetario

La guía reutiliza **String Interpolation** y agrega formato en la salida:

```csharp
Console.WriteLine($"Valor por Hora: {valorHora:C0} CLP");
```

El material utiliza `:C0` como parte del formato de presentación monetaria.

## Console.ReadKey

El ejemplo finaliza con:

```csharp
Console.ReadKey();
```

después de solicitar al usuario presionar una tecla para salir.

## Desafío autónomo

El desafío aplica exactamente la misma lógica secuencial a un problema de licenciamiento:

```text
cantidad de licencias
        ×
precio unitario
        ↓
subtotal bruto
        ↓
descuento
        ↓
subtotal con descuento
        ↓
IVA 19%
        ↓
total final
```

La guía entrega los requerimientos del cálculo, pero la solución del desafío no forma parte de este apunte.

## Alcance

Este documento conserva únicamente las técnicas introducidas por la Guía de Laboratorio 02. No agrega validación con `TryParse`, estructuras condicionales ni manejo de excepciones porque no forman parte del material proporcionado.
