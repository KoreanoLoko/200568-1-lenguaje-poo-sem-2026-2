# Guía de Laboratorio 13 — Interfaces y Contratos de Comportamiento en C#

> **Origen:** enunciado de Canvas copiado por el estudiante. Se preservan las especificaciones, el caso y sus seis fuentes, normalizando saltos de línea y escapes del mensaje únicamente para legibilidad.

## Metadatos

- **Título Canvas:** Guía de Laboratorio 13.
- **Actividad:** «Interfaces (interface) y Contratos de Comportamiento en C#».
- **Caso:** Módulo de Auditoría y Certificación Agroindustrial — Fundo IPVG.
- **Fecha de entrega:** no hay fecha de entrega.
- **Puntos:** 0.
- **Asignatura:** Lenguaje de Programación OO (0568); Área de Informática, IP Virginio Gómez.

## Conceptos expresamente presentados

1. **Interfaz:** contrato que requiere implementar miembros como propiedades y métodos.
2. **Implementación múltiple:** una clase concreta puede heredar de una sola clase base y, simultáneamente, cumplir múltiples interfaces; p. ej. `Bovino : AnimalGanado, IExportable` y `MaquinariaAgricola : IValorable, IExportable`.
3. **Polimorfismo heterogéneo:** `List<IValorable>` reúne entidades de familias diferentes y permite invocar un contrato común.

## Preparación del proyecto

El texto instruye crear por .NET CLI un proyecto de consola **`AuditoriaAgroindustrial`** con seis archivos independientes:

| Archivo | Rol |
| --- | --- |
| `IValorable.cs` | Contrato: `CodigoActivo { get; }`, `CalcularTasacionComercial()`, `ObtenerFichaAuditoria()` |
| `IExportable.cs` | Contrato: `PaisDestino { get; set; }`, `CumpleNormaFitosanitaria { get; }`, `GenerarCertificadoExportacion()` |
| `AnimalGanado.cs` | Clase base concreta que implementa `IValorable`, peso mínimo 100 kg y valoración de 2.000m/kg |
| `Bovino.cs` | Hereda de AnimalGanado, añade `IExportable`, aplica 25 % de incremento de tasación base y bono 100.000m si cumple norma |
| `MaquinariaAgricola.cs` | Implementa ambas interfaces sin heredar de AnimalGanado; depreciación del 8 % anual con valor mínimo 1.000.000m |
| `Program.cs` | Crea `List<IValorable>` con dos bovinos y dos maquinarias, suma patrimonio y emite certificados mediante pattern matching |

## Reglas de dominio del código entregado

- `AnimalGanado`: `pesoKilos >= 100m ? pesoKilos : 100m`. Usa campos `protected` y métodos `virtual`.
- `Bovino`: `base.CalcularTasacionComercial() * 1.25m` y, si `CumpleNormaFitosanitaria`, `+ 100000m`.
- `MaquinariaAgricola`: `antiguedad = DateTime.Now.Year - AnioFabricacion`; se descuenta `antiguedad * 0.08m` del `ValorCompra` y se establece piso de `1000000m`.
- `CumpleNormaFitosanitaria` de maquinaria devuelve `AnioFabricacion >= 2020` (regla del ejemplo, no se presenta como norma jurídica real).
- `Program.cs` precarga exactamente `BOV-901`, `BOV-902`, `MAQ-301`, `MAQ-302` y ejecuta dos recorridos `foreach`: tasación y certificados de exportación.

## Archivos fuente

Los seis archivos aparecen en [ejemplo_docente](ejemplo_docente/). Se mantienen sus nombres, firmas, reglas, textos y datos de prueba. Los fragmentos pegados en la conversación venían comprimidos en una sola línea y con algunos escapes Markdown (por ejemplo, `List\\<IValorable>`, `DateTime.Now\\.Year`, `\\*`); se normalizaron a sintaxis C# y saltos de línea sin alterar la semántica.

**No se añadió `.csproj` ni se ejecutó compilación**. El comando general de creación de proyecto está descrito como instrucción, no como evidencia de ejecución.

## Diferencia respecto del PDF de la clase

El [PDF](../../clases/interfaces_y_polimorfismo_transversal.md) plantea otro taller con `Tractor`, `LoteManzana`, `InsumoQuimico`, cinco instancias y menú. Es un **enunciado de diapositiva diferente** del ejemplo entregado con esta Guía 13; se conservan ambos sin amalgamarlos.
