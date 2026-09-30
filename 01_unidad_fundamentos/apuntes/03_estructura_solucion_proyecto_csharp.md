# 03 — Estructura de una solución y proyecto C#

Apunte derivado exclusivamente del material oficial **02S1 — Instalación y Primer Contacto con C#**.

> **Fuente:** `../clases/02S1_C#_Introducción.pdf`

## Creación del proyecto

La presentación muestra el flujo inicial:

```text
Nuevo Proyecto
     ↓
Console App
     ↓
C#
```

El objetivo es comenzar desde una aplicación de consola como estructura base.

## Archivos principales

La clase presenta tres elementos:

### 1. Solución — `Nombre.sln`

La solución se representa como **el maletín**.

Según la analogía de la presentación:

> Contiene absolutamente todo.

Su función dentro del esquema enseñado es representar el nivel superior que contiene la estructura completa de trabajo.

### 2. Proyecto — `Nombre.csproj`

El proyecto se representa como **la carpeta**.

Según el material:

> Agrupa nuestra aplicación.

Dentro de la jerarquía mostrada, el archivo `.csproj` pertenece a la solución y representa el proyecto de la aplicación.

### 3. Archivo de código — `Program.cs`

`Program.cs` se representa como **el documento**.

Según el material:

> Donde escribimos la lógica.

La estructura visual de la clase se puede resumir así:

```text
Nombre.sln
└── Nombre.csproj
    └── Program.cs
```

## Conceptos que deben distinguirse

| Elemento | Extensión | Rol según el material |
| --- | --- | --- |
| Solución | `.sln` | Contiene la estructura completa. |
| Proyecto | `.csproj` | Agrupa la aplicación. |
| Código fuente | `.cs` | Contiene la lógica escrita en C#. |

## Regla para esta asignatura

Al trabajar los ejercicios iniciales conviene reconocer siempre en qué nivel estamos trabajando:

- Solución.
- Proyecto.
- Archivo de código.

Este apunte mantiene exactamente la estructura conceptual presentada por el docente y no incorpora detalles adicionales sobre configuración de proyectos.
