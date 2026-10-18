# Semana 9 — Arquitectura de Sistemas Avanzada: Herencia y Polimorfismo en C#

> **Fuente:** PDF docente «Arquitectura de Sistemas Avanzada — Diseñando el Sistema de Gestión de Personal IPVG con Herencia y Polimorfismo en C# (.NET)».  
> **Semana:** 9; **UT:** 5 y 6; **orientación:** preparación para Certamen 2; **código de asignatura indicado:** 0568.  
> **Extensión:** 11 páginas/diapositivas.  
> **Original pendiente de carga manual:** `02_unidad_poo/clases/Arquitectura-Herencia y Polimorfismo.pdf`.  
> **Fuente derivada:** este resumen no sustituye el material oficial.

## Mapa de las once diapositivas

| Página | Título / contenido |
| ---: | --- |
| 1 | Portada «Arquitectura de Sistemas Avanzada»: sistema de personal IPVG, herencia y polimorfismo, Semana 9, UT 5 y 6, preparación para Certamen 2. |
| 2 | «El Desafío Arquitectónico: Código Redundante»: clases Docente/Administrativo duplican RUT, nombre y sueldo; pregunta sobre agregar Fecha de Contratación a todo el personal. |
| 3 | «La Herencia como Cimiento Estructural»: clase base Empleado y derivadas Docente y Administrativo; sintaxis `class Docente : Empleado`. |
| 4 | «La Matriz de Acceso Institucional»: `private`, `protected` y `public` vistos desde la clase, una clase hija y Program.cs. |
| 5 | «Flujo de Ejecución en Cascada (El Ascensor)»: construcción desde `System.Object` hasta constructor base y constructor derivado. |
| 6 | «Comportamientos Distintos en el Mismo Campus»: ejemplo `MarcarAsistencia()` para docente y administrativo con reglas diferentes. |
| 7 | «Diferenciando Comportamientos: Sobrecarga vs. Sobrescritura»: compile-time frente a run-time, firmas diferentes frente a la misma firma redefinida. |
| 8 | «El Metamorfo Polimórfico (Dynamic Dispatch)»: `List<Empleado>`, `foreach` y selección dinámica de la implementación según el objeto. |
| 9 | «Las Llaves Maestras: virtual y override»: declaración de método virtual en base y sobrescritura en derivada. |
| 10 | «Extendiendo en Lugar de Reemplazar: La palabra base»: `base.Metodo()` en un override, frente a `: base(...)` en un constructor. |
| 11 | «El Plano Maestro Unificado: Sistema IPVG»: atributos compartidos, inicialización base y comportamientos polimórficos. |

## 1. El problema de la redundancia (pág. 2)

La presentación compara dos clases independientes (Docente y Administrativo), ambas con `string Rut`, `string Nombre` y `decimal Sueldo`, pero con métodos específicos como `CalificarAlumno()` o `GestionarMatricula()`.

Plantea la pregunta: ¿qué ocurre al agregar «Fecha de Contratación» a todo el personal? Habría que modificar varias clases, lo que aumenta el esfuerzo y riesgo de inconsistencia.

La solución presentada es **abstraer las propiedades comunes** en una clase padre, no duplicarlas.

## 2. Herencia estructural y relación «es un» (pág. 3)

La metáfora del edificio coloca en los «cimientos» una clase base:

```csharp
public class Empleado { /* Datos compartidos */ }
public class Docente : Empleado { /* Especialización */ }
```

Los «pisos» corresponden a las clases derivadas Docente y Administrativo. Esta diapositiva ilustra reutilización de atributos comunes por herencia.

La Guía 12 usa una terminología específica distinta: `ColaboradorSede` como clase base, y `DocenteSede`, `AdministrativoSede` y `GuardiaSede` como derivadas.

## 3. Visibilidad y encapsulación (pág. 4)

La matriz usa tres ubicaciones: **dentro de la clase**, **clase hija** y **fuera de la jerarquía (Program.cs)**.

| Modificador | Misma clase | Clase hija | Program.cs externo |
| --- | --- | --- | --- |
| `private` | Sí | No | No |
| `protected` | Sí | Sí | No |
| `public` | Sí | Sí | Sí, si el tipo es accesible |

La analogía del PDF señala que `protected` expone los datos **solo a las ramas de herencia**. La fuente no pretende explicar aquí todos los modificadores combinados de C#; `internal` se había tratado en la Semana 8.

## 4. Inicialización en cascada (pág. 5)

El material describe el orden conceptual de ejecución de constructores en la cadena:

1. `System.Object`: tipo raíz.
2. Clase base `Empleado`.
3. Clase derivada `Docente`.

