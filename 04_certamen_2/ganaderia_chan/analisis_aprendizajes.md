# Análisis del Certamen 2: Ganadería Chan — aprendizajes y seguimiento

**Naturaleza:** apunte derivado del enunciado y del diálogo de resolución, subordinado al material docente. No equivale a un acta de evaluación ni a una ejecución verificada.

## Arquitectura y dependencias

```text
GanaderiaChan.Core
 ├─ AnimalGanado       ← clase base: campos protegidos, peso validado, virtual
 ├─ Bovino : AnimalGanado  ← base(...), override
 └─ Porcino : AnimalGanado ← base(...), override

GanaderiaChan.App
 └─ Program → List<AnimalChan> → foreach → llamadas virtuales
                           └── ProcesarPesajeOVenta(..., ref ..., out ...)
```

El orden de implementación trabajado fue AnimalGanado (TODO 1–4), Bovino (5–7), Porcino (8–10), Program (11–15). El recorrido usa el tipo base y en ejecución llama la implementación del objeto concreto.

## Mapa técnico de los TODO

| TODO | Contenido solicitado | Apunte de estudio |
| ---: | --- | --- |
| 1 | `namespace GanaderiaChan.Core;` | file-scoped namespace, termina con punto y coma |
| 2 | Encapsular el peso | campo `private decimal pesoKilos`, setter `value <= 100m` ajusta a `100m`; `codigoAnimal` y `raza` deben ser `protected` |
| 3 | `virtual CalcularValorComercial()` | `PesoKilos * 2000m` |
| 4 | `virtual ObtenerFicha()` | construir descripción de código, raza, peso, valor |
| 5 | Bovino en Core y herencia | `class Bovino : AnimalGanado` |
| 6 | Constructor Bovino | `: base(codigo, raza, peso)` |
| 7 | `override` valor bovino | 2500m/kg + bono por producción, luego ×1.20m si Pedigree |
| 8 | Porcino en Core y herencia | `class Porcino : AnimalGanado` |
| 9 | Constructor Porcino | `: base(codigo, raza, peso)` |
| 10 | `override` valor porcino | 1800m/kg, luego ×1.15m si Pastoreo, luego +80000m si lechones >5 |
| 11 | `using` y alias de tipo | `using AnimalChan = GanaderiaChan.Core.AnimalGanado;` |
| 12 | Método transaccional | `ref` modifica patrimonio de `Main`; `out` debe asignarse en todo flujo |
| 13 | `List<AnimalChan>` precargada | 2 bovinos y 2 porcinos, códigos obligatorios |
| 14 | Registro y menú | opciones 1 y 2 estaban vacías en la plantilla; se propuso completar altas con `Add` |
| 15 | `foreach` polimórfico y arqueo | invocar `animal.ObtenerFicha()` y `ProcesarPesajeOVenta(...)` en la lista |

**Nota:** los rótulos 14 y 15 en la tabla describen las tareas que el asistente atribuyó a esas secciones durante la resolución; el archivo Program.cs original **solo contiene comentarios TODO 11–13**, mientras que el enunciado y la rúbrica hablan globalmente de TODO 11–15. No deben confundirse los rótulos explicativos con comentarios presentes en el archivo docente.

## Reglas aritméticas

- **Base:** peso validado × `2000m`.
- **Bovino:** subtotal = peso × `2500m` + (150000m LECHE / 200000m CARNE); si Pedigree, resultado = subtotal × `1.20m`.
- **Porcino:** valor = peso × `1800m`; si Pastoreo, × `1.15m`; si `CantidadLechones > 5`, + `80000m`.
- **Límites críticos:** peso **≤100** se fija a 100, pero 100.01 permanece; cinco lechones no generan bono y seis sí; porcentajes se aplican en el orden descrito.
- **Tipo monetario:** `decimal` y literales `m` para evitar mezclar `double` en los cálculos.

## Estado concreto de los archivos mostrados

