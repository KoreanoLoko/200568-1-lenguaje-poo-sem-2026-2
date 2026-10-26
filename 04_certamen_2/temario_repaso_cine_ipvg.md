# Temario de estudio derivado del Repaso Certamen — Cine Sede IPVG

> **Alcance:** este temario se infiere únicamente del taller «Repaso Certamen» y de las cuatro plantillas recibidas; **no es una rúbrica ni un temario oficial exhaustivo del Certamen 2**.

## Contenidos que el caso ejercita

| Concepto | Qué debes poder explicar o realizar | Archivo del taller |
| --- | --- | --- |
| File-scoped namespace | Diferencia entre `CineIPVG.Core` y `CineIPVG.App` | Cuatro archivos |
| `using` y alias | Dar nombre corto al tipo base `ProductoCine` | `Program.cs` |
| Encapsulación | Propiedad completa con campo privado y validación usando `value` | `Producto.cs` |
| Constructores | Recibir e inicializar datos del producto; `: base(...)` | `EntradaCine.cs`, `SnackCine.cs` |
| Herencia Is-A | Una entrada y un snack **son un** producto | Derivadas de `Producto` |
| Sobrescritura | Calcular precios por tipo mediante `override` | Ambos productos |
| Polimorfismo | Llamar `ObtenerDetalle()` desde `List<ProductoCine>` | `Program.cs` |
| Tipo `decimal` | Calcular montos y porcentajes usando sufijo `m` | Reglas de precios |
| `ref` | Sumar dinero a la caja de `Main` | `ProcesarVenta` |
| `out` | Entregar el ahorro definido por Canvas | `ProcesarVenta` |
| `List<T>` | `Add`, `foreach` y `Clear` después de cobrar | Carrito |
| Control de flujo | `do-while`, `switch`, condicionales | Menú |
| Validación y pruebas | Detectar precio ≤0, orden recargo/descuento, doble cobro | Regla de negocio |

## Preguntas de defensa técnica sugeridas

1. ¿Qué ocurre cuando `PrecioBase` recibe cero o un valor negativo?
2. ¿Por qué el precio del 3D IMAX suma ambos recargos?
3. ¿Por qué en un snack «GIGANTE + COMBO» el 10% se aplica luego del 25%?
4. ¿Por qué no es necesario separar la lista en entradas y snacks para mostrar los detalles?
5. ¿Cuál es la diferencia entre `virtual` y `override`?
6. ¿Qué se modifica en el llamador cuando se pasa `ref decimal cajaGlobalCine`?
7. ¿Qué debe ocurrir con `out decimal descuentoAplicado` antes de que termine `ProcesarVenta`?
8. ¿Por qué es necesario ejecutar `Clear()` después del cobro?
9. ¿Qué error de compilación produce la clase base incompleta?
10. ¿En qué se diferencia el valor pedido de `PrecioBase - PrecioFinal` de la versión que elimina resultados negativos?

## Cálculos de control (no ejecución verificada)

- Entrada de $4.500, 3D e IMAX: **$8.000**.
- Snack de $3.000, gigante y combo: **$3.375**.
- Carrito con ambos ítems: **$11.375**.

Ver [enunciado y material respaldado](repaso_cine_sede_ipvg/README.md) y [casos de prueba](repaso_cine_sede_ipvg/casos_prueba.md).
