# 04 — Program.cs y ciclo básico de desarrollo

Apunte derivado exclusivamente del material oficial **02S1 — Instalación y Primer Contacto con C#**.

> **Fuente:** `../clases/02S1_C#_Introducción.pdf`

## Estructura de Program.cs

La presentación utiliza el siguiente esquema:

```text
namespace
└── class Program
    └── static void Main()
```

Cada elemento se explica mediante una analogía.

### namespace — El barrio

El `namespace` corresponde al nivel exterior que contiene los elementos del programa presentados en la clase.

### class Program — El edificio

La clase `Program` se encuentra dentro del `namespace`.

### static void Main() — La puerta de entrada

El método `Main()` se encuentra dentro de la clase `Program`.

El material enfatiza:

> Todo programa en C# comienza a ejecutarse desde el método Main.

Por lo tanto, dentro del modelo enseñado en esta clase, `Main()` es el **punto de entrada** de la aplicación.

## Jerarquía visual

```text
namespace
│
└── class Program
    │
    └── static void Main()
        │
        └── instrucciones del programa
```

## Ciclo básico de desarrollo

La presentación muestra un proceso circular compuesto por tres etapas:

1. **Escribir** código fuente.
2. **Compilar** o traducir el código.
3. **Ejecutar** el programa en la consola.

```text
Escribir
   ↓
Código fuente
   ↓
Compilar
   ↓
Ejecutar
   ↓
Consola
   ↺
```

La forma circular del diagrama transmite que el desarrollo es iterativo: después de ejecutar, se vuelve a escribir o modificar el código y se repite el proceso.

## Resumen de herramientas

| Concepto | Descripción mostrada en la clase |
| --- | --- |
| Visual Studio | Herramienta utilizada como entorno de trabajo. |
| Console App | Plantilla base de la aplicación. |
| `Main()` | Punto de entrada del programa. |

## Límites de este apunte

Este documento no incorpora top-level statements, métodos alternativos de entrada, argumentos de línea de comandos ni variantes modernas de la plantilla Console App, porque esos contenidos no aparecen en el material analizado.