1. **AnimalGanado.cs del estudiante:** namespace correcto, propiedad completa con `value <= 100m`, método `CalcularValorComercial()` virtual correcto y cadena de ficha. **Quedaron `public string codigoAnimal` y `public string raza` (deben ser `protected`) y `public string ObtenerFicha()` (debe ser `public virtual string ObtenerFicha()`).** Las subclases con `override ObtenerFicha()` requieren la segunda corrección para compilar.
2. **Bovino.cs del estudiante:** namespace, herencia, constructor `: base(...)`, cálculo por tipo, `EsPedigree` y `override` de ambas operaciones presentes. Coincide estáticamente con el cálculo solicitado.
3. **Porcino.cs del estudiante:** namespace, herencia, constructor `: base(...)`, 15 % pastoreo, bono cuando `CantidadLechones > 5` y `override` presentes. Coincide estáticamente con el cálculo solicitado.
4. **Program.cs:** **solo se recibió la plantilla incompleta**; el archivo de `propuesta_asistente/` es un ejemplo sugerido, no código final confirmado del estudiante.

## Diferencias entre los originales y las propuestas

- `using AnimalChan;` aparece en la plantilla del docente, pero **no es la declaración del alias requerido**; debe reemplazarse por el `using` de alias.
- La plantilla presenta dos opciones vacías para agregar animales; el asistente propuso preguntas de `Console.ReadLine()` y `Add()`, con `decimal.Parse` / `int.Parse`. **No tienen control de entradas no numéricas**; un valor inválido lanzará una excepción.
- **Fórmula de `bonificacionEspecial` no suministrada:** la propuesta de Program calcula `Math` conceptual `max(0, valorFinal - peso * 2000m)` mediante `if`. Esto es una **hipótesis del asistente**, no la regla del docente. Debe revisarse si aparece una aclaración oficial.
- **Semántica de patrimonio acumulado:** la plantilla conserva patrimonio entre iteraciones de opción 4; la propuesta reinicia patrimonio al comenzar cada arqueo para no contabilizar el mismo hato repetidamente. Es una decisión de implementación no prescrita explícitamente; contrastar con el propósito de «patrimonio acumulado».
- Los datos de cuatro animales precargados de la propuesta (razas y pesos) son **ejemplos**, porque el docente solo fijó sus códigos.
- `base.ObtenerFicha()` usa despacho virtual cuando dentro llama `CalcularValorComercial()`; el texto base ya muestra valor comercial y la subclase lo vuelve a mostrar. La duplicación visual proviene del formato sugerido, no cambia la tasación.

## Verificaciones pendientes

- [ ] Confirmar que el `AnimalGanado.cs` **real** fue corregido a `protected` y `virtual`.
- [ ] Obtener `Program.cs` finalmente usado y comparar con el ejemplo propuesto.
- [ ] Confirmar con el docente la definición de bonificación especial y acumulación patrimonial.
- [ ] Obtener el ZIP/proyecto original de Canvas (incluido `.csproj`) si se requiere preservar los adjuntos oficiales.
- [ ] Ejecutar compilación (`dotnet build`) y flujo (`dotnet run`) local; no hay registro verificable de estas pruebas.
- [ ] Comprobar menú 1–5, peso 100, peso menor que 100, Pedigree, CARNE/LECHE, Pastoreo, lechones 5/6 y repetición del arqueo.
- [ ] Confirmar entrega de ZIP por Canvas separadamente de esta copia de estudio.

## Conexiones con materia previa (solo repositorio del curso)

- [Namespaces y alias](../../02_unidad_poo/apuntes/24_namespaces_using_alias_tipos.md).
- [List, foreach y Add](../../02_unidad_poo/apuntes/25_list_foreach_add_find_lambda.md).
- [Encapsulamiento y herencia](../../02_unidad_poo/clases/encapsulamiento_y_herencia_en_csharp.md).
- [Polimorfismo y override](../../02_unidad_poo/apuntes/30_polimorfismo_despacho_dinamico_sobrecarga_override.md).
- [Parámetros ref/out](../../02_unidad_poo/apuntes/18_parametros_valor_ref_out.md).
- [Repaso Cine IPVG](../repaso_cine_sede_ipvg/README.md).
