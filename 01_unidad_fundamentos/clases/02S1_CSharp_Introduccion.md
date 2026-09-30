# 02S1 — Instalación y Primer Contacto con C#

Documento derivado exclusivamente del material oficial **02S1_C#_Introducción.pdf**.

> **Fuente original prevista en el repositorio:** `01_unidad_fundamentos/clases/02S1_C#_Introducción.pdf`

## Identificación de la clase

- **Asignatura:** Programación Orientada a Objetos
- **Material:** 02S1
- **Tema:** Instalación y Primer Contacto con C#
- **Subtítulo:** Configurando nuestro entorno para la Programación Orientada a Objetos
- **Docente indicado:** Profesor Gastón González P.
- **Institución:** Instituto Profesional Virginio Gómez - Universidad de Concepción
- **Extensión del material:** 6 páginas

## Propósito del material

La presentación introduce el entorno inicial de trabajo en C# y muestra cómo se organiza una aplicación de consola básica antes de comenzar a escribir lógica más compleja.

## Mapa del contenido

| Página | Tema |
| ---: | --- |
| 1 | Instalación y primer contacto con C#: configuración del entorno. |
| 2 | Creación de un nuevo proyecto usando la plantilla Console App y C# como lenguaje base. |
| 3 | Estructura de la solución: archivo `.sln`, proyecto `.csproj` y archivo `Program.cs`. |
| 4 | Estructura de `Program.cs`: `namespace`, `class Program` y `static void Main()`. |
| 5 | Ciclo de desarrollo: escribir código fuente, compilar y ejecutar en consola. |
| 6 | Resumen de herramientas: Visual Studio, Console App y `Main()` como punto de entrada. |

## Flujo inicial para crear un proyecto

El material representa la creación del primer proyecto de esta forma:

```text
Nuevo Proyecto
     ↓
Console App
     ↓
Lenguaje base: C#
```

## Estructura presentada

La clase distingue tres elementos principales:

- **`Nombre.sln`**: representa la solución completa.
- **`Nombre.csproj`**: representa el proyecto que agrupa la aplicación.
- **`Program.cs`**: archivo donde se escribe la lógica del programa.

La presentación utiliza una analogía visual:

- La solución es **el maletín**, porque contiene todo.
- El proyecto es **la carpeta**, porque agrupa la aplicación.
- `Program.cs` es **el documento**, porque allí se escribe la lógica.

## Estructura básica de Program.cs

El material presenta tres niveles:

```text
namespace
└── class Program
    └── static void Main()
```

La analogía utilizada es:

- `namespace`: **el barrio**.
- `class Program`: **el edificio**.
- `static void Main()`: **la puerta de entrada**.

La clase enfatiza que el programa comienza a ejecutarse desde el método `Main`.

## Ciclo de desarrollo

La presentación resume el trabajo en un ciclo continuo:

```text
Escribir código fuente
        ↓
Compilar / traducir
        ↓
Ejecutar en consola
        ↺
```

## Herramientas destacadas

Al cierre del material se resumen tres elementos:

| Elemento | Función indicada |
| --- | --- |
| Visual Studio | Herramienta o taller digital configurado. |
| Console App | Plantilla base para trabajar sin distracciones. |
| `Main()` | Punto de entrada desde donde comienza la ejecución. |

## Apuntes derivados

El contenido se documenta además en:

- `01_unidad_fundamentos/apuntes/03_estructura_solucion_proyecto_csharp.md`
- `01_unidad_fundamentos/apuntes/04_program_cs_y_ciclo_desarrollo.md`

## Alcance

Este documento conserva únicamente los conceptos mostrados en la presentación. No agrega estructuras modernas alternativas de C#, variantes de plantillas, top-level statements ni detalles internos de MSBuild que no aparecen en el material.
