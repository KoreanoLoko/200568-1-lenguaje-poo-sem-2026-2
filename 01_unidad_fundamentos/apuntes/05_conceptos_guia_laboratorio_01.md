# Conceptos técnicos — Guía de Laboratorio 01

Apunte derivado exclusivamente de la **Guía de Laboratorio 01**.

> **Fuente:** `../ejercicios/guia_laboratorio_01/enunciado.md`

## Conceptos incorporados por la guía

Este laboratorio agrega contenidos prácticos que complementan los materiales anteriores:

1. Creación de una **Console App** en C#.
2. Uso de **Top-Level Statements**.
3. Primera compilación de la solución con `Ctrl + Shift + B`.
4. Reconocimiento de `.csproj`, `Program.cs`, `obj/` y `bin/`.
5. Uso de **File-scoped Namespace**.
6. Declaración de variables para datos simples.
7. Uso de **String Interpolation**.
8. Validación de compilación sin advertencias.

## Top-Level Statements

La guía indica mantener desmarcada la opción **Do not use top-level statements**.

El ejemplo base mostrado es:

```csharp
Console.WriteLine("Hello, World!");
```

Dentro del material, esta sintaxis representa un punto de entrada simplificado y evita declarar explícitamente una clase `Program` y un método `Main()`.

## Primera compilación

La guía utiliza:

```text
Ctrl + Shift + B
```

para compilar la solución.

El resultado esperado es una compilación correcta y la generación de las carpetas `bin/` y `obj/`.

## Anatomía del proyecto

```text
Proyecto
├── .csproj
├── Program.cs
├── obj/
└── bin/
```

Según la guía:

- `.csproj` configura el proyecto y sus dependencias.
- `Program.cs` contiene la lógica inicial.
- `obj/` almacena archivos intermedios de compilación.
- `bin/` almacena los binarios finales.

## File-scoped Namespace

La sintaxis mostrada es:

```csharp
namespace IPVG.ConstruccionSoftware.Sesion01;
```

La característica distintiva es el **punto y coma al final**.

La guía la utiliza para hacer que el archivo completo pertenezca a ese namespace sin agregar un bloque adicional de llaves.

## String Interpolation

La guía exige el uso de interpolación de cadenas para mostrar datos:

```csharp
Console.WriteLine($"Estudiante: {miNombre} | Carrera: {miCarrera}");
```

La sintaxis relevante es:

```text
$"... {variable} ..."
```

## Variables requeridas en el desafío

El ejercicio solicita trabajar con:

- `miNombre`.
- `miCarrera`.
- `miMetaSemestral`.

La guía indica escoger tipos de datos adecuados, pero no entrega una solución concreta ni fija explícitamente qué tipo debe utilizarse para cada variable.

## Reglas que deben respetarse al resolver ejercicios basados en esta guía

Cuando una solución se base en este laboratorio, debe respetar lo que la guía solicita:

- namespace `IPVG.ConstruccionSoftware.Sesion01`;
- File-scoped Namespace;
- String Interpolation;
- compilación correcta;
- ausencia de warnings;
- SDK .NET 10 o .NET 8.0 según disponibilidad.

## Alcance

Este apunte no resuelve el desafío y no agrega sintaxis que la guía no haya introducido.
