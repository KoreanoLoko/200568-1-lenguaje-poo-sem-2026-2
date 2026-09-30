# Variables Primitivas e Inferencias de Tipo en C#

Material oficial transcrito y organizado desde la página **Variables Primitivas e Inferencias de Tipo en C#** publicada en Canvas.

## 1. Variables Primitivas e Inferencias de Tipo en C#

El material presenta a C# como un lenguaje de tipado estático y seguro (**strongly-typed**) en el que cada variable posee un tipo de dato definido en tiempo de compilación.

### Tipos de datos trabajados

#### int

El material lo presenta como un entero de 32 bits utilizado para conteos, por ejemplo:

- stock de completos;
- stock de bebidas.

#### double

Se presenta como un tipo de 64 bits utilizado para cálculos generales o físicos.

La página advierte que puede producir errores de redondeo binario en cálculos monetarios.

#### decimal

La fuente presenta `decimal` como tipo de 128 bits con base 10 y lo recomienda para cálculos financieros y comerciales.

El material muestra el uso del sufijo:

```csharp
2500.50m
```

o:

```csharp
2500.50M
```

### Advertencia de desarrollo incluida en la fuente

La página señala expresamente que, en programación de negocios, no se deben usar `float` o `double` para saldos de caja o precios, y que se debe utilizar `decimal` para cálculos monetarios.

> Este repositorio conserva esta recomendación como parte de la fuente oficial de la asignatura.

#### string

La fuente lo presenta como un tipo de referencia inmutable para representar nombres de productos o códigos.

#### bool

Se utiliza para estados booleanos:

```text
true
false
```

## Inferencia de tipos con var

La página introduce:

```csharp
var
```

como mecanismo de inferencia de tipo para variables locales.

La fuente enfatiza que:

- no es tipado dinámico;
- el compilador infiere el tipo exacto a partir del valor asignado;
- una vez compilada, la variable mantiene un tipo estático.

---

## 2. Estructuras de Bifurcación e Iteración

El material incorpora estructuras para controlar el flujo operativo.

### if / else if / else

Se utilizan para evaluar condiciones booleanas y ejecutar caminos alternativos.

Ejemplo conceptual indicado:

```text
validar si existe stock suficiente
```

### switch

Se presenta como una estructura de selección múltiple para comparar un valor discreto contra varias opciones.

### do-while

Se presenta como un bucle que garantiza al menos una ejecución del bloque antes de evaluar la condición.

El material lo considera adecuado para:

- menús interactivos de consola;
- escenarios donde se espera al menos una acción del usuario.

---

## 3. Miembros de Instancia frente a Miembros Estáticos (static)

La fuente presenta esta diferencia como un concepto fundamental para estructurar software.

### Miembros de instancia

Corresponden a campos y propiedades que **no** utilizan `static`.

Según la página:

- pertenecen a un objeto particular;
- cada instancia mantiene sus propios datos;
- se ejemplifica con objetos `ItemMenu`;
- cada producto puede mantener su propio valor de `Stock`.

Ejemplo conceptual:

```text
ItemMenu "Completo Italiano" → Stock propio
ItemMenu "Bebida"            → Stock propio
```

### Miembros estáticos

Se declaran mediante:

```csharp
static
```

Según el material:

- pertenecen a la clase;
- no pertenecen a un objeto particular;
- existe un único dato compartido para todas las instancias.

El ejemplo utilizado es:

```text
totalCaja
```

como caja común del Food Truck.

Todas las ventas, independientemente del producto vendido, acumulan su valor en ese mismo miembro estático.

## Analogía física del camión

La fuente resume la diferencia así:

```text
Stock
→ dato particular de cada producto

totalCaja static
→ una sola caja común para todas las ventas
```

## Conceptos incorporados o reforzados

- tipado estático;
- `int`;
- `double`;
- `decimal`;
- sufijos `m` y `M`;
- `string`;
- `bool`;
- `var`;
- `if / else if / else`;
- `switch`;
- `do-while`;
- miembros de instancia;
- miembros estáticos;
- `static`;
- datos propios de cada objeto;
- datos compartidos por la clase.

## Alcance

Este archivo conserva las afirmaciones, ejemplos y nivel de detalle de la página oficial de Canvas. No sustituye ni corrige su contenido mediante documentación externa.
