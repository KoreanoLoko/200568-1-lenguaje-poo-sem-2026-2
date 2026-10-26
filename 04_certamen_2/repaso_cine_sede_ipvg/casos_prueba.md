# Repaso Certamen 2 — Casos de prueba y resultados esperados

**Estado:** diseño de comprobaciones por cálculo estático de las reglas de negocio. **No son registros de una ejecución exitosa**, porque la plantilla recibida tiene un error de compilación en `Producto.ObtenerDetalle()`. Para ejecutar las pruebas debe completarse el `TODO` pendiente y compilarse el proyecto.

## 1. Validación de precios base

| Precio ingresado | `PrecioBase` esperado | Motivo |
| ---: | ---: | --- |
| -500 | 1.000 | Precio ≤0 |
| 0 | 1.000 | Precio ≤0 |
| 500 | 500 | Precio positivo, no se modifica |
| 4.500 | 4.500 | Precio positivo, no se modifica |

El setter fija el **mínimo de seguridad solo cuando el valor de entrada es no positivo**. No debe confundirse con forzar todos los precios inferiores a $1.000.

## 2. Entradas — recargos independientes

Con precio base $4.500:

| Es3D | FormatoSala | Cálculo | Final |
| --- | --- | --- | ---: |
| false | NORMAL | $4.500 | $4.500 |
| true | NORMAL | $4.500 + $1.500 | $6.000 |
| false | IMAX | $4.500 + $2.000 | $6.500 |
| true | IMAX | $4.500 + $1.500 + $2.000 | **$8.000** |

La opción 1 de la plantilla agrega una entrada llamada «Avatar 3» con precio base $4.500, `Es3D = true` y `FormatoSala = "IMAX"`.

## 3. Snacks — recargo y descuento en orden

Con precio base $3.000:

| Tamaño | Combo | Cálculo | Final |
| --- | --- | --- | ---: |
| MEDIANO | false | $3.000 | $3.000 |
| MEDIANO | true | $3.000 × 0,90 | $2.700 |
| GIGANTE | false | $3.000 × 1,25 | $3.750 |
| GIGANTE | true | ($3.000 × 1,25) × 0,90 | **$3.375** |

La opción 2 agrega precisamente un snack «Popcorn Mantequilla» de $3.000, GIGANTE y combo.

## 4. Carrito de prueba

Si se selecciona una vez «Agregar Entrada», una vez «Agregar Snack» y luego «Pagar»:

| Ítem | Final |
| --- | ---: |
| Entrada 3D IMAX | $8.000 |
| Snack GIGANTE con combo | $3.375 |
| **Total de boleta esperado** | **$11.375** |
| **Caja después del pago** | **$11.375** |
| **Carrito después del pago correcto** | **0 ítems** |

El código recibido **sí acumula $11.375 en memoria**, pero no presenta el reporte de caja ni vacía el carrito, y además no compila antes de completar `ObtenerDetalle()`.

## 5. Parámetro out

La fórmula literal pedida por Canvas es `PrecioBase - PrecioFinal`:
- Entrada 3D IMAX: $4.500 − $8.000 = **−$3.500**.
- Snack GIGANTE combo: $3.000 − $3.375 = **−$375**.
- Snack MEDIANO combo: $3.000 − $2.700 = **+$300**.

En cambio, la plantilla **convierte todo ahorro ≤0 a 0**, por lo que entregaría $0 para los dos ítems definidos por defecto. Esta tabla expone la diferencia sin decidir por el docente una interpretación alternativa del requisito.

## 6. Procesamiento duplicado y salida

- Tras finalizar una venta correcta, una nueva opción 4 sin agregar productos debería cobrar $0 y dejar la caja inalterada.
- La versión recibida, al no ejecutar `Clear()`, repetiría el cobro del carrito.
- La opción 5 debe terminar el ciclo `do-while`.
- La opción 3 recorre la colección con `ProductoCine` y despacha `ObtenerDetalle()` al tipo concreto de cada ítem.

## Comprobación local cuando se complete el proyecto

```powershell
dotnet build
dotnet run
```

El contenido recibido no incluye `.csproj`, por lo que la verificación exige disponer de un proyecto C# de consola correspondiente y corregir antes los `TODO` que impiden compilar.
