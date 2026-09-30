# Guía de Laboratorio 03

Material oficial transcrito desde la tarea **Guía de Laboratorio 03** publicada en Canvas para la asignatura.

## Datos de la actividad

- **Fecha de entrega:** no hay fecha de entrega.
- **Puntos:** 0.
- **Calificación:** la tarea no cuenta para la calificación final.

## Demostración Empírica: struct vs. class en Asignaciones

La guía propone contrastar cómo el CLR manipula las asignaciones en memoria de manera diferente según el tipo de dato.

## Paso 1: Crear un proyecto de Consola

La guía indica abrir Visual Studio y crear un proyecto nuevo de consola.

También entrega como método manual:

```bash
dotnet new console -o DemostracionMemoria
```

## Paso 2: Implementar Program.cs

La guía solicita abrir `Program.cs` e implementar el código oficial conservado en:

`ejemplo_oficial/Program.cs`

### Tipo por valor

Se define:

```csharp
public struct CuponDescuento
{
    public string Codigo;
    public int Porcentaje;
}
```

### Tipo por referencia

Se define:

```csharp
public class PedidoCafeteria
{
    public string Alumno;
    public string Plato;
    public string Estado;
}
```

## Experimento 1: struct

Se crea un cupón original:

```csharp
CuponDescuento cupon1 = new CuponDescuento
{
    Codigo = "ALMUERZOVG",
    Porcentaje = 15
};
```

Luego se copia:

```csharp
CuponDescuento cupon2 = cupon1;
```

y se modifica solo la copia:

```csharp
cupon2.Porcentaje = 30;
```

La intención de la demostración es observar que el valor original permanece sin cambios.

Salida esperada según el código:

```text
[STRUCT] Cupon 1 Original: ALMUERZOVG - 15%
[STRUCT] Cupon 2 Modificado: ALMUERZOVG - 30%
```

## Experimento 2: class

Se crea un pedido:

```csharp
PedidoCafeteria pedido1 = new PedidoCafeteria
{
    Alumno = "Juan Pérez",
    Plato = "Pescado frito con puré",
    Estado = "Pendiente"
};
```

Luego se copia la referencia:

```csharp
PedidoCafeteria pedido2 = pedido1;
```

y se modifica el estado mediante la segunda variable:

```csharp
pedido2.Estado = "Entregado";
```

La intención de la demostración es observar que ambas variables reflejan el mismo cambio de estado.

Salida esperada según el código:

```text
[CLASS] Pedido 1 Original (Estado): Entregado
[CLASS] Pedido 2 Referencia (Estado): Entregado
```

## Paso 5: Compilar y ejecutar

La guía indica compilar y ejecutar el proyecto, observando la salida de consola.

> Nota de fidelidad: el material proporcionado salta explícitamente de **Paso 2** a **Paso 5**. Esta numeración se conserva tal como aparece en Canvas.

La explicación final entregada por la guía indica que:

- `cupon1` y `cupon2` poseen casillas independientes en la Pila (Stack);
- `pedido1` y `pedido2` apuntan al mismo espacio físico asignado en el Montón (Heap).

## Conceptos trabajados

- `struct`;
- `class`;
- campos públicos;
- inicializadores de objeto;
- asignación con `=`;
- copia por valor;
- copia de referencia;
- Stack;
- Heap;
- mutación;
- `dotnet new console`;
- ejecución clásica mediante `Main`.

## Alcance

Este archivo conserva el contenido técnico de la guía. No corrige ni reemplaza el modelo pedagógico presentado por el docente.
