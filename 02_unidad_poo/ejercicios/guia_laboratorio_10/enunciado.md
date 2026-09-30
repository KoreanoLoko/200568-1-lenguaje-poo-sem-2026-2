# Guía de Laboratorio 10

Material oficial transcrito desde la tarea **Guía de Laboratorio 10** publicada en Canvas para la asignatura.

## Datos de la actividad

- **Fecha de entrega:** no hay fecha de entrega.
- **Puntos:** 0.
- **Asignatura:** Lenguaje de Programación OO (C# / .NET).
- **Código:** 0568.
- **Duración indicada:** 160 min (4 HP).
- **Calificación:** la tarea no cuenta para la calificación final.

# Tema: Encapsulamiento Avanzado, Namespaces y Colecciones Dinámicas (List<T>)

## ¿Qué integraremos hoy?

La guía integra contenidos previamente tratados:

- arquitectura de memoria .NET;
- encapsulación con `private set`;
- `decimal`;
- miembros `static`;
- parámetros `ref` / `out`;
- constructores sobrecargados;
- file-scoped namespaces;
- colecciones genéricas `List<T>`.

La materia nueva central es el uso de:

```csharp
List<T>
```

desde:

```csharp
System.Collections.Generic
```

junto con:

- `Add()`;
- `Find()`;
- `foreach`;
- `Count`.

# ArrayList vs. List<T>

La guía compara la colección antigua `ArrayList` con `List<T>`.

| Criterio técnico | ArrayList | List<T> |
| --- | --- | --- |
| Tipo interno | `System.Object` | Tipo genérico `T` definido en compilación |
| Type Safety | No; riesgo de `InvalidCastException` | Sí; el compilador bloquea tipos incompatibles |
| Rendimiento de memoria | Puede incurrir en boxing/unboxing con tipos por valor | Trabaja directamente con el tipo genérico |
| Casting al extraer | Obligatorio | No requerido |

Ejemplos mostrados:

```csharp
Locker l = (Locker)lista[0];
```

frente a:

```csharp
Locker l = lista[0];
```

# Caso Práctico Integrado: Gestión de Casilleros y Recaudación de Sede

La solución se divide en dos capas lógicas.

## IPVG.Sede.Equipamiento

Contiene la clase:

```csharp
Locker
```

La descripción de Canvas indica que integra:

- `private set`;
- acumulador global `static`;
- constructores sobrecargados con delegación `: this(...)`;
- parámetro de salida `out`.

## IPVG.Sede.App

Contiene:

```csharp
Program
```

y gestiona una colección:

```csharp
List<Locker>
```

mediante:

- `Add()`;
- `Find()`;
- `foreach`.

# Archivo 1: Locker.cs

El código oficial se conserva en:

```text
ejemplo_oficial/Locker.cs
```

## File-scoped namespace

```csharp
namespace IPVG.Sede.Equipamiento;
```

## Miembro estático global

```csharp
private static decimal recaudoTotalSede = 0.00m;
```

Representa el recaudo acumulado para todas las instancias de `Locker`.

## Propiedades de instancia

```csharp
public int NumeroLocker { get; }
public string EstudianteRut { get; private set; }
public bool EstaOcupado { get; private set; }
public decimal TarifaMensual { get; private set; }
```

## Constructor

La implementación visible contiene:

```csharp
public Locker(int numeroLocker, decimal tarifaMensual)
```

y utiliza un operador ternario:

```csharp
TarifaMensual = tarifaMensual > 0
    ? tarifaMensual
    : 3500.00m;
```

Además inicializa:

```csharp
EstudianteRut = "SIN ASIGNAR";
EstaOcupado = false;
```

## Método Arrendar con out

```csharp
public bool Arrendar(string rut, out decimal cobro)
```

Si el locker ya está ocupado:

```csharp
cobro = 0.00m;
return false;
```

En caso de éxito:

```csharp
EstudianteRut = rut.ToUpper();
EstaOcupado = true;
cobro = TarifaMensual;
recaudoTotalSede += cobro;
return true;
```

## Método estático expression-bodied

La guía introduce:

```csharp
public static decimal ObtenerRecaudoGlobal() => recaudoTotalSede;
```

como método con cuerpo de expresión.

## ObtenerFicha

```csharp
public string ObtenerFicha()
```

utiliza:

- operador ternario;
- interpolación;
- formato `:D3`;
- formato `:N2`.

La salida tiene la forma:

```text
Locker N° 101 | Tarifa: $3.500,00 | Estado: ...
```

según la configuración regional utilizada al ejecutar.

# Archivo 2: Program.cs

El código oficial se conserva en:

```text
ejemplo_oficial/Program.cs
```

## Importaciones

```csharp
using System;
using System.Collections.Generic;
using IPVG.Sede.Equipamiento;
using CasilleroSede = IPVG.Sede.Equipamiento.Locker;
```

## File-scoped namespace

```csharp
namespace IPVG.Sede.App;
```

## Colección genérica

La guía crea:

```csharp
List<CasilleroSede> listaLockers = new List<CasilleroSede>()
{
    new CasilleroSede(101, 3500.00m),
    new CasilleroSede(102, 3500.00m)
};
```

## Menú interactivo

El menú utiliza:

- `do-while`;
- `switch`;
- opciones almacenadas como `string`.

## Listar con foreach

```csharp
foreach (CasilleroSede locker in listaLockers)
    Console.WriteLine(locker.ObtenerFicha());
```

y consulta:

```csharp
listaLockers.Count
```

## Agregar con Add

```csharp
listaLockers.Add(
    new CasilleroSede(num, 3500.00m));
```

## Buscar con Find

La búsqueda utiliza:

```csharp
CasilleroSede enc =
    listaLockers.Find(l => l.NumeroLocker == b);
```

Este fragmento introduce una expresión lambda:

```csharp
l => l.NumeroLocker == b
```

como predicado de búsqueda.

## out declarado en la llamada

La guía utiliza:

```csharp
enc.Arrendar(
    "19.876.543-2",
    out decimal c)
```

por lo que muestra la declaración de una variable `out` directamente en la invocación.

## Validación de referencia

Antes de invocar `Arrendar`:

```csharp
enc != null
```

verifica que `Find()` haya encontrado una instancia.

# Preguntas de Cierre e Integración

La guía solicita analizar:

1. por qué `List<CasilleroSede>` aporta seguridad de tipos frente a `ArrayList`;
2. cómo `private set` protege `EstudianteRut` cuando los objetos se manipulan desde una lista;
3. cómo se diferencia el miembro estático `recaudoTotalSede` de la propiedad de instancia `NumeroLocker` al existir 100 objetos.

# Observaciones de fidelidad

## Constructores sobrecargados

La descripción del caso indica:

```text
sobrecarga de constructores con delegación (: this(...))
```

pero el código de `Locker.cs` proporcionado en la misma guía muestra únicamente:

```csharp
public Locker(int numeroLocker, decimal tarifaMensual)
```

No aparece una segunda sobrecarga ni una llamada `: this(...)`.

Por fidelidad, el repositorio conserva esta diferencia y no inventa otro constructor.

## ref / out

La introducción señala que la sesión integra modificadores:

```text
ref / out
```

pero el ejemplo concreto de esta guía utiliza `out` y no muestra ningún parámetro `ref`.

## using redundante

`Program.cs` importa:

```csharp
using IPVG.Sede.Equipamiento;
```

y además declara:

```csharp
using CasilleroSede = IPVG.Sede.Equipamiento.Locker;
```

El código utiliza el alias `CasilleroSede`; ambas líneas se preservan tal como aparecen en la fuente.

## Menú

La guía muestra opciones 1 a 4, pero el `switch` implementado contiene solo los casos:

```text
"1"
"2"
"3"
```

La opción `"4"` finaliza el `do-while` mediante la condición:

```csharp
while (opcion != "4");
```

sin un `case "4"` explícito.

## Find sin resultado / locker ocupado

El código solo imprime éxito cuando:

```csharp
enc != null && enc.Arrendar(...)
```

No incluye una rama `else` para informar:

- locker no encontrado;
- locker ya ocupado.

No se agregan esas ramas porque no aparecen en el material.

## Conceptos incorporados o reforzados

- `List<T>`;
- genéricos;
- `System.Collections.Generic`;
- type safety;
- `ArrayList`;
- boxing/unboxing como concepto comparativo;
- `Add()`;
- `Find()`;
- `Count`;
- `foreach`;
- expresiones lambda;
- `out` declarado en la llamada;
- `null`;
- método expression-bodied con `=>`;
- formato `:D3`;
- formato `:N2`;
- encapsulación de objetos almacenados en colecciones;
- miembro `static` compartido por múltiples objetos.

## Alcance

Este documento conserva el código y las comparaciones entregadas en la Guía de Laboratorio 10. Las diferencias internas del material se registran sin completarlas con código externo.
