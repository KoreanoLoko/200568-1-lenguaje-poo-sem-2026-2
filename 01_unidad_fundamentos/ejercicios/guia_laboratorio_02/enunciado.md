# Guía de Laboratorio 02

Material oficial transcrito desde la tarea **Guía de Laboratorio 02** publicada en Canvas para la asignatura.

## Datos de la actividad

- **Fecha de entrega:** 21 de agosto, 23:59.
- **Puntos:** 0.
- **Tipo de entrega:** carga de archivo.
- **Disponible hasta:** 21 de agosto, 23:59.
- **Estado indicado:** la tarea fue bloqueada el 21 de agosto a las 23:59.
- **Calificación:** la tarea no cuenta para la calificación final.

## Propósito

La guía propone construir una solución secuencial para automatizar el cálculo de honorarios de un desarrollador de software de manera ordenada y robusta.

## Paso 1: Definición de Variables y Tipos de Datos Primitivos

La guía caracteriza a C# como un lenguaje de **tipado fuerte**: cada variable debe poseer un tipo de dato definido en tiempo de compilación.

También introduce dos formas de declarar variables:

- declaración explícita del tipo;
- uso de la palabra reservada `var` para que el compilador infiera el tipo.

Se establece como convención institucional el uso de **camelCase**, por ejemplo:

```text
nombreUsuario
```

### Tipos de datos utilizados

| Tipo | Uso indicado por la guía |
| --- | --- |
| `string` | Cadenas de caracteres o textos. |
| `int` | Números enteros, como cantidades u horas. |
| `double` | Números con decimales, como tarifas. |
| `bool` | Valores booleanos: verdadero/falso. |

## Paso 2: Entrada de Datos y Parseo

La guía establece que:

```csharp
Console.ReadLine()
```

lee el texto ingresado por el usuario y retorna un `string`.

Cuando el valor debe utilizarse en una operación matemática, el texto debe convertirse al tipo numérico correspondiente. Este proceso se denomina **parseo** o conversión explícita.

### Métodos presentados

```csharp
int.Parse(texto)
double.Parse(texto)
```

Según la guía:

- `int.Parse(texto)` convierte texto a entero y genera un error de ejecución si el texto no es numérico.
- `double.Parse(texto)` convierte texto a número decimal.

## Paso 3: Desarrollo de la Lógica Secuencial

La guía define que las instrucciones secuenciales se ejecutan **de arriba hacia abajo, una tras otra**.

El ejemplo práctico solicita:

1. capturar datos del desarrollador y del proyecto;
2. capturar horas estimadas y valor por hora;
3. convertir las entradas numéricas;
4. calcular el subtotal neto;
5. calcular IVA del 19%;
6. obtener el total de la cotización;
7. inferir un estado booleano de viabilidad mediante `var`;
8. presentar un reporte con interpolación de cadenas y formato de moneda.

El código completo entregado por la guía se conserva en:

`ejemplo_oficial/Program.cs`

## Código fuente oficial de ejemplo

La guía entrega un programa completo para una cotización de honorarios de software. Este código se conserva sin convertirlo en solución del desafío autónomo.

### Datos de entrada

- nombre completo del desarrollador/a;
- título del proyecto;
- horas estimadas;
- valor por hora en CLP.

### Cálculos

```text
subtotalNeto = horasEstimadas * valorHora
impuestoIva = subtotalNeto * 0.19
totalCotizacion = subtotalNeto + impuestoIva
```

### Inferencia de tipo

La guía incluye:

```csharp
var cotizacionEsViable = totalCotizacion > 0;
```

### Salida con formato

El ejemplo utiliza interpolación de cadenas y el formato `:C0` en valores monetarios.

## 5. Desafío Práctico Autónomo

### Reto: Calculadora de Descuentos para Licenciamiento de Software

Una distribuidora de licencias de bases de datos requiere calcular la cotización formal de un cliente.

El programa debe solicitar:

1. nombre de la empresa cliente;
2. cantidad de licencias corporativas requeridas;
3. precio unitario de lista por licencia en CLP;
4. porcentaje de descuento comercial ingresado como entero, por ejemplo `10` para representar 10%.

El sistema debe calcular y mostrar:

- subtotal bruto de la compra: licencias × precio;
- monto en pesos del descuento;
- nuevo subtotal con descuento;
- IVA del 19% calculado sobre el subtotal con descuento;
- total final neto a facturar al cliente.

## Alcance de este archivo

Este documento conserva el contenido de la guía y su código de ejemplo oficial. **No contiene la solución del desafío práctico autónomo**. Si se documenta la solución desarrollada por el estudiante, deberá mantenerse separada del material oficial.
