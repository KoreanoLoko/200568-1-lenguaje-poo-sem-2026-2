# Certamen 2 — Módulo de Gestión de Ventas: Ganadería Chan

**Asignatura:** Lenguaje de Programación Orientada a Objetos (200568-1), semestre 2026-2 — IP Virginio Gómez.  
**Procedencia:** enunciado y rúbrica de Canvas transcritos por el estudiante; cuatro plantillas C# pegadas en la conversación; tres archivos de avances compartidos por el estudiante; propuesta de implementación de Program.cs y correcciones sugeridas por el asistente.  
**Fecha del trabajo en conversación:** 30 de octubre de 2026. El enunciado decía entrega a las 22:30 «del día de hoy»; no se verificó la fecha directamente en Canvas.  
**Estado:** documentación del proceso; no hay confirmación de compilación exitosa, ejecución en Visual Studio, entrega ZIP ni calificación.

## Organización y jerarquía documental

1. [Enunciado](enunciado.md) — transcripción del caso y requisitos técnicos **atribuidos al docente**.
2. [Rúbrica](rubrica.md) — criterios de 100 puntos/51 % de exigencia **atribuidos a Canvas**.
3. [Plantillas recibidas](plantillas_recibidas/) — cuatro archivos del docente tal como se pegaron, **incompletos y no compilables por sus TODO**. No se dispone del ZIP original ni del proyecto .csproj.
4. [Avances compartidos por el estudiante](avances_estudiante/) — AnimalGanado.cs, Bovino.cs y Porcino.cs en el estado efectivamente mostrado por el estudiante. **No** se recibió un Program.cs terminado por el estudiante.
5. [Propuesta de referencia](propuesta_asistente/) — cuatro fuentes C# construidos como **ejemplo derivado del trabajo y de los ajustes propuestos**; no deben confundirse con los originales docentes ni con una versión entregada.
6. [Análisis y aprendizajes](analisis_aprendizajes.md) — mapa de TODO, conceptos, diferencias detectadas, decisiones no especificadas y precauciones.
7. [Casos de prueba calculados](casos_prueba.md) — resultados aritméticos **esperados**, no pruebas ejecutadas.

## Objetivo pedagógico

Unificar bovinos y porcinos mediante `AnimalGanado`, con encapsulamiento, herencia, métodos virtuales y sobrescritos, inicialización con `: base(...)`, listas genéricas, recorrido polimórfico y un método transaccional con `ref`/`out`.

## Alcance y límites importantes

- **Fuente de verdad:** [reglas generales](../../FUENTE_DE_VERDAD.md). El enunciado y la rúbrica prevalecen sobre notas y soluciones derivadas.
- El valor de `bonificacionEspecial` **no tiene fórmula explícita** en el texto proporcionado; la propuesta del asistente usa una interpretación provisional, documentada por separado.
- Los pesos, razas, categorías y cantidades de los cuatro registros precargados de la propuesta son **datos ilustrativos inventados para verificar**, no registros oficiales del docente. Los únicos identificadores exigidos son BOV-101, BOV-102, POR-201 y POR-202.
- La propuesta reinicia el acumulador antes de recalcular el arqueo para evitar dobles sumas por consulta repetida; este comportamiento tampoco está definido literalmente en el enunciado.
- El código del estudiante mostrado para `AnimalGanado.cs` conserva dos desviaciones frente a la rúbrica: atributos `public` en lugar de `protected`, y `ObtenerFicha()` sin `virtual`. No consta si las corrigió después.
- No se ha incorporado ningún `.csproj`, ZIP descargado de Canvas, prueba ejecutada o evidencia de entrega.

## Relación con materiales previos

- [Repaso Certamen 2 — Cine IPVG](../repaso_cine_sede_ipvg/README.md): alias, lista, `ref`/`out`, polimorfismo y menú.
- [Semana 8 — Encapsulamiento y herencia](../../02_unidad_poo/clases/encapsulamiento_y_herencia_en_csharp.md).
- [Semana 9 — Arquitectura, herencia y polimorfismo](../../02_unidad_poo/clases/arquitectura_herencia_y_polimorfismo.md).
- [Apunte 30 — Despacho dinámico](../../02_unidad_poo/apuntes/30_polimorfismo_despacho_dinamico_sobrecarga_override.md).
- [Apunte 18 — Parámetros por valor, ref y out](../../02_unidad_poo/apuntes/18_parametros_valor_ref_out.md).
