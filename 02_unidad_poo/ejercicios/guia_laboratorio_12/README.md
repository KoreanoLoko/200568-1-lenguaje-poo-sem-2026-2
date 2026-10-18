# Guía de Laboratorio 12 — Registro documental (sin código fuente agregado)

**Actividad:** «Incorporación del Rol de Guardia de Seguridad en la Sede IPVG».  
**Entrega Canvas:** 16 de octubre de 2026 a las 23:59.  
**Puntos:** 0; **entrega:** carga de archivo.

## Qué se incorpora al repositorio

| Documento | Procedencia |
| --- | --- |
| [enunciado.md](enunciado.md) | Requisitos de Canvas de la Guía 12 |
| [analisis_archivos_base.md](analisis_archivos_base.md) | Análisis de los cinco adjuntos .cs/.csproj, sin almacenar sus fuentes |
| [Semana 9 — clase en Markdown](../../clases/arquitectura_herencia_y_polimorfismo.md) | Análisis de 11 diapositivas |
| [Apunte 30](../../apuntes/30_polimorfismo_despacho_dinamico_sobrecarga_override.md) | Polimorfismo, sobrecarga, override y despacho dinámico |

**Único material original destinado a guardarse en este repositorio:** el PDF de la Semana 9, en `02_unidad_poo/clases/Arquitectura-Herencia y Polimorfismo.pdf`, **pendiente de subida manual del estudiante**. Los archivos `AdministrativoSede.cs`, `ColaboradorSede(1).cs`, `DocenteSede(1).cs`, `Program(5).cs` y `SistemaGestionPersonal.csproj` **se describen pero no se incorporan**.

## Estado del desafío

Los adjuntos representan una jerarquía con `DocenteSede` y `AdministrativoSede`, una base `ColaboradorSede` con métodos virtuales y una `List<ColaboradorSede>` recorrida con `foreach`.

**No se considera resuelta la Guía 12**: falta `GuardiaSede`, faltan las tres clases juntas en la lista y el programa adjunto no incluye menú. Además, el enunciado pide `CalcularSueldoTotal()` mientras los adjuntos utilizan `CalcularSueldoLiquido()`.

## Conexión con la asignatura

- [Semana 8](../../clases/encapsulamiento_y_herencia_en_csharp.md): encapsulamiento, herencia y constructor base.
- [Semana 9](../../clases/arquitectura_herencia_y_polimorfismo.md): dynamic dispatch, override y reutilización con `base.Metodo()`.
- La Guía 12 extiende la jerarquía a un tercer rol, aprovechando una sola lista y una sola llamada virtual por elemento.

**No se han modificado ni incorporado archivos fuente C# ni proyectos .NET a raíz de esta guía.**
