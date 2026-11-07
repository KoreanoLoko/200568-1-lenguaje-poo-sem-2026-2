# Arquitectura Avanzada en C#: Interfaces y Polimorfismo Transversal

**Fuente primaria:** presentación oficial «Interfaces_y_Polimorfismo_en_C.pdf» (12 páginas; título interno: «Arquitectura Avanzada en C#: Interfaces y Polimorfismo Transversal»).  
**Aplicación:** Sistema de Auditoría Agroindustrial — Fundo IPVG.  
**PDF original pendiente de subida manual:** [Interfaces_y_Polimorfismo_en_C.pdf](Interfaces_y_Polimorfismo_en_C.pdf).  
**Material relacionado:** [Guía 13](../ejercicios/guia_laboratorio_13/README.md) y [apunte 31](../apuntes/31_interfaces_contratos_polimorfismo_transversal.md).

> Este documento describe las diapositivas observadas. No sustituye el PDF oficial; el código de las diapositivas es **ilustrativo y distinto** del código de Canvas de la Guía 13.

## Mapa de las 12 diapositivas

| Página | Encabezado y contenido |
| ---: | --- |
| 1 | **Arquitectura Avanzada en C#: Interfaces y Polimorfismo Transversal**. Caso aplicado: Auditoría Agroindustrial, Fundo IPVG. |
| 2 | **El límite de la herencia tradicional**. Un tractor y un lote de manzanas no comparten necesariamente una relación «es un»; se advierte contra forzar una clase `ObjetoAuditable` solo para agrupar la valorización. |
| 3 | **La solución: Contratos de Comportamiento**. La interfaz fija capacidades («qué puede hacer») y exige implementar los miembros acordados, independientemente de la jerarquía de clases. |
| 4 | **Matriz Estructural: Clase Abstracta vs. Interfaz**. Compara propósito, estado, herencia e implementación. La clase abstracta modela una identidad; la interfaz, capacidades transversales. |
| 5 | **Definiendo nuestro primer contrato**. Ejemplo ilustrativo `IValorable` en `SistemaAuditoria`, con `CodigoAuditoria { get; }` y `CalcularValorMercado()`. |
| 6 | **Conectando las piezas al contrato**. `Tractor : IValorable` y `LoteManzana : IValorable`: ambas implementan la operación de tasación de formas distintas. |
| 7 | **Rompiendo el límite: Implementación Múltiple**. `LoteManzana : IValorable, IExportable`; ejemplo de `IExportable` con `CumpleNormativaSAG()`. |
| 8 | **Arquitectura del Fundo IPVG**. Diagrama de contratos `IValorable` / `IExportable` conectados con tractor, lote de manzanas y galpón; el comportamiento atraviesa familias distintas. |
| 9 | **Colecciones Genéricas y Tipos Abstractos**. `List<IValorable>` acepta implementadores de la interfaz; se ilustran `Add(new Tractor())` y `Add(new LoteManzana())`. |
| 10 | **Flujo Funcional de Auditoría**. `foreach (IValorable activo in inventario)` acumula `activo.CalcularValorMercado()`. El monto visualizado de $45.500.000 es una cifra ilustrativa, **no** el resultado del código de Guía 13. |
| 11 | **Taller Práctico: Sistema de Auditoría Fundo IPVG**. Crear interfaz, clases `Tractor`, `LoteManzana`, `InsumoQuimico`, al menos **5 instancias** en `List<IValorable>`, y menú `do-while`/`switch`. |
| 12 | **Robustez del Sistema: Gestión de Excepciones**. Ejemplo `try-catch` y `throw new InvalidOperationException(...)` para detectar valores comerciales negativos, con reporte de `ex.Message`. |

## Mensajes arquitectónicos del PDF

### Contrato frente a jerarquía

La presentación plantea que no corresponde forzar una herencia artificial entre objetos diferentes solo para auditarlos. El contrato `IValorable` representa la **capacidad de tasación**, no la identidad física del objeto.

### Clase abstracta frente a interfaz (página 4)

| Dimensión | Clase abstracta | Interfaz |
| --- | --- | --- |
| Propósito | Identidad base («es un») | Capacidad transversal («puede») |
| Estado | Puede contener campos y constructores | El material indica que no contiene estado de instancia propio ni constructores de instancia |
| Composición de tipos | Herencia de una sola clase base | Una clase puede implementar varias interfaces |
| Implementación | Admite miembros con código, incluidos métodos virtuales | El PDF reconoce implementaciones por defecto en .NET moderno, aunque enseña principalmente firmas sin cuerpo |

**Precisión sobre la exposición oral:** la afirmación simplificada «la interfaz solamente tiene métodos» debe leerse junto con la página 5 del PDF, que **incluye una propiedad** `CodigoAuditoria { get; }`. La Guía 13 también declara propiedades en sus interfaces. Esta diferencia queda registrada, sin reescribir la explicación del docente.

### Colecciones polimórficas

La interfaz se usa como tipo de la colección (`List<IValorable>`). Cada objeto concreto ejecuta su propia tasación; no es obligatorio compartir una clase padre del dominio.

### Casos del PDF que no coinciden literalmente con la Guía 13

- El PDF demuestra `Tractor`, `LoteManzana`, `GalponAlmacenaje` y propone `InsumoQuimico`. Canvas entrega **`AnimalGanado`, `Bovino`, `MaquinariaAgricola`**.
- El ejemplo visual de interfaz usa **`CodigoAuditoria` y `CalcularValorMercado()`**, mientras el proyecto Canvas usa **`CodigoActivo` y `CalcularTasacionComercial()`**.
- La diapositiva 7 menciona `IExportable.CumpleNormativaSAG()`, mientras Canvas declara `PaisDestino`, `CumpleNormaFitosanitaria` y `GenerarCertificadoExportacion()`.
- El taller de la diapositiva 11 pide cinco elementos y menú interactivo, pero el `Program.cs` provisto en Canvas utiliza **cuatro instancias** y dos bloques secuenciales, sin menú.
- La diapositiva 12 introduce `try-catch`, pero **no figura en el código inicial de la Guía 13**.

Estas diferencias se documentan para estudiar cada fuente en su contexto; no autorizan a alterar en silencio el código del docente.

## Procedencia, estado y resguardo

- El PDF fue recibido como adjunto en la conversación y se revisaron sus 12 páginas, incluidas tablas y diagramas.
- **Archivo PDF no incorporado todavía a GitHub**: el estudiante lo subirá manualmente a `02_unidad_poo/clases/Interfaces_y_Polimorfismo_en_C.pdf`.
- Los archivos C# facilitados en Canvas se conservan en [ejemplo_docente](../ejercicios/guia_laboratorio_13/ejemplo_docente/) por separado.
- La transcripción oral compartida no es una versión íntegra de la clase: [fragmentos disponibles](transcripciones/fragmentos_interfaces_y_clases_abstractas.md).
