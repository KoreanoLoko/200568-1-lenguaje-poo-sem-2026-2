# Semana 8 — Encapsulamiento avanzado y herencia en C#

**Fuente:** documento oficial «Construyendo el Sistema de Personal IPVG», 14 páginas; Lenguaje de Programación OO, código 0568, Instituto Profesional Virginio Gómez.

**PDF original (subida manual pendiente):** `02_unidad_poo/clases/Encapsulamiento_y_Herencia_en_C.pdf`. Este resumen es derivado, no reemplaza el documento docente.

## Mapa del material por página

| Pág. | Contenido |
|---:|---|
| 1 | Portada: Sistema de Personal IPVG, semana 8, encapsulamiento avanzado y herencia. |
| 2 | Desafío: gestionar docentes, administrativos y directivos de modo seguro, escalable y sin redundancia (DRY). |
| 3 | File-scoped namespaces de C# 10+ frente al formato clásico con llaves. |
| 4 | Campos privados, métodos y propiedades públicos; protección de la integridad con validación de estado. |
| 5 | Matriz de acceso de `public`, `internal`, `protected` y `private`. |
| 6 | Problema de escalabilidad de arreglos `Empleado[]` con tamaño fijo. |
| 7 | `ArrayList` frente a `List<T>`: type safety y boxing/unboxing. |
| 8 | Uso de `List<Empleado> nominas = new();`, `Add` y `foreach`. |
| 9 | Antipatrón de duplicar RUT, nombre y sueldo base en distintos roles. |
| 10 | Relación «Es un» (Is-A): `Empleado` como base de `Docente` y `Administrativo`. |
| 11 | Operador `:` en herencia y `: base(rut, nombre)` para constructor padre. |
| 12 | Método base `virtual` y derivado `override` para comportamientos salariales especializados. |
| 13 | Integración de namespaces, colecciones, herencia y seguridad. |
| 14 | Desafío práctico: implementar base Empleado, roles, `List<T>` y encapsulación estricta en Visual Studio. |

## 1. Arquitectura y organización (págs. 2–3)

El propósito es proteger los datos, permitir el crecimiento de la nómina y evitar duplicar código (**DRY**, Don't Repeat Yourself).

La forma clásica `namespace SistemaPersonalIPVG { ... }` usa un bloque de llaves; la forma moderna `namespace SistemaPersonalIPVG;` reduce un nivel de indentación y se aplica a un archivo con un namespace.

La Guía 11 especifica dos capas lógicas: `IPVG.Sede.Core` para clases y lógica de negocio, y `IPVG.Sede.App` para el programa de consola. Estas denominaciones proceden de Canvas y no deben confundirse con la denominación conceptual de la diapositiva.

## 2. Encapsulamiento avanzado (págs. 4–5)

La ilustración de la bóveda separa **estado privado** de **interfaces públicas controladas**. La propiedad completa respaldada por un campo privado puede comprobar una condición en `set` antes de escribir.

Modificadores mostrados:

| Acceso | Alcance |
|---|---|
| `public` | Acceso público sujeto a la visibilidad del tipo contenedor |
| `internal` | Dentro del mismo ensamblado |
| `protected` | En la clase y clases derivadas |
| `private` | Dentro de la clase declarante |

La guía requiere `private decimal sueldoBase;`, una propiedad completa `SueldoBase` y `protected string Rut { get; set; }`. La presentación ilustra otro ejemplo de validación de sueldo; la regla **específica de la guía** es ajustar automáticamente a $500.000 cuando el valor ingresado sea inferior. El texto «mínimo legal» pertenece al enunciado; **no se ha verificado si $500.000 coincide con el mínimo legal chileno vigente**.

## 3. Escalabilidad de la nómina (págs. 6–8)

La incorporación de cinco docentes adicionales ejemplifica por qué un arreglo de tamaño fijo puede ser incómodo. `ArrayList` acepta objetos sin seguridad genérica de tipos; la presentación lo relaciona con boxing/unboxing. `List<T>` ofrece colección dinámica y seguridad de tipos en compilación.

La diapositiva 8 muestra los conceptos:

```csharp
List<Empleado> nominas = new();
nominas.Add(nuevoDocente);
foreach (var empleado in nominas)
{
    Console.WriteLine(empleado.Nombre);
}
```

`new()` con tipo de destino, `Add` y `foreach` son los mecanismos ilustrados. `List<T>` ya estaba en la Guía 10; aquí se **refuerza** y se integra con herencia.

## 4. Evitar redundancia e introducir herencia (págs. 9–10)

La presentación representa tres clases con campos duplicados (`RUT`, `Nombre`, `SueldoBase`). La herencia propone mover el estado común a `Empleado` y dejar en `Docente`, `Administrativo` y otros roles solo los atributos especializados.

«Un docente **es un** empleado» es la relación **Is-A**. En la Guía 11 se aplica a `DocenteSede : ColaboradorSede`. El enunciado **solo solicita crear la clase derivada `DocenteSede`**, aunque la presentación hable también de administrativos y directivos.

## 5. Sintaxis y constructores (pág. 11)

Ejemplo conceptual de la presentación:

```csharp
public class Docente : Empleado
{
    public string Grado { get; set; }
    public Docente(string rut, string nombre, string grado)
        : base(rut, nombre)
    {
        Grado = grado;
    }
}
```

`: Empleado` indica la herencia. `: base(...)` invoca el constructor de la clase base antes del cuerpo del constructor derivado. A diferencia de `: this(...)` (clases previas), no llama a otro constructor de la misma clase.

## 6. Virtual y override (pág. 12)

El material plantea «un mismo método, diferentes respuestas según el tipo de empleado».

```csharp
// En una clase base
public virtual decimal CalcularSueldo() { return SueldoBase; }

// En una clase derivada (fragmento ilustrativo)
public override decimal CalcularSueldo()
{
    return base.CalcularSueldo() + BonoGrado;
}
```

`virtual` habilita una implementación especializada; `override` la define; `base.CalcularSueldo()` reutiliza el cálculo padre.

En la Guía 11 el método se llama `CalcularSueldoTotal()` y añade un bono por horas OTEC de **$12.500 cada hora**. Cuando la nómina tiene referencias `ColaboradorSede` que apuntan a objetos `DocenteSede`, la invocación virtual ejecuta el método del docente (**polimorfismo**).

## 7. Arquitectura final y workshop (págs. 13–14)

La síntesis reúne namespaces, colección genérica, jerarquía de clases y encapsulación. El desafío solicita desarrollar el sistema en Visual Studio; **no proporciona tres archivos completos de solución**.

## Conceptos incorporados y trazabilidad

- **Nuevos/profundizados:** propiedades completas con validación, `protected`, herencia Is-A, DRY aplicado a jerarquías, `: base(...)`, `virtual`, `override` y polimorfismo.
- **Reforzados:** file-scoped namespaces, `List<T>`, `Add`, `foreach`, `decimal` y encapsulación.
- Apuntes: [28 — Encapsulación avanzada](../apuntes/28_propiedades_completas_modificadores_acceso.md) y [29 — Herencia](../apuntes/29_herencia_base_virtual_override.md).
- Ejercicio aplicado: [Guía 11](../ejercicios/guia_laboratorio_11/enunciado.md).
