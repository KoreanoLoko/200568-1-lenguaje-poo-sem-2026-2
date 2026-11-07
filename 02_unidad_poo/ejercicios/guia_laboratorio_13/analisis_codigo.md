# Análisis del código docente — Guía de Laboratorio 13

**Origen:** los seis fragmentos de Canvas facilitados por el estudiante; se normalizaron escapes de Markdown y formato, sin diseñar una solución nueva. **No se ha compilado ni ejecutado**; los cálculos son controles estáticos.

## Contratos y cumplimiento

| Tipo | Clase base explícita | IValorable | IExportable | Tasación |
| --- | --- | --- | --- | --- |
| `AnimalGanado` | Implícitamente `object` | Directo | No | Peso×2000 |
| `Bovino` | `AnimalGanado` | Heredado y especializado | Directo | (Peso×2000)×1,25 + bono condicional |
| `MaquinariaAgricola` | Implícitamente `object` | Directo | Directo | ValorCompra − (antigüedad×8% de ValorCompra), piso 1 millón |

**No hay clase `abstract` declarada** en el proyecto provisto, aunque la explicación oral y el PDF comparen clases abstractas con interfaces.

## Análisis por archivo

1. **IValorable.cs:** `CodigoActivo { get; }`, `CalcularTasacionComercial()`, `ObtenerFichaAuditoria()`.
2. **IExportable.cs:** `PaisDestino { get; set; }`, `CumpleNormaFitosanitaria { get; }`, `GenerarCertificadoExportacion()`.
3. **AnimalGanado.cs:** dos campos `protected`, valor mínimo de peso 100 kg, tasación virtual base y ficha virtual. La propiedad `CodigoActivo` es de solo lectura y se implementa con expresión.
4. **Bovino.cs:** hereda del ganado y añade `IExportable`; el incremento de 25 % se aplica a la tasación base y después suma 100.000 si la norma es verdadera. Los certificados devuelven «APROBADO» o «RECHAZADO».
5. **MaquinariaAgricola.cs:** implementa ambos contratos directamente; norma según año `>= 2020` y depreciación lineal calculada con `DateTime.Now.Year`. El mínimo es `1000000m`. El certificado describe inspección «NORMA ISO CUMPLIDA» o «REQUIERE REVISIÓN TÉCNICA», como texto de demostración.
6. **Program.cs:** lista `List<IValorable>` con cuatro objetos; primer `foreach` suma tasación; segundo `foreach` usa `is IExportable exportable` para emitir los cuatro certificados. No hay menú ni `try-catch` en el fragmento proporcionado.

## Reproducción aritmética de los datos precargados (año 2026)

| Código | Datos del ejemplo | Operación esperada | Resultado |
| --- | --- | --- | ---: |
| BOV-901 | 480 kg, norma cumplida | (480×2000)×1,25 + 100000 | $1.300.000 |
| BOV-902 | 510 kg, norma no cumplida | (510×2000)×1,25 | $1.275.000 |
| MAQ-301 | $45.000.000, año 2022 | 45.000.000 − (4×8 %×45.000.000) | $30.600.000 |
| MAQ-302 | $65.000.000, año 2018 | 65.000.000 − (8×8 %×65.000.000) | $23.400.000 |
| **Total** | **4 activos** | **Suma** | **$56.575.000** |

Estos resultados se derivan solo de las fórmulas de Canvas y del año **2026**. No son salida capturada del programa. En años posteriores, los valores de maquinaria disminuyen hasta su piso mínimo. El PDF muestra otra cifra ilustrativa de **$45.500.000** para sus propios objetos; **no debe confundirse** con esta tabla.

## Comprobaciones recomendadas

- [ ] Crear el proyecto de consola .NET con las seis fuentes; **no se recibió `.csproj`**.
- [ ] Ejecutar `dotnet build` y `dotnet run` (no ejecutados en esta documentación).
- [ ] Verificar que ambos bovinos puedan tratarse como `IValorable` aunque implementen `IExportable` de forma directa.
- [ ] Verificar que ambas maquinarias sean `IValorable` e `IExportable`, pese a no heredar de `AnimalGanado`.
- [ ] Verificar los cuatro certificados y el valor del acumulador de acuerdo con el año actual de ejecución.
- [ ] Si se decide trabajar el **taller de la diapositiva 11**, hacerlo como ejercicio separado: tres clases diferentes, mínimo cinco objetos y menú; no añadirlo como si ya perteneciera al código de Canvas.
- [ ] Revisar el manejo de errores del PDF como ampliación didáctica no presente en este proyecto.

## Riesgos interpretativos y límites

- El término «fotosanitario» en el ejemplo se toma como etiqueta del contrato; no constituye verificación regulatoria real.
- La maquinaria acepta valores de año futuro o compra negativa en la fuente proporcionada; no se introduce validación inventada.
- No se ha verificado la compilación, porque el proyecto completo descargable no fue adjuntado; tampoco se ha realizado control de regresión.
- Canvas indica sin fecha de entrega y 0 puntos, por lo que no se atribuye entrega evaluada.
