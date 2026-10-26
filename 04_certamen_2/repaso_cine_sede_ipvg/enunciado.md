# Repaso Certamen — Sistema de Venta de Entradas y Snacks (Cine Sede IPVG)

**Origen:** actividad «Repaso Certamen», texto de Canvas proporcionado por el estudiante. **Fecha de entrega:** no hay fecha de entrega. **Puntos:** 0. Este material es un **taller preparatorio**, no el enunciado del Certamen 2.

## Instrucciones docentes

El taller busca consolidar los aprendizajes prácticos antes de la evaluación. El material se entrega como **cuatro plantillas iniciales independientes** con instrucciones `// TODO:`. Se pide descargar el proyecto base, completar las tareas, compilar y ejecutar.

## Caso de estudio y contexto

La administración del cine institucional desea un punto de venta en consola C#/.NET que atienda tanto entradas a las salas como snacks y combos de confitería. La arquitectura debe combinar namespaces, encapsulación, jerarquías de herencia, polimorfismo, parámetros avanzados y colección dinámica.

## A. Producto.cs — Capa lógica y encapsulamiento

1. Todas las clases del dominio pertenecen a `namespace CineIPVG.Core;`.
2. Un campo privado `precioBase` se protege mediante una **propiedad completa** `PrecioBase`. Si se asigna un valor **menor o igual que cero**, el setter lo sustituye por **`1000m`**. El enunciado no exige elevar otros precios positivos inferiores a $1.000.
3. Crear métodos virtuales: `CalcularPrecioFinal()`, que devuelve el precio base, y `ObtenerDetalle()`, que produce una ficha descriptiva.

## B. EntradaCine.cs y SnackCine.cs — Herencia y precios

### EntradaCine

- Deriva de `Producto` e invoca `: base(...)`.
- Tiene `bool Es3D` y `string FormatoSala` («NORMAL» o «IMAX»).
- Sobrescribe `CalcularPrecioFinal()`: añade **`1500m`** si `Es3D`; añade **`2000m`** si `FormatoSala == "IMAX"`. Son recargos acumulables.

### SnackCine

- Deriva de `Producto`.
- Tiene `string Tamaño` («MEDIANO» o «GIGANTE») y `bool EsCombo`.
- Si el tamaño es «GIGANTE», aplica **25% de recargo al precio base**.
- Si además es combo, aplica **10% de descuento sobre el subtotal acumulado**; el descuento ocurre **después** de aplicar el recargo de tamaño.

## C. Program.cs — Transacción y colección

1. Importar `CineIPVG.Core` y declarar el alias de tipo `ProductoCine` para `CineIPVG.Core.Producto`.
2. Implementar `ProcesarVenta(ProductoCine producto, ref decimal cajaCine, out decimal descuentoAplicado)`:
   - El argumento `ref` suma a la caja el precio final de cada producto.
   - El resultado `out` se define literalmente como **`PrecioBase - PrecioFinal`**.
3. Usar `List<ProductoCine>` para el carrito.
4. Recorrer polimórficamente la lista y consultar el detalle correspondiente al tipo real del objeto.

## Entrega y comprobación

- **Entorno:** solución de consola C#.
- **Verificación solicitada:** demostrar ingreso de ítems, cálculo polimórfico de subtotales, arqueo de caja y **vaciado final del carrito**.

## Fuentes adjuntas a este registro

Las cuatro plantillas se conservan en [plantillas_recibidas/](plantillas_recibidas/) como **estado recibido, parcialmente trabajado, con TODO pendientes**. `Program(6).cs` se normalizó a `Program.cs` solo en el nombre del archivo de respaldo.

Ver [análisis del estado recibido](analisis_plantillas.md), [pruebas de referencia](casos_prueba.md) y [temario asociado](../temario_repaso_cine_ipvg.md).
