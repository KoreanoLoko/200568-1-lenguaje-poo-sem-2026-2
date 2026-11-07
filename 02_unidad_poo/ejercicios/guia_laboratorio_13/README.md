# Guía de Laboratorio 13 — Auditoría y Certificación Agroindustrial

**Actividad:** «Interfaces (interface) y Contratos de Comportamiento en C#».  
**Institución:** IP Virginio Gómez, Lenguaje de Programación OO (0568).  
**Canvas:** sin fecha de entrega y **0 puntos**.  
**Contexto:** Fundo IPVG; C#/.NET CLI.

## Fuente de verdad y recursos

| Material | Rol y procedencia |
| --- | --- |
| [Enunciado](enunciado.md) | Instrucciones de Canvas transcritas por el estudiante |
| [Seis archivos C# del docente](ejemplo_docente/) | Código facilitado en el mensaje; reformateado sin rediseñarlo |
| [Análisis técnico](analisis_codigo.md) | Comparación de contratos, reglas, cifras y límites |
| [Presentación de la clase](../../clases/interfaces_y_polimorfismo_transversal.md) | Resumen **de las 12 diapositivas** y diferencias con la guía |
| [Apunte 31](../../apuntes/31_interfaces_contratos_polimorfismo_transversal.md) | Síntesis de interfaces, herencia única y polimorfismo transversal |
| [Fragmentos de transcripción](../../clases/transcripciones/fragmentos_interfaces_y_clases_abstractas.md) | Pasajes aportados de la explicación oral y cierre, **no clase completa** |

## Arquitectura del ejemplo de Canvas

```text
AuditoriaAgroindustrial.Core
├── IValorable (contrato)
├── IExportable (contrato)
├── AnimalGanado : IValorable
├── Bovino : AnimalGanado, IExportable
└── MaquinariaAgricola : IValorable, IExportable

AuditoriaAgroindustrial.App
└── Program
    ├── List<IValorable> (4 objetos de 2 familias)
    ├── foreach: tasar patrimonio
    └── foreach + is IExportable: emitir certificados
```

**Idea central:** `Bovino` hereda el cumplimiento de `IValorable` a través de `AnimalGanado` e implementa `IExportable`; `MaquinariaAgricola` implementa los dos contratos directamente.

## Estado documental

- El código publicado es **ejemplo del docente**, no solución del estudiante ni evidencia de ejecución o evaluación.
- Se conservaron los seis archivos de Canvas sin agregar requisitos que solo figuran en las diapositivas.
- No se recibió archivo `.csproj`, captura de consola, ni prueba real de `dotnet build`.
- La depreciación depende del **año del equipo al ejecutar**, por lo que los valores de muestra del [análisis](analisis_codigo.md) son sensibles a la fecha.
- El PDF original está **pendiente de carga manual** en `02_unidad_poo/clases/Interfaces_y_Polimorfismo_en_C.pdf`; este repositorio mantiene por ahora el resumen Markdown.
- Se preserva la jerarquía de [FUENTE_DE_VERDAD.md](../../../FUENTE_DE_VERDAD.md).

## Relación con el curso

- [Guía 12 — herencia y sobrescritura](../guia_laboratorio_12/README.md).
- [Certamen 2 — Ganadería Chan](../../../04_certamen_2/ganaderia_chan/README.md): comparación de `List<AnimalGanado>` y `List<IValorable>`.
