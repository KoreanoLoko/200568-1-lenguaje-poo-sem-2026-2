# 01 — Punto de entrada clásico: static void Main()

Apunte derivado exclusivamente del material oficial **Clases y objetos**.

> **Fuente:** `../clases/clases_y_objetos.md`

## Estructura clásica

El material utiliza la siguiente forma:

```csharp
using System;

namespace SistemaGestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Punto de entrada de la aplicación inicializado con éxito.");
        }
    }
}
```

La jerarquía puede representarse así:

```text
namespace
└── class Program
    └── static void Main(string[] args)
        └── instrucciones
```

## Componentes de la firma

| Elemento | Significado según el material |
| --- | --- |
| `static` | El método pertenece a la clase y no a una instancia. |
| `void` | No retorna un valor al finalizar. |
| `Main` | Punto de inicio de la ejecución. |
| `string[] args` | Argumentos recibidos desde la línea de comandos. |

## Case-sensitive

El material recalca que C# distingue entre mayúsculas y minúsculas.

Por eso, en este contexto:

```text
Main
```

no debe confundirse con:

```text
main
```

## Relación con materiales anteriores

La Guía de Laboratorio 01 introdujo **Top-Level Statements** como sintaxis simplificada.

Este material presenta ahora la forma **clásica y explícita** del punto de entrada:

```text
Top-Level Statements
vs.
class Program + static void Main(...)
```

Ambas formas quedan registradas en la fuente de verdad porque han sido mostradas oficialmente en la asignatura.

## Alcance

Este apunte no incorpora otras firmas posibles de `Main` ni variantes no enseñadas en el material.
