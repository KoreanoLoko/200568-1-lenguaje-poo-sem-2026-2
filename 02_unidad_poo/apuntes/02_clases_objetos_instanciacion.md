# 02 — Clases, objetos e instanciación

Apunte derivado exclusivamente del material oficial **Clases y objetos**.

> **Fuente:** `../clases/clases_y_objetos.md`

## Clase

El material define una clase como una **plantilla lógica** para modelar objetos concretos.

Se declara mediante:

```csharp
class
```

Ejemplo:

```csharp
public class Vehiculo
{
}
```

## Componentes presentados dentro de una clase

### Campos privados

```csharp
private string patente;
private int kilometraje;
```

El material los presenta como datos internos de la clase.

### Propiedades autoimplementadas

```csharp
public string Marca { get; set; }
public string Modelo { get; set; }
```

### Métodos de comportamiento

```csharp
public void RegistrarRecorrido(int kilometros)
{
    if (kilometros > 0)
    {
        kilometraje += kilometros;
    }
}
```

El método representa comportamiento asociado a una instancia de la clase.

## Objeto

Un objeto es la materialización de la plantilla definida por la clase.

La guía muestra:

```csharp
Vehiculo miAuto = new Vehiculo();
```

Podemos separar la expresión de esta forma:

```text
Vehiculo     miAuto      =      new Vehiculo();
   │           │                    │
 tipo       variable            instancia
```

## Operador new

Según el material, `new` provoca la reserva del espacio necesario para la instancia y activa su inicialización mediante el constructor.

## Diferencia conceptual

```text
Clase
  ↓
plantilla
  ↓
new
  ↓
Objeto
```

## Conceptos ya habilitados por la materia

A partir de esta fuente ya forman parte explícita de la asignatura:

- `public class`;
- `private`;
- campos;
- propiedades `{ get; set; }`;
- métodos de instancia;
- parámetros de métodos;
- estructura `if` dentro de un método;
- operador `new`;
- creación de objetos.

## Alcance

Este apunte no agrega constructores personalizados, encapsulamiento avanzado, herencia o polimorfismo, porque no son desarrollados en este material específico.
