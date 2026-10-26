# Repaso Certamen — Cine Sede IPVG

**Actividad de Canvas:** «Repaso Certamen».  
**Entrega:** sin fecha de entrega; 0 puntos.  
**Propósito:** taller preparatorio para el Certamen 2 de Lenguaje POO, no evaluación oficial ni solución cerrada.

## Contenido

```text
repaso_cine_sede_ipvg/
├── README.md
├── enunciado.md
├── analisis_plantillas.md
├── casos_prueba.md
└── plantillas_recibidas/
    ├── Producto.cs
    ├── EntradaCine.cs
    ├── SnackCine.cs
    └── Program.cs
```

- [Enunciado del taller](enunciado.md): requisitos originales del caso de cine.
- [Auditoría de los TODO y brechas](analisis_plantillas.md): elementos completos, incompletos e inconsistencias.
- [Casos de prueba calculados](casos_prueba.md): precios de referencia y comportamiento esperado.
- [Temario para el repaso](../temario_repaso_cine_ipvg.md): relación directa con la materia del repositorio.

## Política de respaldo de código

Los cuatro archivos de C# **son el estado recibido del estudiante**, con comentarios `// TODO` originales y secciones incompletas. No se han completado ni corregido silenciosamente. El archivo cargado como `Program(6).cs` se guarda bajo el nombre funcional de `Program.cs` para organizar el proyecto. Se normaliza a texto UTF-8 sin BOM y con finales de línea LF.

**Atención: plantilla no compilable** por `Producto.ObtenerDetalle()` sin retorno. El registro es material de estudio, **no una solución final para entregar**.

## Conceptos puestos a prueba

| Tema | Evidencia |
| --- | --- |
| Namespace y alias | `CineIPVG.Core`, `CineIPVG.App`, `using ProductoCine = ...` |
| Encapsulación | Campo privado `precioBase` y setter de `PrecioBase` |
| Herencia | `EntradaCine : Producto`, `SnackCine : Producto` |
| Constructor base | `: base(codigo, nombre, precioBase)` |
| Polimorfismo | `virtual`/`override` en precio y detalle, despacho por `List<ProductoCine>` |
| Métodos con parámetros especiales | `ref decimal cajaGlobalCine`, `out decimal descuentoAplicado` |
| Colecciones | `List<ProductoCine>`, `Add`, `foreach` y `Clear()` requerido (aún ausente) |
| Control de flujo | `do-while`, `switch`, `if` |

## Procedencia y límites

- **Fuente de requisitos:** texto Canvas facilitado por el estudiante.
- **Fuente de código:** cuatro archivos C# adjuntos.
- **Proyecto .NET:** no se adjuntó `.csproj`; no se crea uno ficticio.
- **Compilación:** no se afirma exitosa ni se publica un resultado de test automatizado.
- **Certamen 2:** todavía no se ha entregado la evaluación oficial o rúbrica; el documento se identifica como **repaso**.

## Enlaces a unidades previas

- [Semana 8 — Encapsulamiento y herencia](../../02_unidad_poo/clases/encapsulamiento_y_herencia_en_csharp.md).
- [Semana 9 — Polimorfismo](../../02_unidad_poo/clases/arquitectura_herencia_y_polimorfismo.md).
- [Guía 12 — GuardiaSede](../../02_unidad_poo/ejercicios/guia_laboratorio_12/README.md).
- [Certamen 1](../../03_certamen_1/temario.md): reutilización de `ref` y `out`.

El siguiente certamen se preparará a partir de lo realmente enseñado y de las instrucciones específicas de su evaluación, sin suponer que este taller determina una rúbrica.
