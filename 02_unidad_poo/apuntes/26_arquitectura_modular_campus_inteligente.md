# 26 — Arquitectura modular del Campus Inteligente

Apunte derivado exclusivamente del PDF **Arquitectura de Software para un Campus Inteligente**.

> **Fuente principal:** `../clases/arquitectura_campus_inteligente.md`

## Idea central

El material utiliza un sistema de lockers como eje para integrar varios contenidos de POO y C#:

```text
estado de instancia
+ encapsulación
+ static
+ ref/out
+ namespaces
+ using/alias
+ colecciones dinámicas
```

## 1. Estado individual y estado global

### Estado individual

La presentación utiliza propiedades como:

```csharp
public string Codigo { get; private set; }
```

El dato pertenece a una instancia concreta y su modificación queda controlada por la propia clase.

### Estado global

Ejemplo:

```csharp
private static int totalLockers = 0;
```

El miembro pertenece al tipo y sirve como información compartida entre todas las instancias.

## 2. Parámetros avanzados

El ejemplo conceptual:

```csharp
public bool Asignar(
    ref Estudiante e,
    out string clave)
```

integra:

- retorno principal mediante `bool`;
- modificación bidireccional mediante `ref`;
- salida obligatoria mediante `out`.

## 3. Organización por namespaces

Problema planteado:

```text
Modulo
Modulo
```

dos clases homónimas desarrolladas por equipos distintos.

Solución:

```csharp
namespace IPVG.Administracion.Infraestructura;
namespace IPVG.Academico.Asignaturas;
```

El nombre completamente calificado diferencia los tipos.

## 4. File-scoped namespace

La forma promovida por el material es:

```csharp
namespace IPVG.Infraestructura;
```

frente a la variante clásica con llaves.

## 5. Importaciones y alias

Importación:

```csharp
using IPVG.Administracion.Infraestructura;
```

Alias:

```csharp
using Lck =
    IPVG.Administracion.Infraestructura.Locker;
```

Uso:

```csharp
Lck miLocker = new Lck();
```

## 6. Arquitectura integrada

La presentación culmina en un sistema cuya estructura conceptual es:

```text
namespace
   ↓
Locker
   ├── propiedades encapsuladas
   ├── miembro static
   └── comportamiento
          ↓
List<Locker>
   ↓
interfaz de consola
   ↓
do-while + switch
```

## 7. Refactorización como integración

El desafío final no introduce una aplicación totalmente aislada: pide transformar conocimientos ya trabajados en un sistema de lockers.

El objetivo arquitectónico es migrar desde lógica individual hacia:

- operaciones del dominio (`Asignar`, `Liberar`);
- organización modular mediante namespace;
- almacenamiento dinámico mediante una colección de lockers;
- interfaz interactiva.

## 8. Regla de fuente de verdad

Los fragmentos incompletos del workshop se mantienen como ejercicios. Sus respuestas no se incorporan dentro del material oficial hasta que exista una solución del docente o una solución desarrollada y etiquetada explícitamente como derivada.
