# 11 — Miembros de instancia y miembros static

Apunte derivado exclusivamente del material oficial **Variables Primitivas e Inferencias de Tipo en C#**.

> **Fuente:** `../clases/variables_primitivas_inferencia_tipo_csharp.md`

## Miembros de instancia

Un miembro sin `static` pertenece a una instancia particular.

El material utiliza el ejemplo de productos del Food Truck:

```text
ItemMenu A → Stock A
ItemMenu B → Stock B
```

Cada objeto mantiene su propio valor.

Conceptualmente:

```text
Objeto 1
└── Stock propio

Objeto 2
└── Stock propio
```

## Miembros static

Un miembro declarado con:

```csharp
static
```

pertenece a la clase y es compartido.

El ejemplo utilizado es:

```text
totalCaja
```

como una única caja acumulada por todas las ventas.

Conceptualmente:

```text
Objeto 1 ─┐
Objeto 2 ─┼──▶ totalCaja
Objeto 3 ─┘
```

## Diferencia principal según la fuente

| Miembro | Pertenece a | Cantidad de datos |
| --- | --- | --- |
| instancia | cada objeto | uno por instancia |
| `static` | la clase | uno compartido |

## Analogía del camión

La fuente lo expresa así:

```text
Stock
→ atributo individual de un producto

totalCaja static
→ caja global compartida
```

## Relación con Main

Materiales anteriores ya mostraron:

```csharp
static void Main(string[] args)
```

Este nuevo contenido amplía el significado de `static`: no solo aparece en el punto de entrada, sino que también puede aplicarse a datos compartidos por toda una clase.

## Alcance

Este apunte conserva únicamente la diferencia entre miembros de instancia y estáticos tal como la desarrolla el material oficial.
