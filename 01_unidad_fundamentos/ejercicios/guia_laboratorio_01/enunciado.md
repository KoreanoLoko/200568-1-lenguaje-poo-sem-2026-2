# Guía de Laboratorio 01

Material oficial transcrito desde la tarea **Guía de Laboratorio 01** publicada en Canvas para la asignatura.

## Datos de la actividad

- **Calificación:** esta tarea no cuenta para la calificación final.
- **Fecha de entrega:** 21 de agosto, 23:59.
- **Puntos:** 0.
- **Tipo de entrega:** carga de archivo.
- **Disponible hasta:** 21 de agosto, 23:59.
- **Estado indicado:** la tarea fue bloqueada el 21 de agosto a las 23:59.

## Paso 1: Creación del Proyecto Base

1. Iniciar Visual Studio 2026 y seleccionar **Crear un proyecto**.
2. Elegir la plantilla **Aplicación de consola** (C#).
3. Asignar un nombre profesional, por ejemplo: `Sesion01_GestionSoftware`.
4. En **Información Adicional**, seleccionar **.NET 10.0**. Si no está disponible, utilizar **.NET 8.0**.
5. Mantener desmarcada la opción **Do not use top-level statements (No usar instrucciones de nivel superior)** para utilizar la sintaxis simplificada de .NET.

El código base indicado por la guía utiliza **Top-Level Statements**:

```csharp
// Punto de entrada simplificado en .NET 10
Console.WriteLine("Hello, World!");
```

## Paso 2: Primera Compilación

Antes de analizar la estructura interna, la guía solicita visualizar los archivos generados.

Si es necesario generar los archivos binarios:

1. Presionar `Ctrl + Shift + B` para compilar la solución.
2. Observar la ventana de salida para confirmar que el proceso finalizó correctamente.

La compilación debe generar o poblar las carpetas de sistema del proyecto.

## Paso 3: Análisis de la Anatomía del Proyecto

La guía define los siguientes elementos:

| Elemento | Propósito técnico indicado |
| --- | --- |
| `.csproj` | Archivo de configuración XML. Define el Framework (.NET) y gestiona las dependencias del proyecto. |
| `Program.cs` | Archivo de código fuente principal. Implementa la lógica de inicio del software. |
| `obj/` | Carpeta de objetos. Contiene archivos intermedios necesarios para el proceso de compilación. |
| `bin/` | Carpeta de binarios. Contiene los archivos ejecutables (`.exe`) y librerías finales de la aplicación. |

## Paso 4: Organización mediante Namespaces

La guía introduce el **espacio de nombres con ámbito de archivo (File-scoped Namespace)** para evitar niveles innecesarios de indentación y hacer que el archivo completo pertenezca a un espacio de nombres.

El ejemplo indicado es:

```csharp
// Definición de espacio de nombres con ámbito de archivo
// (Nota el punto y coma al final)
namespace IPVG.ConstruccionSoftware.Sesion01;

// La lógica del programa se mantiene limpia y organizada
Console.WriteLine("Entorno IPVG configurado exitosamente.");
```

La guía exige comprobar que el código compile correctamente y corregirlo en caso contrario.

## Desafío práctico: "Mi Primera Interacción"

Se solicita modificar `Program.cs` para cumplir los siguientes requerimientos.

### 1. Variables

Declarar variables con tipos de datos adecuados para almacenar:

- `miNombre`.
- `miCarrera`.
- `miMetaSemestral` (calificación promedio).

### 2. Lógica de salida

Utilizar **String Interpolation** para mostrar la información.

Ejemplo de sintaxis requerida:

```csharp
// Ejemplo de Interpolación de Cadenas (String Interpolation)
Console.WriteLine($"Estudiante: {miNombre} | Carrera: {miCarrera}");
```

## Restricciones

- El código debe residir dentro del namespace `IPVG.ConstruccionSoftware.Sesion01`.
- Debe compilar sin advertencias (*warnings*).

## Criterios de autoevaluación

La entrega debe cumplir con los siguientes puntos:

- El proyecto utiliza el SDK de **.NET 10 / .NET 8.0** y compila correctamente.
- Se implementó un **File-scoped Namespace** siguiendo la jerarquía institucional.
- El código utiliza **String Interpolation** para la salida de datos.
- Las carpetas `bin` y `obj` fueron generadas mediante una compilación exitosa.

## Alcance de este archivo

Este documento conserva el contenido técnico y administrativo de la guía. No incluye una solución del desafío práctico; cualquier implementación se documentará por separado.
