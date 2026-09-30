# 24 — Namespaces, using, file-scoped namespace y alias de tipos

Apunte derivado exclusivamente de la **Guía de Laboratorio 09**.

> **Fuente:** `../ejercicios/guia_laboratorio_09/enunciado.md`

## Namespace

La guía utiliza los espacios de nombres para organizar clases y evitar colisiones.

Ejemplos conceptuales:

```text
IPVG.Sede.Equipamiento
IPVG.Sede.Biblioteca
```

Ambos pueden contener clases llamadas `Locker`.

## Namespace clásico

Sintaxis mostrada:

```csharp
namespace IPVG.Sede
{
    // contenido
}
```

La fuente indica que agrega un nivel adicional de indentación.

## File-scoped namespace

Sintaxis:

```csharp
namespace IPVG.Sede.Equipamiento;
```

La guía lo presenta como alternativa de C# 10+ para un único namespace por archivo.

## Directiva using

Ejemplo:

```csharp
using IPVG.Sede.Equipamiento;
```

La directiva permite utilizar tipos del namespace importado sin repetir el nombre completamente calificado en cada referencia.

## Alias de tipo

La guía muestra:

```csharp
using CasilleroSede = IPVG.Sede.Equipamiento.Locker;
```

Después puede utilizarse:

```csharp
CasilleroSede casillero1 = new CasilleroSede(101);
```

## Forma general

```csharp
using Alias = Namespace.Tipo;
```

## Propósito del alias según la fuente

El alias se presenta para resolver ambigüedades cuando existen tipos con el mismo nombre en namespaces diferentes.

## Caso Locker

```text
IPVG.Sede.Equipamiento.Locker
IPVG.Sede.Biblioteca.Locker
```

La fuente describe ambos tipos conceptualmente.

El código entregado solo implementa:

```text
IPVG.Sede.Equipamiento.Locker
```

y crea el alias:

```text
CasilleroSede
```

para ese tipo.

## Encapsulamiento en Locker

```csharp
public int NumeroLocker { get; }
public string RutEstudiante { get; private set; }
public bool EstaOcupado { get; private set; }
```

La clase mantiene control interno sobre el RUT y el estado de ocupación.

## Retorno temprano

El método utiliza:

```csharp
if (EstaOcupado) return false;
```

Esto interrumpe inmediatamente la ejecución del método cuando el locker ya está ocupado.

## Normalización

```csharp
RutEstudiante = rut.ToUpper();
```

normaliza el RUT textual a mayúsculas según el código entregado.

## Conceptos habilitados por esta fuente

- namespace;
- namespace completamente calificado;
- file-scoped namespace;
- `using`;
- alias de tipos;
- clases homónimas en distintos namespaces;
- modularización;
- retorno temprano.

## Alcance

Este apunte no inventa la clase `IPVG.Sede.Biblioteca.Locker`, ya que su implementación no aparece en el material proporcionado.
