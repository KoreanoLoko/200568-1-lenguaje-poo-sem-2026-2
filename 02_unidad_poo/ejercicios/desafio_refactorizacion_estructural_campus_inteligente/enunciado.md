# Desafío Práctico — Refactorización Estructural del Campus Inteligente

Fuente: PDF **Arquitectura de Software para un Campus Inteligente**, páginas finales de workshop.

## Objetivo general

Transformar conceptos previamente trabajados hacia un sistema de gestión de lockers, integrando:

- file-scoped namespace;
- miembro `static`;
- encapsulación;
- colecciones genéricas;
- almacenamiento dinámico;
- interfaz de consola;
- `do-while`;
- `switch`.

## Punto de origen y punto de destino

El PDF plantea como punto de origen un sistema anterior basado en una clase conceptual `CuentaBancaria`.

El destino es una clase:

```text
Locker.cs
```

para un sistema de gestión de lockers.

La transformación solicitada menciona:

- convertir operaciones del dominio a `Asignar()` y `Liberar()`;
- organizar el sistema mediante un file-scoped namespace;
- migrar el almacenamiento a una colección dinámica de lockers.

La diapositiva muestra conceptualmente:

```csharp
private static List<Locker> lockers = [];
```

# Fase 1 — Estructura y Estado

Complete la siguiente plantilla según los conceptos de la asignatura:

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

Preguntas planteadas por la diapositiva:

1. ¿Qué palabra clave permite declarar el namespace?
2. ¿Qué modificador da pertenencia global a nivel de clase?
3. ¿Qué modificador protege el setter?

# Fase 2 — Almacenamiento Dinámico Seguro

Complete:

```csharp
using System;

// 1. Habilitar la importación del puente de colecciones tipo seguro
using System.Collections._____;

using IPVG.Infraestructura;

class Program
{
    static void Main()
    {
        // 2. Instanciar la colección genérica correcta para múltiples lockers
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

Preguntas de la diapositiva:

1. ¿Desde qué namespace se importan las colecciones con type safety?
2. ¿Cuál es la colección genérica que reemplaza a `ArrayList` en este ejercicio?
3. ¿Qué método agrega un elemento dinámico a la colección?

# Fase 3 — Interfaz Interactiva

El sistema debe presentar las opciones:

```text
1. Asignar
2. Liberar
3. Estado
4. Salir
```

Esqueleto entregado:

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

## Actividad

La última diapositiva invita a completar en el IDE el flujo del `switch` según los requerimientos del sistema de gestión de lockers.

## Regla de conservación

Este archivo mantiene los espacios en blanco del workshop. No constituye una solución desarrollada ni completa automáticamente los términos faltantes.
