# Guía de Laboratorio 12 — Incorporación del Rol de Guardia de Seguridad en la Sede IPVG

> Enunciado transcrito y organizado a partir de la tarea publicada en Canvas, suministrada por el estudiante. No contiene código de solución inventado.

## Datos de la actividad

- **Fecha de entrega indicada:** 16 de octubre de 2026, 23:59.
- **Puntos:** 0.
- **Entrega:** carga de archivo.
- **Título del taller:** «Incorporación del Rol de Guardia de Seguridad en la Sede IPVG».

## Ficha del desafío

**Objetivo:** extender la jerarquía de clases de la sede mediante una subclase `GuardiaSede`, aplicando **polimorfismo** para gestionar tipos diferentes de colaboradores en una única colección genérica `List<ColaboradorSede>`.

La Dirección de la sede integra a personal de seguridad a la nómina. El estudiante debe construir `GuardiaSede` e integrarla en el sistema existente.

## Paso 1 — GuardiaSede.cs (15 minutos)

1. Declarar `GuardiaSede` heredando de `ColaboradorSede` mediante `:`.
2. Incluir miembros propios:
   - `public bool TurnoNocturno { get; set; }` — indica turno de noche.
   - `public int HorasExtra { get; set; }` — horas extra mensuales.
3. Constructor con `rut`, `nombre`, `sueldoBase`, `turnoNocturno` y `horasExtra`, delegando inicialización compartida en `: base(rut, nombre, sueldoBase)`.
4. Implementar **`public decimal CalcularSueldoTotal()`**, con la regla:
   - `HorasExtra * 8500.00m`.
   - Si `TurnoNocturno == true`, bono fijo adicional `45000.00m`.
   - Devolver el `SueldoBase` más estos bonos.
5. **Sobrescribir** `public override string ObtenerFicha()`. Debe llamar a `base.ObtenerFicha()` y concatenar turno nocturno, horas extra y total líquido calculado.

## Paso 2 — Integración polimórfica en Program.cs (15 minutos)

1. Crear o reutilizar una única lista de la clase base:

```csharp
List<ColaboradorSede> nominaSede = new List<ColaboradorSede>();
```

2. Agregar a esa lista **al menos una instancia de cada clase**:
   - `DocenteSede`;
   - `AdministrativoSede`;
   - `GuardiaSede`.
3. Recorrer con **un único `foreach`** e imprimir `colaborador.ObtenerFicha()` para demostrar que se ejecuta la implementación adecuada según el tipo real del objeto en memoria.

## Observaciones sobre el enunciado

- El texto introductorio solicita «integrarlo en el menú interactivo existente», pero el paso 2 detalla explícitamente un registro/recorrido con una lista y un `foreach`. Los archivos base aportados utilizan un programa **secuencial**, no un menú. Se conserva esa diferencia sin inventar una especificación adicional de opciones.
- El método de sueldo requerido para el guardia se denomina `CalcularSueldoTotal()`, mientras los archivos base adjuntos implementan `CalcularSueldoLiquido()`. Esta inconsistencia es importante al integrar el cálculo agregado.
- El enunciado escribe `public decimal CalcularSueldoTotal()`, sin `override` en ese requisito concreto, pero sí exige expresamente `override` para `ObtenerFicha()`.
- No se adjuntó un `GuardiaSede.cs` resuelto.

## Fuentes vinculadas

- [Semana 9 — Arquitectura, herencia y polimorfismo](../../clases/arquitectura_herencia_y_polimorfismo.md).
- [Análisis documentado de los adjuntos](analisis_archivos_base.md).
- [Resumen de trazabilidad](README.md).
