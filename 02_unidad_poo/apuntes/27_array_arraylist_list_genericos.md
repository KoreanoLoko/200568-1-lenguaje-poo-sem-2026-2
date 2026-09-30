# 27 — Array, ArrayList y List<T>

Apunte derivado exclusivamente del PDF **Arquitectura de Software para un Campus Inteligente**.

> **Fuente principal:** `../clases/arquitectura_campus_inteligente.md`

## 1. Array

Ejemplo del material:

```csharp
Locker[] lockers = new Locker[100];
```

La característica enfatizada por el PDF es:

```text
tamaño fijo
```

El arreglo exige decidir una capacidad al crearlo.

## 2. ArrayList

La presentación introduce `ArrayList` como una colección dinámica histórica.

Ventaja indicada:

```text
crecimiento dinámico
```

Desventaja principal:

```text
falta de Type Safety
```

La fuente explica que puede recibir elementos tratados como `object`, incluso de tipos diferentes.

## 3. Boxing y Unboxing

El material asocia `ArrayList` con:

### Boxing

Conversión de un valor para ser tratado como `object`.

### Unboxing / casting

Recuperación posterior del tipo esperado.

La diapositiva presenta estas operaciones como un costo y un riesgo frente a una colección genérica.

## 4. List<T>

Ejemplo:

```csharp
List<Locker> listaLockers =
    new List<Locker>();
```

El parámetro genérico fija el tipo aceptado.

La fuente destaca:

- tamaño dinámico;
- type safety;
- errores de tipos detectados en compilación;
- uso directo del tipo;
- escalabilidad.

## 5. Comparación oficial

| Característica | Array | ArrayList | List<T> |
| --- | --- | --- | --- |
| Tamaño | Fijo | Dinámico | Dinámico |
| Type Safety | Sí | No | Sí |
| Boxing/Unboxing | No | Sí | No |
| Errores de tipo | Compilación | Ejecución | Compilación |

## 6. Operaciones del workshop

El workshop conduce a:

```csharp
List<Locker> moduloA =
    new List<Locker>();
```

y posteriormente a una operación para agregar instancias a la colección y consultar:

```csharp
moduloA.Count
```

En el documento oficial esas operaciones aparecen parcialmente incompletas para ser resueltas por el estudiante.

## 7. Relación con el Heap

La narrativa del PDF vincula las colecciones dinámicas con almacenamiento de objetos del sistema en memoria dinámica.

Se conserva esta asociación como parte del modelo didáctico utilizado en la presentación.

## 8. Criterio recomendado por el material

La matriz de decisión culmina promoviendo `List<T>` para el directorio dinámico de lockers del proyecto de Campus Inteligente.

## Alcance

Este apunte resume la comparación realizada por el PDF y no incorpora estructuras de datos adicionales que no aparezcan en la fuente.
