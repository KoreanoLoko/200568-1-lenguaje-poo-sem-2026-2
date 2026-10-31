# Enunciado — Módulo de Gestión de Ventas: Ganadería Chan

**Origen:** texto de la evaluación de Canvas, proporcionado por el estudiante en la conversación (no se dispuso del enlace de descarga ni del ZIP original del docente).  
**Institución:** IP Virginio Gómez. **Asignatura:** Programación Orientada a Objetos.  
**Modalidad:** individual; entregar exclusivamente un archivo comprimido `.ZIP` en Canvas.  
**Plazo informado:** 22:30 del «día de hoy» en el mensaje original, contextualizado en la conversación el 30-10-2026; sin verificación directa en Canvas.

## Contexto del negocio

«Ganadería Chan» es una empresa de desarrollo, crianza y comercialización de ganado bovino y porcino de la zona sur. Los controles manuales de peso, raza, tipo de producción y valorización de lotes generan retrasos en ferias ganaderas y descuadres patrimoniales. Se solicita un sistema de consola en C# (.NET) con arquitectura modular orientada a objetos, encapsulamiento, herencia, polimorfismo, colecciones dinámicas y parámetros avanzados.

**Instrucción:** completar los sectores `// TODO` del proyecto base `GanaderiaChan`, con cuatro archivos independientes. Se permite utilizar el material de la asignatura.

## A. AnimalGanado.cs — TODO 1–4

- Declarar todas las clases de dominio bajo el **file-scoped namespace** `GanaderiaChan.Core;`.
- `codigoAnimal` y `raza` deben ser campos **protected** (acceso dentro de la jerarquía de herencia); `pesoKilos` debe ser **private**.
- Propiedad completa `PesoKilos` respaldada por `pesoKilos`, cuyo setter establece `100m` cuando el valor ingresado es **menor o igual a 100m**.
- Declarar `virtual decimal CalcularValorComercial()`, valor base `PesoKilos * 2000m`.
- Declarar `virtual string ObtenerFicha()`, mostrando código, raza, peso y valoración comercial.

## B. Bovino.cs — TODO 5–7

- Pertenecer a `GanaderiaChan.Core`, heredar `AnimalGanado` e invocar el constructor `: base(codigo, raza, peso)`.
- Propiedades `TipoProduccion` («CARNE» / «LECHE») y `EsPedigree` (`bool`).
- Sobrescribir `CalcularValorComercial()` con tarifa `2500m` por kg, más bono genético de `150000m` para LECHE o `200000m` para CARNE.
- Si `EsPedigree` es verdadero, recargar **20 % sobre el subtotal ya bonificado**, no solo sobre el peso.
- Sobrescribir `ObtenerFicha()` reutilizando `base.ObtenerFicha()`.

## C. Porcino.cs — TODO 8–10

- Pertenecer al namespace del dominio, heredar `AnimalGanado` e invocar `: base(...)`.
- Propiedades `TipoAlimentacion` («PASTOREO» / «INTENSIVA») y `CantidadLechones` (`int`).
- Sobrescribir `CalcularValorComercial()`: `PesoKilos * 1800m`; recargar **15 %** sobre la tasación si hay PASTOREO; después sumar **80000m** si la camada tiene **más de 5 lechones** (condición estricta `> 5`).
- Sobrescribir `ObtenerFicha()`.

## D. Program.cs — TODO 11–15

- Importar `GanaderiaChan.Core` y usar alias `AnimalChan = GanaderiaChan.Core.AnimalGanado`.
- Implementar `ProcesarPesajeOVenta(AnimalChan animal, ref decimal patrimonioGanaderia, out decimal bonificacionEspecial)`: aumentar patrimonio por `ref` y asignar la bonificación especial en `out`. **El enunciado transcrito no define cómo calcular esa bonificación**, a diferencia de las reglas de valoración de subclases.
- Declarar `List<AnimalChan> hatoGanadero` e inicializar cuatro registros: BOV-101, BOV-102, POR-201, POR-202. **No se proporcionaron valores oficiales para sus demás campos.**
- Recorrer la lista con `foreach` y `animal.ObtenerFicha()` usando despacho polimórfico.
- El menú original ofrece: 1) registrar bovino, 2) registrar porcino, 3) ficha general, 4) valorización/arqueo con `ref` y `out`, 5) salir.

## Evaluación

Total **100 puntos**. Exigencia **51 %** (51 puntos equivalen a nota 4,0). Detalle en [rúbrica](rubrica.md).

## Elementos no recibidos

No se adjuntó el proyecto descargable prometido por «Descargue Proyecto acá», su `.csproj` ni una exportación de Canvas. Las plantillas guardadas proceden exclusivamente de los fragmentos C# copiados por el estudiante, y se preservan sin atribuirles ejecución.
