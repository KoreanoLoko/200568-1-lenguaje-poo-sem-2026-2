# Anatomía de Clases, Puntos de Entrada y Memoria en C#

Documento derivado exclusivamente del material oficial **Anatomía de Clases, Puntos de Entrada y Memoria en C#.pdf**.

> **Fuente original prevista en el repositorio:** `02_unidad_poo/clases/Anatomía de Clases, Puntos de Entrada y Memoria en C#.pdf`

## Identificación

- **Título de portada:** De la Arquitectura a la Realidad Física en C#
- **Asignatura indicada:** Lenguaje de Programación OO (0568)
- **Semana:** 2
- **Institución:** Instituto Profesional Virginio Gómez - Universidad de Concepción
- **Extensión:** 15 páginas

## Relación con el material anterior

Este PDF profundiza y visualiza conceptos ya introducidos en la página de Canvas **Clases y objetos**, y agrega ejemplos experimentales y un desafío práctico sobre:

- punto de entrada clásico;
- anatomía de clases;
- campos privados y propiedades;
- operador `new`;
- Stack y Heap;
- tipos por valor y tipos por referencia;
- efecto de copia/asignación;
- diseño de una clase `Colaborador` y un `struct RegistroHoras`.

## Mapa del contenido

| Página | Tema |
| ---: | --- |
| 1 | Portada: De la Arquitectura a la Realidad Física en C#. |
| 2 | Punto de entrada clásico: `static void Main(string[] args)`. |
| 3 | Anatomía de una clase: campos privados, propiedades autoimplementadas y métodos. |
| 4 | Campos vs. propiedades como modelo de seguridad y encapsulamiento. |
| 5 | Operador `new` y transición desde la clase hacia una instancia física. |
| 6 | Comparación Stack vs. Heap. |
| 7 | Comparación pedagógica entre tipos por valor (`struct`) y tipos por referencia (`class`). |
| 8 | Efecto de asignación/copia: independencia en `struct` y referencia compartida en `class`. |
| 9 | Síntesis visual de `Persona p = new Persona();`. |
| 10 | Definición de estructuras de prueba: `Punto` y `Jugador`. |
| 11 | Experimento de copia y mutación. |
| 12 | Resultado del experimento. |
| 13 | Desafío individual: Sistema de Recursos Humanos. |
| 14 | Arquitectura esperada del desafío. |
| 15 | Cierre metacognitivo. |

---

## 1. El umbral del programa

La presentación identifica:

```csharp
static void Main(string[] args)
```

como el punto de entrada donde el sistema operativo inicia la ejecución.

El material asocia visualmente cada componente con una idea:

- `static`: independiente de una instancia; pertenece a la clase base.
- `void`: no devuelve valores al sistema por defecto.
- `Main`: punto reconocido para iniciar la ejecución.
- `string[] args`: vector/arreglo de comunicación desde la terminal.

> Este documento conserva la explicación presentada en la diapositiva sin ampliarla con variantes adicionales de `Main`.

---

## 2. Anatomía de una clase en C#

La diapositiva utiliza el siguiente modelo:

```csharp
public class Persona
{
    private string rut;

    public string Nombre { get; set; }

    public void Saludar()
    {
        // Lógica
    }
}
```

La clase se divide en:

### Campos privados

Representan el estado interno de la clase.

Ejemplo:

```csharp
private string rut;
```

La presentación los caracteriza como datos ocultos y protegidos.

### Propiedades autoimplementadas

Ejemplo:

```csharp
public string Nombre { get; set; }
```

La diapositiva las presenta como acceso controlado mediante `get` y `set`.

### Métodos

Representan comportamiento o acciones disponibles.

Ejemplo:

```csharp
public void Saludar()
{
    // Lógica
}
```

---

## 3. Campos vs. propiedades

La presentación contrasta:

```csharp
private int _edad;
```

con:

```csharp
public int Edad { get; set; }
```

El campo privado se presenta como una variable interna que solo la propia clase puede utilizar.

La propiedad se presenta como un contrato público de acceso, asociado a lecturas (`get`) y escrituras (`set`), dentro del modelo de encapsulamiento enseñado.

Este punto se desarrolla también en:

`02_unidad_poo/apuntes/05_encapsulamiento_campos_propiedades.md`

---

## 4. El operador new

La diapositiva representa la transición:

```text
class Vehiculo
      ↓
new Vehiculo()
      ↓
objeto físico
```

Según el material, al utilizar `new`, el CLR busca espacio en memoria RAM para construir el objeto.

---

## 5. Stack vs. Heap

La presentación utiliza el siguiente modelo pedagógico.

### Stack / Pila de ejecución

Atributos indicados:

- rápido;
- temporal;
- estructurado como LIFO.

Uso indicado:

- variables locales;
- parámetros de métodos;
- liberación automática al salir del método.

