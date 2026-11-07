# 31 — Interfaces, contratos e implementación múltiple en C#

> **Fuentes:** PDF docente «Interfaces_y_Polimorfismo_en_C.pdf» (páginas 2–12), Guía de Laboratorio 13 de Canvas y fragmentos de clase proporcionados por el estudiante. Apunte derivado; verificar diferencias de nombres y ejemplos en las fuentes principales.

## 1. Problema arquitectónico: relaciones artificiales

Las clases de una jerarquía expresan identidad compartida. No resulta apropiado obligar a un tractor y a un lote agrícola a heredar de una misma clase del negocio únicamente porque ambos pueden valorizarse. La **interfaz** permite declarar la capacidad común, independientemente de la genealogía de los objetos.

- **Herencia de clase:** relación «es un», por ejemplo `Bovino : AnimalGanado`.
- **Implementación de interfaz:** relación «puede realizar», por ejemplo `MaquinariaAgricola : IValorable`.

## 2. Qué es un contrato

En el código de Canvas, `IValorable` exige:

```csharp
public interface IValorable
{
    string CodigoActivo { get; }
    decimal CalcularTasacionComercial();
    string ObtenerFichaAuditoria();
}
```

No crea por sí mismo un objeto que pueda tasarse: declara los miembros que una clase debe proporcionar para ser utilizada como `IValorable`.

La segunda interfaz, `IExportable`, exige `PaisDestino { get; set; }`, `CumpleNormaFitosanitaria { get; }` y `GenerarCertificadoExportacion()`.

**Matiz necesario:** la explicación oral dice «la interfaz solamente tiene métodos», pero ambos contratos de Canvas incluyen **propiedades**. El PDF, página 4, reconoce además implementaciones por defecto en .NET moderno. Se mantiene la intención didáctica, sin tomar la frase oral como una prohibición literal de propiedades.

## 3. Clase abstracta frente a interfaz

| Aspecto | Abstract class | Interface |
| --- | --- | --- |
| Función | Modelo compartido de la jerarquía | Contrato de capacidad |
| Campos y constructores | Pueden estar presentes | No declara campos de instancia ni constructores de instancia como una clase |
| Instanciación directa | No se puede usar `new` sobre la clase abstracta | No se puede usar `new` para instanciar la interfaz |
| Relación de tipos | Una sola clase base directa | Varias interfaces |
| Métodos | Puede combinar implementación común y miembros abstractos | En esta guía principalmente firmas de contrato; el PDF menciona implementaciones predeterminadas modernas |

**Atención:** `AnimalGanado` de la Guía 13 es una **clase concreta** (`public class AnimalGanado`), no `abstract class`. La comparación teórica no altera el código docente.

## 4. Dos formas de cumplir contratos

```csharp
public class AnimalGanado : IValorable { /* ... */ }

public class Bovino : AnimalGanado, IExportable { /* ... */ }

public class MaquinariaAgricola : IValorable, IExportable { /* ... */ }
```

- Un `Bovino` **es un** `AnimalGanado`, por lo que hereda la implementación de `IValorable` y la especializa con `override`. Además, implementa `IExportable`.
- Una `MaquinariaAgricola` no es un animal. Implementa directamente los contratos `IValorable` e `IExportable`.
- La propiedad de solo lectura requerida por una interfaz (`{ get; }`) puede cumplirse en el ejemplo con una propiedad pública que también tenga `set`; el consumidor de la interfaz solo cuenta con el `get` declarado.

## 5. Polimorfismo transversal

```csharp
List<IValorable> inventariosFundo = new List<IValorable>();
```

Con esta lista se agregan tanto bovinos como maquinaria. El recorrido:

```csharp
foreach (IValorable item in inventariosFundo)
{
    patrimonioTotal += item.CalcularTasacionComercial();
}
```

ejecuta la tasación concreta según la implementación real. Es un paso adicional respecto de `List<AnimalGanado>` del Certamen 2, que solo reúne clases de la misma familia.

## 6. Pattern matching para una segunda capacidad

```csharp
if (item is IExportable exportable)
{
    Console.WriteLine(exportable.GenerarCertificadoExportacion());
}
```

El patrón `is IExportable exportable` comprueba si el objeto también cumple el contrato exportador y, de ser así, facilita una referencia tipada. **No es un cast inseguro ni una comprobación exclusiva del nombre de la clase.**

## 7. Tasación aplicada en el proyecto Canvas

- `AnimalGanado`: tasación inicial `pesoKilos * 2000m`, peso mínimo 100 kg.
- `Bovino`: `base.CalcularTasacionComercial() * 1.25m` + bono `100000m` cuando cumple la norma.
- `MaquinariaAgricola`: valor de compra menos 8 % por año de antigüedad, con mínimo de 1.000.000; se utiliza `DateTime.Now.Year`, por lo que varía en otros años.
- La regla `AnioFabricacion >= 2020` se utiliza solo como condición del ejercicio para emitir texto de cumplimiento. No se debe presentar como certificación efectiva ni regulación externa validada.

## 8. Gestión de excepciones (PDF, página 12)

El material añade un ejemplo de `try-catch` que lanza `InvalidOperationException` cuando la tasación es negativa. Este fragmento **no está integrado en el Program.cs proporcionado por Canvas**; su enseñanza pertenece a la diapositiva, no a una modificación efectuada del proyecto.

## 9. Diferencias que no debemos mezclar

- **Presentación:** `Tractor`, `LoteManzana`, `InsumoQuimico`, `List<IValorable>` con al menos cinco instancias, menú `do-while`/`switch`.
- **Guía 13:** `Bovino`, `MaquinariaAgricola`, cuatro objetos precargados, informe secuencial de patrimonio y exportación.
- **Transcripción:** explicación de herencia múltiple por interfaces y clases abstractas; fragmentos salteados, sin constancia de una demostración completa.

## Para repasar

1. ¿Por qué no conviene crear una superclase arbitraria solo para auditar activos disímiles?
2. ¿Qué diferencia hay entre `Bovino : AnimalGanado, IExportable` y `MaquinariaAgricola : IValorable, IExportable`?
3. ¿Qué aporta `List<IValorable>` respecto de una lista de una clase base?
4. ¿Cuándo puede utilizarse `item is IExportable exportable`?
5. ¿Por qué la tasación de maquinaria depende del año de ejecución?

## Vinculaciones

- [Presentación de interfaces](../clases/interfaces_y_polimorfismo_transversal.md).
- [Guía 13](../ejercicios/guia_laboratorio_13/README.md).
- [Apunte 30 — virtual/override](30_polimorfismo_despacho_dinamico_sobrecarga_override.md).
