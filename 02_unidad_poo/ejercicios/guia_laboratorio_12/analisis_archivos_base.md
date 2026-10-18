# Guía 12 — Análisis de los archivos base adjuntos (solo documentación)

> Se analizaron cinco archivos entregados junto a la solicitud: `AdministrativoSede.cs`, `ColaboradorSede(1).cs`, `DocenteSede(1).cs`, `Program(5).cs` y `SistemaGestionPersonal.csproj`. **No se incorporan sus originales ni copias íntegramente reproducidas al repositorio**; únicamente esta descripción y fragmentos breves.

## 1. Identidad del proyecto y estructura del ejemplo

El `.csproj` declara:

| Configuración | Valor real |
| --- | --- |
| SDK | `Microsoft.NET.Sdk` |
| OutputType | `Exe` |
| TargetFramework | `net10.0` |
| ImplicitUsings | `enable` |
| Nullable | `enable` |

Los cuatro archivos C# usan `namespace SistemaGestionPersonal;` (file-scoped). Esto **difiere** de los namespaces `IPVG.Sede.Core` y `IPVG.Sede.App` de la Guía 11, porque es otro proyecto/material base.

## 2. ColaboradorSede(1).cs — base polimórfica

- `public class ColaboradorSede`.
- Campo privado `decimal sueldoBase` con propiedad completa `SueldoBase`.
- El setter usa operador ternario: valores inferiores a `500000.00m` se ajustan a `500000.00m`.
- `protected string Rut { get; set; }`.
- `public string Nombre { get; set; }` (**escritura pública** en este material).
- Constructor normaliza RUT y Nombre con `ToUpper()`.
- Dos métodos virtuales: `CalcularSueldoLiquido()` devuelve `SueldoBase` y `ObtenerFicha()` produce RUT, nombre y base con formato `N2`.

**Cambio frente a Guía 11:** allí el nombre usaba `private set` y el sueldo virtual se denominaba `CalcularSueldoTotal()`. Es una variante real del material, no se sustituyen sus nombres en el respaldo.

## 3. DocenteSede(1).cs — primera clase derivada

- `internal class DocenteSede : ColaboradorSede`.
- `HorasOtec { get; set; }`.
- Constructor `: base(rut, nombre, sueldoBase)`; horas negativas o cero se convierten a 0 mediante ternario.
- Sobrescribe `CalcularSueldoLiquido()`; agrega bono `HorasOtec * 12500.00m` al resultado de `base.CalcularSueldoLiquido()`.
- Sobrescribe `ObtenerFicha()` concatenando ficha base, horas OTEC y líquido.

## 4. AdministrativoSede.cs — segunda clase derivada

- `internal class AdministrativoSede : ColaboradorSede`.
- `Departamento { get; set; }`; el constructor reemplaza departamento vacío por `"GENERAL"` y, en caso contrario, usa `Trim()`.
- `AniosServicio { get; set; }`; el constructor transforma negativos en 0.
- `BonoGestion { get; private set; }` = años de servicio × `25000.00m`.
- `CalcularSueldoLiquido()` devuelve `SueldoBase + BonoGestion`.
- `ObtenerFicha()` reutiliza `base.ObtenerFicha()` y anexa departamento, años, bono y total.

**Observación técnica:** `AniosServicio` tiene setter público, pero `BonoGestion` se calcula solamente en el constructor: alterar los años después no recalcula ese bono. Es una limitación observable del código, no una regla que deba añadirse al ejercicio.

## 5. Program(5).cs — demostración secuencial de polimorfismo

La aplicación contiene:

```csharp
List<ColaboradorSede> nomina = new List<ColaboradorSede>();
```

Luego agrega exactamente **dos instancias iniciales**:
- `DocenteSede("15.123.456-7", "Alan Brito", 650000.00m, 12)`.
- `AdministrativoSede("18.987.654-3", "Ana María Perez", "Contabilidad", 580000.00m, 7)`.

El único `foreach` imprime `colab.ObtenerFicha()` y suma `colab.CalcularSueldoLiquido()` a un acumulador `decimal`. Esto sí demuestra **polimorfismo para dos tipos**, pero no cumple por sí solo la exigencia posterior de un guardia ni implementa un menú interactivo.

### Resultados calculados a partir del código (no evidencia de ejecución)

| Registro | Cálculo | Total esperado |
| --- | --- | ---: |
| Docente | $650.000 + 12 × $12.500 | $800.000 |
| Administrativo | $580.000 + 7 × $25.000 | $755.000 |
| Nómina de los dos registros adjuntos | $800.000 + $755.000 | **$1.555.000** |

`:N2` formatea con dos decimales usando la cultura de ejecución. El nombre `CalcularSueldoLiquido` es el usado por el código; **no hay descuentos previsionales o tributarios documentados**, por lo que «líquido» debe entenderse como la etiqueta del método en este ejemplo.

## 6. Qué falta para la Guía 12

| Requerimiento de Canvas | ¿Presente en los adjuntos? |
| --- | --- |
| Clase `ColaboradorSede` con `virtual ObtenerFicha()` | Sí |
| Clase `DocenteSede` con override | Sí |
| Clase `AdministrativoSede` con override | Sí |
| `GuardiaSede` con `TurnoNocturno`, `HorasExtra` y constructor base | **No** |
| Bono de guardia de $8.500 por hora y nocturno $45.000 | **No** |
| `GuardiaSede.ObtenerFicha() override` | **No** |
| Lista base que contenga los tres tipos | **No**; contiene dos |
| Un `foreach` que invoque la ficha especializada | Sí, para dos tipos |
| Menú interactivo indicado en introducción | **No**; programa secuencial |

## 7. Discrepancia de nombres para calcular remuneraciones

**Fuente Canvas:** `public decimal CalcularSueldoTotal()` para `GuardiaSede`.  
**Fuente archivos base:** método común virtual `CalcularSueldoLiquido()`.

Si posteriormente se agrega solo un método distinto llamado `CalcularSueldoTotal()`, el `foreach` existente que suma `CalcularSueldoLiquido()` **no ejecutará automáticamente esa otra función**. La nómina podría acumular únicamente el sueldo base del guardia si no se armoniza el comportamiento de acuerdo con las instrucciones del docente.

**No se corrige aquí:** el propósito del respaldo es distinguir con precisión lo solicitado por Canvas de lo contenido en el código adjunto.

## 8. Trazabilidad

- Los adjuntos originales se mantienen fuera del repositorio, conforme a la solicitud del estudiante.
- No se crea ni se sube `GuardiaSede.cs`.
- No se publica ni modifica `SistemaGestionPersonal.csproj`.
- La compilación del conjunto ampliado no se ha verificado porque no se adjuntó una implementación de la nueva clase guardia.
- [Guía 11](../guia_laboratorio_11/README.md) conserva otra solución anterior, sin reemplazos.
