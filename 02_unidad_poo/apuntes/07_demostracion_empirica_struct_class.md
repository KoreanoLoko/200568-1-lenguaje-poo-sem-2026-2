# 07 — Demostración empírica: struct vs. class

Apunte derivado exclusivamente de la **Guía de Laboratorio 03**.

> **Fuente:** `../ejercicios/guia_laboratorio_03/enunciado.md`

## Objetivo

Comprobar mediante ejecución de código la diferencia de asignación entre:

```text
struct → tipo por valor
class  → tipo por referencia
```

## Caso struct: CuponDescuento

```csharp
public struct CuponDescuento
{
    public string Codigo;
    public int Porcentaje;
}
```

### Copia

```csharp
CuponDescuento cupon2 = cupon1;
```

### Modificación

```csharp
cupon2.Porcentaje = 30;
```

El resultado mostrado por la guía mantiene:

```text
cupon1.Porcentaje = 15
cupon2.Porcentaje = 30
```

Dentro del modelo enseñado, la copia produce variables independientes.

## Caso class: PedidoCafeteria

```csharp
public class PedidoCafeteria
{
    public string Alumno;
    public string Plato;
    public string Estado;
}
```

### Copia de referencia

```csharp
PedidoCafeteria pedido2 = pedido1;
```

### Modificación

```csharp
pedido2.Estado = "Entregado";
```

El resultado esperado es:

```text
pedido1.Estado = "Entregado"
pedido2.Estado = "Entregado"
```

porque ambas variables se presentan como referencias a la misma instancia.

## Diferencia visual

```text
STRUCT

cupon1 ── datos propios
cupon2 ── copia independiente
```

```text
CLASS

pedido1 ─┐
         ├──▶ PedidoCafeteria compartido
pedido2 ─┘
```

## Comando dotnet incorporado por la guía

La guía introduce:

```bash
dotnet new console -o DemostracionMemoria
```

para crear un proyecto de consola desde terminal.

## Relación con materiales anteriores

Este laboratorio refuerza directamente:

- `04_tipos_valor_referencia.md`;
- `06_experimento_copia_struct_class.md`;
- el ejemplo `Ejemplo CS`.

La diferencia es que utiliza un contexto de negocio distinto:

- `CuponDescuento` como `struct`;
- `PedidoCafeteria` como `class`.

## Alcance

Este apunte mantiene la terminología y explicación de la guía. No introduce mecanismos adicionales de memoria ni correcciones externas.
