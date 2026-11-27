# Pesquera Chan — Sistema de gestión y tasación acuícola

Material recibido en la revisión del tramo posterior a interfaces; el estudiante lo identifica con la semana 13. No se recibió enunciado independiente, rúbrica, fecha de entrega ni ZIP original. No se atribuye automáticamente a la Guía 14, que se reporta vacía. No confundir con [Ganadería Chan](../../../04_certamen_2/ganaderia_chan/README.md).

## Archivos

[Plantillas recibidas](plantillas_recibidas/): PezCultivo.cs, LoteSalmon.cs, LoteEspecieMarina.cs, Program.cs (adjunto Program(8).cs), PesqueraChan.csproj y PesqueraChan.slnx. Proyecto SDK .NET 10, Exe, ImplicitUsings y Nullable habilitados. Solución referencia el .csproj del mismo directorio.

- [Análisis y mapa de los 15 TODO](analisis_plantillas.md).
- [Reglas y valores de prueba calculados](casos_prueba.md).

**Estado:** plantillas incompletas; no constituyen una solución compilable en su estado recibido. Se conserva el contenido textual normalizando BOM UTF-8 y CRLF a LF, sin completar tareas ni corregir fórmulas. No se ha ejecutado el proyecto.

## Arquitectura pretendida

```text
PesqueraChan.Core (pendiente)
  PezCultivo
    LoteSalmon
    LoteEspecieMarina
PesqueraChan.App
  Program: alias PezChan, List<PezChan>, do-while, switch, foreach, ref/out
```

La relación de herencia se solicita en comentarios, pero no está implementada en las declaraciones originales. Los override de ficha ya aparecen escritos.