La diapositiva utiliza el ascensor del edificio como metáfora del orden «desde los cimientos al techo». En C#, una lista de inicialización `: base(rut, nombre, sueldoBase)` llama al constructor de la clase superior, y el cuerpo del constructor derivado se ejecuta después. El ejemplo aplica a la jerarquía de personal.

## 5. La necesidad de comportamientos especializados (pág. 6)

La regla de negocio ilustrada es que todo empleado registra asistencia, pero un administrativo marca horario fijo mientras un docente marca por bloque de clases. Ambos necesitan un método común, `MarcarAsistencia()`, aunque cada rol ejecute instrucciones distintas.

Este es un **ejemplo pedagógico** del PDF. No se implementa `MarcarAsistencia()` en los archivos C# adjuntos; esos archivos demuestran el mismo concepto con `ObtenerFicha()` y `CalcularSueldoLiquido()`.

## 6. Sobrecarga versus sobrescritura (pág. 7)

| Sobrecarga — Overload | Sobrescritura — Override |
| --- | --- |
| El mismo nombre con **diferentes listas de parámetros** | Un método virtual de base redefinido en una derivada |
| Se resuelve por la firma en **compilación** (compile-time) | La versión virtual se selecciona según el tipo real en **ejecución** (run-time) |
| Ejemplo ilustrativo del PDF: `Imprimir(string)` y `Imprimir(int)` | La misma firma de `MarcarAsistencia()` en padre e hija |

La diapositiva describe que la clase hija «reemplaza» la implementación del padre para esa operación virtual. El siguiente material añade que también puede **extenderla** mediante `base.Metodo()`.

## 7. Despacho dinámico: Dynamic Dispatch (pág. 8)

La presentación dibuja una `List<Empleado>` recorrida por un `foreach`. Aunque cada variable de iteración se considere como `Empleado`, el objeto real puede ser un `Docente` o `Administrativo`.

```csharp
foreach (Empleado emp in staff)
{
    emp.MarcarAsistencia();
}
```

Con `virtual` y `override`, la ejecución selecciona la implementación de cada clase derivada. El PDF describe al objeto real «en memoria/Heap» de manera ilustrativa. La capacidad de trabajar con distintas instancias desde una lista común es el punto central.

## 8. virtual y override (pág. 9)

El PDF presenta la siguiente estructura conceptual:

```csharp
// Clase base
public virtual void MarcarAsistencia()
{
    // Lógica común
}

// Clase derivada
public override void MarcarAsistencia()
{
    // Lógica especializada
}
```

`virtual` establece que la implementación puede redefinirse; `override` efectúa esa redefinición. Los materiales base adjuntos tienen `ObtenerFicha()` y `CalcularSueldoLiquido()` como métodos virtuales/sobrescritos.

## 9. Dos usos distintos de base (pág. 10)

El PDF separa explícitamente:

- `: base(...)`, asociado al **constructor derivado** para iniciar el estado heredado.
- `base.MarcarAsistencia()`, invocado **desde el cuerpo de un método** de la clase derivada para aprovechar la lógica previa.

Ejemplo didáctico de la diapositiva:

```csharp
public override void MarcarAsistencia()
{
    base.MarcarAsistencia();
    Console.WriteLine("Registrando sala y bloque para el Docente...");
}
```

El objetivo es **extender en lugar de reemplazar todo** el comportamiento. En la Guía 12 se pide utilizar `base.ObtenerFicha()`.

## 10. Síntesis de la arquitectura (pág. 11)

El diagrama final representa `Empleado` con un atributo `protected` y un método `virtual`, acompañado por dos derivados que invocan `base(...)` y sobrescriben ese método. La síntesis destaca:

- **Modularidad:** datos compartidos en la clase base.
- **Integridad:** inicialización mediante el constructor de la clase padre.
- **Flexibilidad:** comportamientos por tipo mediante `virtual` y `override`.

## Vínculos y fidelidad documental

- [Apunte 30 — Polimorfismo y despacho dinámico](../apuntes/30_polimorfismo_despacho_dinamico_sobrecarga_override.md).
- [Guía de Laboratorio 12](../ejercicios/guia_laboratorio_12/enunciado.md).
- [Análisis de archivos C# y proyecto adjuntos](../ejercicios/guia_laboratorio_12/analisis_archivos_base.md).
- [Semana 8 — Encapsulamiento y herencia](encapsulamiento_y_herencia_en_csharp.md), antecedente inmediato.

**Aclaración:** el documento oficial de Semana 9 no incluye una implementación terminada de `GuardiaSede` ni la solución completa de la Guía 12.
