# 25 — List<T>, foreach, Add, Find y expresiones lambda

Apunte derivado exclusivamente de la **Guía de Laboratorio 10**.

> **Fuente:** `../ejercicios/guia_laboratorio_10/enunciado.md`

## Colecciones genéricas

La guía introduce:

```csharp
List<T>
```

desde:

```csharp
System.Collections.Generic
```

El tipo `T` fija qué clase de objetos puede almacenar la colección.

Ejemplo oficial:

```csharp
List<CasilleroSede> listaLockers
```

Por lo tanto, la lista se utiliza para almacenar objetos del tipo `CasilleroSede`.

## Comparación con ArrayList

La fuente contrasta:

```csharp
ArrayList
```

con:

```csharp
List<T>
```

destacando que `List<T>` ofrece seguridad de tipos en compilación y no requiere casting al recuperar elementos del tipo esperado.

## Inicialización de una List<T>

```csharp
List<CasilleroSede> listaLockers =
    new List<CasilleroSede>()
{
    new CasilleroSede(101, 3500.00m),
    new CasilleroSede(102, 3500.00m)
};
```

## Recorrido con foreach

```csharp
foreach (CasilleroSede locker in listaLockers)
{
    // usar locker
}
```

En el código oficial las llaves se omiten porque el cuerpo contiene una sola instrucción.

## Count

```csharp
listaLockers.Count
```

permite consultar la cantidad de elementos registrados.

## Add

```csharp
listaLockers.Add(
    new CasilleroSede(num, 3500.00m));
```

agrega dinámicamente un nuevo elemento.

## Find

```csharp
CasilleroSede enc =
    listaLockers.Find(l => l.NumeroLocker == b);
```

La búsqueda devuelve el objeto que cumple el predicado utilizado por la guía.

## Expresión lambda

La expresión:

```csharp
l => l.NumeroLocker == b
```

puede leerse dentro de este ejemplo como:

```text
para cada elemento l
→ comprobar si
l.NumeroLocker == b
```

La guía la utiliza como condición entregada a `Find()`.

## Verificación de null

Después de buscar:

```csharp
enc != null
```

verifica que la referencia encontrada no sea nula antes de utilizarla.

## out declarado dentro de la llamada

La guía incorpora:

```csharp
out decimal c
```

directamente en:

```csharp
enc.Arrendar(
    "19.876.543-2",
    out decimal c)
```

Esto evita declarar previamente:

```csharp
decimal c;
```

## Método con cuerpo de expresión

`Locker` contiene:

```csharp
public static decimal ObtenerRecaudoGlobal()
    => recaudoTotalSede;
```

La fuente demuestra así una forma compacta de devolver una expresión.

## Formatos

### D3

```csharp
{NumeroLocker:D3}
```

se utiliza para representar el número del locker con tres posiciones.

### N2

```csharp
{TarifaMensual:N2}
```

se utiliza para representar un número con dos decimales.

## Integración POO + colecciones

La colección no elimina la encapsulación de los objetos:

```csharp
public string EstudianteRut
{
    get;
    private set;
}
```

Aunque un `Locker` esté almacenado en una `List<Locker>`, el código externo continúa sin poder modificar directamente una propiedad cuyo setter es privado.

## static frente a instancia dentro de una lista

Si existen muchos objetos `Locker`:

```text
NumeroLocker
→ existe como estado de cada instancia

recaudoTotalSede
→ existe una sola vez a nivel de clase
```

La lista administra referencias a muchos objetos, pero el miembro `static` sigue siendo compartido.

## Diferencias internas registradas

La descripción de la guía menciona sobrecarga de constructores con `: this(...)`, pero el código mostrado contiene un único constructor.

La introducción menciona `ref / out`, pero el caso práctico implementado solo utiliza `out`.

Estas diferencias pertenecen al material original y se conservan sin completar código por inferencia.

## Alcance

Este apunte resume únicamente las técnicas demostradas o comparadas en la Guía de Laboratorio 10.
