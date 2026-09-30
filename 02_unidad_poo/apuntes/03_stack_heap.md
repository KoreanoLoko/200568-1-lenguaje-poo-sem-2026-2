# 03 — Stack, Heap y gestión de memoria

Apunte derivado exclusivamente del material oficial **Clases y objetos**.

> **Fuente:** `../clases/clases_y_objetos.md`

## Stack

El material presenta la **Pila (Stack)** como memoria de alta velocidad organizada mediante el principio:

```text
LIFO
Last-In, First-Out
```

Según la fuente, en el Stack se consideran:

- variables locales;
- parámetros de métodos;
- tipos por valor;
- stack frames asociados a llamadas de métodos.

## Stack frame

Cada ejecución de un método se asocia a un contexto o `stack frame`.

El material señala que, al finalizar el método, su stack frame se destruye.

## Heap

El **Montón (Heap)** se presenta como una región de memoria dinámica.

Según la fuente, allí se almacenan los datos reales de los tipos por referencia, incluyendo:

- instancias de clases;
- arreglos.

## new y Heap

El material relaciona el operador:

```csharp
new
```

con la asignación dinámica de memoria para objetos.

## Garbage Collector

El Garbage Collector del CLR aparece como el mecanismo encargado de liberar memoria del Heap cuando ya no existen referencias activas hacia determinados bloques.

## Relación visual

```text
Stack
├── variables locales
├── parámetros
├── tipos por valor
└── referencias
             │
             ▼
          Heap
          ├── objetos
          └── arreglos
```

## Relación con la clase Vehiculo

Para el ejemplo:

```csharp
Vehiculo miAuto = new Vehiculo();
```

el material sitúa la instancia real de `Vehiculo` dentro del Heap y la variable de referencia asociada dentro del modelo Stack/Heap que presenta la clase.

## Alcance

Este apunte reproduce el modelo pedagógico utilizado por el material oficial y no agrega detalles internos del runtime que no estén desarrollados en la fuente.
