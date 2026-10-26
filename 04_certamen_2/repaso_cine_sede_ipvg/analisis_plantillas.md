# Auditoría estática de las cuatro plantillas del Repaso Certamen

**Alcance:** revisión del código recibido sin corregirlo ni atribuir resultados de compilación no observados. Los `.cs` en `plantillas_recibidas/` contienen la lógica original y los `// TODO` que aún figuran como comentarios.

## Resultado general

**Estado: parcial y no compilable tal como fue recibido.** La implementación de `Producto.ObtenerDetalle()` declara retorno `string` pero carece de instrucción `return`, lo que causa el error de compilación C# **CS0161: not all code paths return a value**. No se recibió un archivo de proyecto `.csproj` para esta actividad; no se ejecutó `dotnet build`.

## Análisis por archivo

| Archivo | Cumplido en la plantilla | Pendiente o desviación |
| --- | --- | --- |
| `Producto.cs` | File-scoped namespace, campo privado, propiedad completa de precio, mínimo por precios ≤0, método virtual de precio final | `ObtenerDetalle()` virtual tiene cuerpo vacío y no retorna `string`: error de compilación. |
| `EntradaCine.cs` | Herencia, `base(...)`, `Es3D`, `FormatoSala`, cálculo acumulativo de recargos y `override ObtenerDetalle()` | Depende del `ObtenerDetalle()` de la clase base; no hay verificación explícita de que una sala distinta de IMAX sea exactamente NORMAL. |
| `SnackCine.cs` | Herencia, `base(...)`, tamaño, combo, recargo de 25% y descuento de 10% posterior, `override ObtenerDetalle()` | También depende del método base sin retorno; un tamaño no vacío distinto de GIGANTE es aceptado como texto. |
| `Program.cs` | Alias de tipos, menú, `do-while`/`switch`, `List<ProductoCine>`, `foreach`, `ref` y `out` en `ProcesarVenta` | Falta `using CineIPVG.Core;` escrito explícitamente; la opción 4 no muestra monto, descuento, total ni caja y no ejecuta `carrito.Clear()`. |

**Detalles adicionales:**
- El `using System.Runtime.InteropServices.Marshalling;` en `Program.cs` no se utiliza en el código recibido; no forma parte de la consigna. La lista depende de importaciones implícitas o de agregar `System.Collections.Generic` según la configuración real del proyecto, que no fue adjuntada.
- `Console.WriteLine($"");` en la opción 4 solo imprime una línea vacía; no es un reporte de cobro.
- La caja está declarada como variable **local** `cajaGlobalCine` en `Main`, y se modifica mediante `ref`. La palabra «global» es el nombre elegido para la variable, no describe su alcance léxico en C#.
- El método `ProcesarVenta` **devuelve `decimal`** con el precio final además del `out` y la modificación por referencia. El enunciado fija sus parámetros, pero no especifica un tipo de retorno distinto.
- El cuerpo de `Producto.ObtenerDetalle()` vacío es el bloqueo principal e impide validar funcionalmente el resto del sistema.

## Diferencia relevante en descuentoAplicado

El enunciado especifica literalmente:

```csharp
descuentoAplicado = producto.PrecioBase - precioFinal;
```

El código recibido añade otra condición:

```csharp
if (descuentoAplicado <= 0)
    descuentoAplicado = 0;
```

Por ello, **no devuelve los resultados negativos** que aparecen cuando el precio final es superior al base. Esto puede interpretarse como evitar informar «ahorros negativos», pero **no coincide exactamente con la fórmula solicitada**. No se modifica el archivo, solo se registra la discrepancia.

En snacks gigantes con combo, el descuento del 10% se aplica sobre el precio recargado, no necesariamente sobre el precio base. El ahorro informado respecto del precio base puede ser cero cuando el resultado final supera el precio de partida.

## Estado de los TODO del material

| Etiqueta del archivo | Estado real |
| --- | --- |
| TODO 1 — file-scoped namespace | Implementado, comentario conservado. |
| TODO 2 — propiedad completa `PrecioBase` | Implementado, comentario conservado. |
| TODO del setter | Implementado. |
| TODO 3 — `CalcularPrecioFinal()` virtual | Implementado. |
| TODO 4 — `ObtenerDetalle()` virtual | **Incompleto: falta retorno.** |
| TODO 6 — constructor de entrada con `base(...)` | Implementado. |
| TODO 7 — override de precio de entrada | Implementado. |
| TODO 9 — constructor de snack con `base(...)` | Implementado. |
| TODO 10 — override de precio de snack | Implementado. |
| TODO 11 — importación y alias | Alias implementado; falta el `using CineIPVG.Core;` explícito. |
| TODO 12 — método transaccional `ref`/`out` | Implementado parcialmente; diferencia en el cálculo de descuento. |
| TODO 13 — carrito genérico | Implementado. |
| TODO 14 — recorrido polimórfico | Implementado. |
| TODO 15 — pago, reporte y `Clear()` | **Incompleto:** suma ventas pero no muestra la boleta ni vacía el carrito. |

**Nota de trazabilidad:** los números TODO 5 y 8 no aparecen en los cuatro archivos recibidos. No se infieren ni inventan sus contenidos.

## Riesgo de cobro duplicado

Debido a que no se ejecuta `carrito.Clear()`, si se selecciona la opción 4 dos veces, el código procesará nuevamente los mismos objetos y aumentará por segunda vez el total de `cajaGlobalCine`. Es un riesgo funcional observable y uno de los motivos para respetar la instrucción final de vaciar la lista.

## Qué material procede de las clases anteriores

- Encapsulamiento con `private` + propiedad `get/set` y `decimal`: Guía 11 y Semana 8.
- Herencia `: Producto`, constructores `: base(...)`, métodos `virtual`/`override`: semanas 8–9.
- Polimorfismo y despacho dinámico de una `List<Producto>`: Semana 9 y Guía 12.
- `ref`, `out` y obligación de inicializar el parámetro de salida: Certamen 1 y apuntes de parámetros avanzados.
- `do-while`, `switch`, `foreach` y `List<T>`: materia anterior.

## Respaldo fiel y límites

- Los cuatro fuentes se almacenan como **plantillas recibidas**, no como «solución final», sin rellenar `TODO`.
- `Program(6).cs` se renombra documentalmente a `Program.cs` para facilitar reconocimiento del punto de entrada.
- No se añadió `.csproj` inexistente ni se afirmó compilación satisfactoria.
- No se publica una rúbrica del Certamen 2: **no fue proporcionada**.
