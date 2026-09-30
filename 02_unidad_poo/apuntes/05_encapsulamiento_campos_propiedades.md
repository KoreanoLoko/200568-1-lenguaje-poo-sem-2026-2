# 05 — Encapsulamiento: campos y propiedades

Apunte derivado exclusivamente del PDF **Anatomía de Clases, Puntos de Entrada y Memoria en C#**.

> **Fuente:** `../clases/Anatomía de Clases, Puntos de Entrada y Memoria en C#.pdf`

## Anatomía presentada

La clase de ejemplo del material combina tres elementos:

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

## Campo privado

Ejemplo:

```csharp
private int _edad;
```

Dentro del material, el campo privado representa el **estado interno** de una clase.

Se presenta como:

- oculto;
- protegido;
- accesible directamente solo dentro de la propia clase.

## Propiedad

Ejemplo:

```csharp
public int Edad { get; set; }
```

La presentación caracteriza la propiedad como un **contrato público** asociado a:

- `get`: lectura;
- `set`: escritura.

La idea central es que los datos internos no se exponen directamente como campos públicos, sino mediante mecanismos de acceso definidos por la clase.

## Propiedad autoimplementada

El material utiliza propiedades como:

```csharp
public string Nombre { get; set; }
```

y señala que C# genera internamente el almacenamiento necesario asociado a esa propiedad.

## Relación conceptual

```text
Estado interno
    ↓
campo privado
    ↓
propiedad pública
    ↓
acceso desde otras partes del programa
```

## Métodos

Los métodos representan comportamiento.

Ejemplo del PDF:

```csharp
public void Saludar()
{
    // Lógica
}
```

Por lo tanto, el modelo de clase mostrado por la fuente combina:

```text
Clase
├── estado interno → campos
├── acceso         → propiedades
└── comportamiento→ métodos
```

## Alcance

Este apunte mantiene el nivel y terminología del material oficial. No incorpora validaciones personalizadas de propiedades ni patrones de encapsulamiento que el PDF no desarrolla.