### Heap / Montículo

Atributos indicados:

- amplio;
- dinámico;
- requiere recolección de basura.

Uso indicado:

- objetos instanciados;
- acceso mediante una dirección o referencia.

> Estas descripciones se conservan tal como se presentan en el material de clase.

---

## 6. Dualidad de tipos en .NET

La diapositiva compara:

```text
Tipos por Valor       → Structs
Tipos por Referencia  → Classes
```

| Criterio mostrado | Tipos por Valor (Structs) | Tipos por Referencia (Classes) |
| --- | --- | --- |
| Ubicación en memoria | Viven en el Stack. | Viven en el Heap; la referencia vive en el Stack. |
| Asignación | Copian el dato completo. | Copian la dirección de memoria. |
| Valor por defecto mostrado | Instancia vacía. | `null`. |
| Caso de uso mostrado | Coordenadas, fechas, datos pequeños. | Entidades complejas de negocio. |

El material utiliza como ejemplos:

- valor: `int`, `DateTime`;
- referencia: `Persona`, `Colaborador`.

---

## 7. Efecto de referencia al copiar

La presentación utiliza una analogía visual.

### Struct / Valor

```text
A = B
```

se representa como una **clonación física**, donde ambas variables quedan independientes.

### Clase / Referencia

La asignación se representa como copia de una referencia o "control remoto": dos variables pueden observar y modificar la misma instancia compartida.

Este comportamiento se comprueba experimentalmente en las páginas 10 a 12.

---

## 8. Síntesis de creación de un objeto

La diapositiva analiza:

```csharp
Persona p = new Persona();
```

según tres elementos:

1. se crea la variable/referencia `p`;
2. la referencia se enlaza con una dirección de memoria;
3. se construye el objeto físico representado por `new Persona()`.

---

## 9. Experimento: struct vs. class

### Estructuras de prueba

```csharp
public struct Punto
{
    public int X { get; set; }
}
```

```csharp
public class Jugador
{
    public int Puntaje { get; set; }
}
```

### Copia y mutación

```csharp
Punto p1 = new Punto { X = 10 };
Punto p2 = p1;
p2.X = 99;

Jugador j1 = new Jugador { Puntaje = 10 };
Jugador j2 = j1;
j2.Puntaje = 99;
```

### Resultado mostrado

La presentación indica:

```text
p1.X = 10
j1.Puntaje = 99
```

Interpretación del material:

- al copiar `p2 = p1`, se copian los datos y modificar `p2` no modifica `p1`;
- al copiar `j2 = j1`, se comparte la referencia y modificar `j2` afecta a la instancia observada mediante `j1`.

El experimento se documenta también en:

`02_unidad_poo/apuntes/06_experimento_copia_struct_class.md`

---

## 10. Desafío de Ingeniería: Sistema de Recursos Humanos

La presentación propone **40 minutos de trabajo individual**.

### Contexto

Diseñar el núcleo de un sistema de control de horas para una organización.

### Requerimientos estrictos

1. Crear una clase `Colaborador` como tipo por referencia.
2. Crear un `struct RegistroHoras` como tipo por valor.
3. `Colaborador` debe tener propiedades autoimplementadas para `Nombre` y `Cargo`.
4. `Colaborador` debe incluir un método `RegistrarJornada(RegistroHoras registro)`.

### Arquitectura esperada mostrada

```text
«Struct» RegistroHoras
- string Dia
- int Horas

        ◇────────▶

«Class» Colaborador
- string Nombre
- string Cargo
- int TotalHoras
- RegistrarJornada()
```

El enunciado se conserva por separado en:

`02_unidad_poo/ejercicios/desafio_sistema_recursos_humanos/enunciado.md`

---

## 11. Cierre metacognitivo

El material cierra con tres preguntas/ideas:

- **¿Qué construí hoy?** Estructuración de clases y structs utilizando propiedades encapsuladas y métodos.
- **¿Cómo gestiona C# la materia?** Modelo de Stack para copias físicas y Heap para referencias/estado compartido.
- **¿Por qué es crítico?** Un error entre valor y referencia puede provocar cambios de datos no esperados dentro de una organización.

## Conceptos que este PDF consolida

- `static void Main(string[] args)`;
- campos privados;
- propiedades autoimplementadas;
- encapsulamiento;
- métodos;
- operador `new`;
- Stack;
- Heap;
- LIFO;
- Garbage Collector;
- `struct`;
- `class`;
- copia por valor;
- copia de referencias;
- inicializadores de objeto;
- mutación de estado compartido;
- diseño de entidades simples para un sistema organizacional.

## Alcance

Este documento reproduce el modelo conceptual, ejemplos y comparaciones utilizados en el PDF. No corrige ni sustituye sus simplificaciones con información externa.
