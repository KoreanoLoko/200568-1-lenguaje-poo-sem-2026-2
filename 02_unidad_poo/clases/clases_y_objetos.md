# Clases y objetos

Material oficial transcrito y organizado desde la página **Clases y objetos** publicada en Canvas para la asignatura.

## 1.1 El Punto de Entrada Clásico de Aplicaciones C#: static void Main()

El material presenta el punto de entrada clásico de una aplicación C# mediante un método `Main` declarado explícitamente dentro de una clase.

### Ejemplo oficial

```csharp
using System;

namespace SistemaGestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Punto de entrada de la aplicación inicializado con éxito.");
            // El flujo ejecutor del software comienza aquí
        }
    }
}
```

### Anatomía de la firma

#### static

Según el material, indica que el método pertenece a la clase `Program` y no a una instancia específica. Esto permite que el CLR invoque el punto de entrada sin crear previamente un objeto `Program`.

#### void

Indica que el método no retorna un valor al sistema operativo al finalizar.

#### Main

Es el nombre utilizado como punto de inicio de la ejecución. El material enfatiza que C# es sensible a mayúsculas y minúsculas, por lo que `Main` debe comenzar con `M` mayúscula.

#### string[] args

Representa un arreglo unidimensional de cadenas utilizado para recibir argumentos proporcionados desde la línea de comandos al iniciar la aplicación.

---

## 1.2 Anatomía de una Clase en C# e Instanciación de Objetos

La guía define una clase como la **plantilla lógica** a partir de la cual se modelan y materializan objetos concretos.

Para declarar una clase se utiliza la palabra reservada:

```csharp
class
```

El material distingue dentro de una clase:

- campos de datos;
- propiedades de acceso público;
- métodos de comportamiento de instancia.

### Ejemplo oficial

```csharp
public class Vehiculo
{
    // Campos privados de la clase
    private string patente;
    private int kilometraje;

    // Propiedades autoimplementadas de C#
    public string Marca { get; set; }
    public string Modelo { get; set; }

    // Método de comportamiento de la clase
    public void RegistrarRecorrido(int kilometros)
    {
        if (kilometros > 0)
        {
            kilometraje += kilometros;
        }
    }
}
```

### Instanciación

Para crear un objeto a partir de una clase se utiliza el operador `new`.

```csharp
Vehiculo miAuto = new Vehiculo();
```

Según el material, `new` solicita al CLR reservar espacio para los datos del objeto en el Heap e inicializar sus campos mediante la llamada al constructor de la clase.

---

## 1.3 Gestión Física de Memoria en .NET: Stack vs. Heap

El material presenta dos regiones de memoria con comportamientos distintos.

### La Pila (Stack)

Se describe como un bloque de almacenamiento de alta velocidad con estructura **LIFO (Last-In, First-Out)**.

Según la página:

- almacena valores de variables locales;
- almacena parámetros de métodos;
- almacena tipos por valor;
- su administración está ligada al contexto de ejecución del hilo;
- cada llamada utiliza un `stack frame`;
- al salir de un método, el `stack frame` asociado se destruye.

### El Montón (Heap)

Se describe como memoria dinámica de mayor tamaño.

Según el material:

- almacena los datos reales de los tipos por referencia;
- contiene instancias de clases, arreglos, etc.;
- la memoria se asigna dinámicamente mediante `new`;
- el Garbage Collector del CLR administra y libera memoria cuando ya no existen referencias activas hacia esos bloques.

---

## 1.4 Tipos por Valor (struct) vs. Tipos por Referencia (class)

El material compara ambos grupos según ubicación en memoria, asignación, valor por defecto y ciclo de vida.

| Criterio de diseño | Tipos por Valor (struct) | Tipos por Referencia (class) |
| --- | --- | --- |
| **Ubicación física en memoria** | Los datos se almacenan directamente en la Pila (Stack). | El contenido real se aloja en el Montón (Heap) y la variable mantiene una referencia. |
| **Asignación (=)** | Se copia el valor completo y se obtiene una variable independiente. | Se copia la referencia y ambas variables pasan a compartir la misma instancia. |
| **Valor por defecto** | El material indica que se inicializan con su estado por defecto. | El material presenta `null` como valor de referencia inicial por defecto. |
| **Ciclo de vida** | Se destruyen al salir del ámbito de ejecución indicado por el material. | Son administrados por el Garbage Collector. |

## Conceptos incorporados por este material

- punto de entrada clásico con `static void Main(string[] args)`;
- `static`;
- `void`;
- argumentos de línea de comandos mediante `string[] args`;
- definición de clases con `class`;
- campos privados;
- propiedades autoimplementadas;
- métodos de instancia;
- operador `new`;
- instanciación de objetos;
- Stack;
- Heap;
- LIFO;
- stack frame;
- Garbage Collector;
- tipos por valor;
- tipos por referencia;
- `struct`;
- `class`;
- comportamiento de asignación por valor y por referencia.

## Alcance

Este archivo conserva la terminología, ejemplos y nivel de detalle del material oficial de Canvas. No introduce correcciones ni ampliaciones externas.
