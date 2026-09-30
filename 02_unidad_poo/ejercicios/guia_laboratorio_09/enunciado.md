# Guía de Laboratorio 09

Material oficial transcrito desde la tarea **Guía de Laboratorio 09** publicada en Canvas para la asignatura.

## Datos de la actividad

- **Fecha de entrega:** no hay fecha de entrega.
- **Puntos:** 0.
- **Calificación:** la tarea no cuenta para la calificación final.

# Tema: Encapsulamiento, Espacios de Nombres (namespace) y Directiva using en C#

## ¿Qué aprenderemos hoy?

La guía plantea la organización modular del código C# mediante:

- espacios de nombres (`namespace`);
- directiva `using`;
- alias de tipos;
- prevención de colisiones entre clases con nombres idénticos;
- encapsulamiento mediante propiedades con acceso controlado.

## Modos de Declaración de Namespaces

| Característica | Bloque con Llaves (Clásico) | File-Scoped Namespace (C# 10+) |
| --- | --- | --- |
| Sintaxis | `namespace IPVG.Sede { ... }` | `namespace IPVG.Sede;` |
| Indentación | Agrega un nivel extra de tabulación. | Evita ese nivel adicional en todo el archivo. |
| Uso recomendado en la fuente | Múltiples namespaces en un mismo archivo físico. | Un único namespace por archivo. |

## Caso de Estudio: Sistema de Casilleros y Lockers de la Sede IPVG

La guía plantea una aplicación modular dividida conceptualmente en dos namespaces:

```text
IPVG.Sede.Equipamiento
IPVG.Sede.Biblioteca
```

Ambos pueden contener una clase llamada:

```csharp
Locker
```

con responsabilidades distintas.

### IPVG.Sede.Equipamiento

Contiene la clase `Locker` que modela el estado físico del casillero.

### IPVG.Sede.Biblioteca

La fuente indica que contiene otra clase homónima `Locker`, orientada a la custodia de libros.

> **Nota de fidelidad:** en el material proporcionado sí aparece el código de `IPVG.Sede.Equipamiento.Locker`, pero no se entrega el código de la clase `IPVG.Sede.Biblioteca.Locker`. Por ese motivo el repositorio no inventa ese segundo archivo.

# Archivo 1: Locker.cs — Módulo de Equipamiento

El código oficial se conserva en:

```text
ejemplo_oficial/Locker.cs
```

## File-scoped namespace

La clase utiliza:

```csharp
namespace IPVG.Sede.Equipamiento;
```

sin llaves alrededor del namespace.

## Propiedades

```csharp
public int NumeroLocker { get; }
public string RutEstudiante { get; private set; }
public bool EstaOcupado { get; private set; }
```

La guía combina:

- propiedad de solo lectura: `NumeroLocker`;
- propiedades con escritura privada: `RutEstudiante` y `EstaOcupado`.

## Constructor

```csharp
public Locker(int numero)
```

inicializa:

```csharp
NumeroLocker = numero;
RutEstudiante = "";
EstaOcupado = false;
```

## Método Asignar

```csharp
public bool Asignar(string rut)
```

Si el locker ya está ocupado:

```csharp
if (EstaOcupado) return false;
```

Si está disponible:

```csharp
RutEstudiante = rut.ToUpper();
EstaOcupado = true;
return true;
```

# Archivo 2: Program.cs — Uso de using y Alias

El código oficial se conserva en:

```text
ejemplo_oficial/Program.cs
```

## Importación estándar

```csharp
using IPVG.Sede.Equipamiento;
```

## Alias de tipo

La guía define:

```csharp
using CasilleroSede = IPVG.Sede.Equipamiento.Locker;
```

De esta forma:

```csharp
CasilleroSede
```

es un alias para:

```csharp
IPVG.Sede.Equipamiento.Locker
```

## Namespace del punto de entrada

```csharp
namespace GestionLockersIPVG;
```

también utiliza sintaxis file-scoped.

## Instanciación mediante alias

```csharp
CasilleroSede casillero1 = new CasilleroSede(101);
```

Luego se invoca:

```csharp
casillero1.Asignar("19.876.543-2");
```

y se muestran:

- número de locker;
- RUT asignado.

## Observaciones de fidelidad

La explicación de Canvas plantea una colisión entre dos clases llamadas `Locker`, una en `IPVG.Sede.Equipamiento` y otra en `IPVG.Sede.Biblioteca`.

Sin embargo, el fragmento de `Program.cs` mostrado en la fuente:

- importa únicamente `IPVG.Sede.Equipamiento`;
- crea un alias únicamente para `IPVG.Sede.Equipamiento.Locker`;
- no importa ni utiliza `IPVG.Sede.Biblioteca.Locker`.

Por lo tanto, el ejemplo conserva la **idea pedagógica de resolución de ambigüedad mediante alias**, pero el código visible no demuestra simultáneamente las dos clases homónimas.

## Conceptos incorporados o reforzados

- `namespace`;
- namespace clásico con llaves;
- file-scoped namespace;
- `using`;
- alias de tipo con `using Alias = Tipo;`;
- organización modular;
- prevención de colisiones de nombres;
- propiedad de solo lectura;
- `private set`;
- `ToUpper()`;
- retorno `bool`;
- salida temprana mediante `return false`;
- instanciación mediante alias.

## Alcance

Este documento conserva únicamente la información y el código mostrados en la Guía de Laboratorio 09. No agrega una implementación ficticia de `IPVG.Sede.Biblioteca.Locker`.
