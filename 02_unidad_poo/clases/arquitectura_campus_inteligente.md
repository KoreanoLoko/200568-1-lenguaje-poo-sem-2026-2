# Arquitectura de Software para un Campus Inteligente

Documentación derivada del PDF oficial **Arquitectura_Campus_Inteligente.pdf**.

## Identificación del material

- **Título:** Arquitectura de Software para un Campus Inteligente.
- **Carrera:** Ingeniería de Ejecución en Computación e Informática.
- **Semana:** 6.
- **Asignatura:** Lenguaje de Programación OO (0568).
- **Plataforma indicada:** C# y .NET 8.
- **Proyecto central:** Sistema de Gestión de Lockers y Módulos IPVG.
- **Extensión:** 18 páginas.
- **Naturaleza del archivo:** presentación visual sin capa de texto extraíble; la documentación se realizó a partir de las diapositivas renderizadas.

# 1. Encargo institucional

El material plantea como problema central la modernización de la infraestructura de la sede IPVG mediante la digitalización de la asignación y gestión de lockers.

Los atributos esperados del sistema son:

- rapidez;
- seguridad;
- escalabilidad para soportar la matrícula actual y futura.

La presentación utiliza este caso para integrar conocimientos ya trabajados:

- gestión de memoria Stack/Heap;
- parámetros avanzados `ref` / `out`;
- tipos por valor y tipos por referencia;
- estado global mediante `static`;
- encapsulamiento con `private set`.

# 2. Zonificación de memoria: Stack vs. Heap

El PDF utiliza una analogía física del campus.

## Stack

El Stack se presenta como una zona:

- rápida;
- estructurada;
- de tamaño fijo.

La diapositiva ubica allí, dentro de su modelo didáctico:

- tipos por valor como `struct`, `int` y `bool`;
- referencias a objetos.

## Heap

El Heap se presenta como una zona:

- dinámica;
- administrada por el Garbage Collector;
- destinada a los datos de tipos por referencia.

Ejemplo visual:

```csharp
new Locker("L-001")
```

# 3. Cimientos de la clase Locker

La presentación resume tres pilares en una clase `Locker`.

## Encapsulamiento

Ejemplo:

```csharp
public string Codigo { get; private set; }
```

La intención declarada es impedir que el código del locker sea alterado arbitrariamente desde fuera después de su inicialización.

## Miembro estático

Ejemplo:

```csharp
private static int totalLockers = 0;
```

El material lo interpreta como un dato perteneciente al sistema global y no a un locker individual.

## Parámetros avanzados

Ejemplo mostrado:

```csharp
public bool Asignar(
    ref Estudiante e,
    out string clave)
```

La presentación asocia:

- `ref` con la modificación bidireccional de un argumento;
- `out` con la emisión obligatoria de un valor de salida.

# 4. Colisión estructural

El PDF presenta un problema de crecimiento del sistema:

- el equipo de infraestructura define una clase `Modulo`;
- el equipo académico define otra clase `Modulo`;
- ambas terminan en el mismo espacio de nombres.

La presentación lo representa como un error de compilador por definición duplicada de `Modulo`.

La pregunta arquitectónica es cómo permitir clases con nombres iguales sin reescribir masivamente archivos o renombrar componentes.

# 5. Solución arquitectónica: namespaces

La solución propuesta es dividir el sistema en zonas lógicas mediante espacios de nombres.

Ejemplos conceptuales:

```csharp
namespace IPVG.Administracion.Infraestructura;
```

```csharp
namespace IPVG.Academico.Asignaturas;
```

La idea central de la fuente es que dos clases pueden compartir un mismo nombre simple siempre que pertenezcan a namespaces diferentes.

# 6. Evolución a File-Scoped Namespaces

La presentación contrasta:

## Block-scoped

```csharp
namespace IPVG.Infraestructura
{
    public class Locker
    {
        // ...
    }
}
```

## File-scoped

```csharp
namespace IPVG.Infraestructura;

public class Locker
{
    // ...
}
```

El material presenta el file-scoped namespace como la alternativa moderna de C# 10+ para eliminar un nivel de indentación.

# 7. Directiva using y alias de tipo

Para conectar zonas lógicas, el PDF utiliza la directiva:

```csharp
using IPVG.Administracion.Infraestructura;
```

También presenta alias de tipo para resolver ambigüedades o acortar nombres largos:

```csharp
using Lck = IPVG.Administracion.Infraestructura.Locker;
```

y posteriormente:

```csharp
Lck miLocker = new Lck();
```

# 8. Limitación de los arreglos

La presentación utiliza el ejemplo:

```csharp
Locker[] lockers = new Locker[100];
```

para mostrar la rigidez de una estructura cuyo tamaño debe definirse previamente.

La narrativa del PDF contrapone esta restricción con la necesidad de almacenamiento dinámico cuando el sistema crece.

# 9. ArrayList

El material presenta `ArrayList` como una solución histórica capaz de crecer dinámicamente, pero con una debilidad importante:

```text
falta de Type Safety
```

La presentación indica que una `ArrayList` trabaja con `object` y puede aceptar datos heterogéneos, trasladando ciertos errores a tiempo de ejecución.

# 10. Boxing y Unboxing

El PDF relaciona `ArrayList` con operaciones de:

- boxing: convertir un tipo por valor a una representación tratada como `object`;
- unboxing/casting: recuperar posteriormente el tipo esperado.

El material presenta este proceso como un costo adicional de memoria/CPU y como una fuente potencial de errores cuando el tipo recuperado no corresponde.

# 11. Colecciones genéricas List<T>

La alternativa promovida por la presentación es:

```csharp
List<Locker> listaLockers =
    new List<Locker>();
```

La fuente atribuye a `List<T>`:

- seguridad de tipos en compilación;
- bloqueo de tipos incompatibles;
- crecimiento dinámico;
- ausencia del boxing/unboxing descrito para el caso comparado;
- escalabilidad.

# 12. Matriz de decisión de estructuras de datos

La presentación compara tres alternativas:

| Característica | `Locker[]` (Array) | `ArrayList` | `List<T>` |
| --- | --- | --- | --- |
| Tamaño | Fijo | Dinámico | Dinámico |
| Type Safety | Sí | No | Sí |
| Boxing/Unboxing | No | Sí | No |
| Momento principal de prevención de errores | Compilación | Ejecución | Compilación |

El veredicto institucional de la diapositiva señala que, para .NET 8, `List<T>` es la alternativa preferida para manejar un directorio dinámico de objetos.

# 13. Arquitectura final integrada

La presentación reúne los conceptos anteriores en una arquitectura de lockers con:

1. un namespace para organizar la solución;
2. una colección `List<Locker>` para el directorio dinámico;
3. propiedades con `private set` para encapsular el estado;
4. miembros `static` para representar conteos globales.

Esta arquitectura combina contenidos de semanas anteriores con las colecciones genéricas introducidas en la Semana 6.

# 14. Desafío práctico: refactorización estructural

El PDF propone transformar conceptualmente un sistema previo de cuenta bancaria hacia un sistema de gestión de lockers.

El destino esperado menciona:

- transformar la lógica a operaciones `Asignar()` / `Liberar()`;
- agrupar el sistema bajo un file-scoped namespace;
- migrar el almacenamiento a una colección dinámica `List<Locker>`.

La diapositiva muestra como ejemplo conceptual:

```csharp
private static List<Locker> lockers = [];
```

# 15. Workshop — Fase 1: Estructura y Estado

La primera fase presenta una plantilla incompleta para completar conceptos previamente vistos:

```csharp
// 1. Declarar el File-scoped Namespace
_____ IPVG.Infraestructura;

public class Locker
{
    // 2. Miembro estático para rastreo global de todas las instancias
    private _____ int contadorTotal = 0;

    // 3. Propiedad encapsulada: modificable sólo de forma interna
    public string Estado { get; _____ set; }

    public Locker()
    {
        contadorTotal++;
        Estado = "Disponible";
    }
}
```

El ejercicio pregunta explícitamente por:

- la palabra clave que declara el namespace;
- el modificador que da pertenencia global a la clase;
- el modificador que protege el setter.

# 16. Workshop — Fase 2: Almacenamiento Dinámico Seguro

La segunda fase introduce una plantilla de `Program`:

```csharp
using System;
// 1. Habilitar la importación del puente de colecciones tipo seguro
using System.Collections._____;
using IPVG.Infraestructura;

class Program
{
    static void Main()
    {
        // 2. Instanciar la colección genérica correcta
        _____<Locker> moduloA =
            new _____<Locker>();

        // 3. Agregar elementos al heap sin Boxing/Unboxing
        moduloA._____(new Locker());
        moduloA._____(new Locker());

        Console.WriteLine(
            $"Lockers operativos en sede: {moduloA.Count}");
    }
}
```

La actividad pregunta:

- desde qué espacio se importan las colecciones de tipo seguro;
- qué colección reemplaza a `ArrayList`;
- qué método agrega un elemento dinámico.

# 17. Workshop — Fase 3: Interfaz Interactiva

La tercera fase propone un menú de consola con:

```text
1. Asignar
2. Liberar
3. Estado
4. Salir
```

El esqueleto visual usa:

```csharp
int opcion;

do
{
    Console.WriteLine(
        "1. Asignar | 2. Liberar | 3. Estado | 4. Salir");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            /* Lógica para moduloA.Add() */
            break;

        case 2:
            // ...
            break;
    }
}
while (opcion != 4);
```

La presentación invita a completar el flujo del `switch` en el IDE según los requerimientos del sistema.

# Observaciones de fidelidad

## Lenguaje visual

El documento utiliza metáforas físicas y arquitectónicas —zonas, pisos, lockers, casillas y módulos— para explicar memoria, namespaces y colecciones.

## Código parcial

Las páginas de workshop contienen espacios deliberadamente incompletos. Esta documentación conserva esos espacios y no los rellena dentro del material oficial.

## Comparaciones pedagógicas

Las explicaciones de Stack/Heap, boxing/unboxing y estructuras de datos se conservan según el modelo pedagógico presentado en las diapositivas, sin sustituirlo silenciosamente por explicaciones externas.

## Alcance

Este documento registra el contenido oficial del PDF y su secuencia conceptual. El desafío práctico se conserva además de forma separada en:

`../ejercicios/desafio_refactorizacion_estructural_campus_inteligente/enunciado.md`.
