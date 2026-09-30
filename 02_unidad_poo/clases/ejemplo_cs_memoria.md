# Ejemplo CS — Prueba de memoria: valor vs. referencia

Material oficial transcrito y organizado desde la página **Ejemplo CS** publicada en Canvas.

## Propósito

El ejemplo implementa en código ejecutable la diferencia entre:

- **tipo por valor**, mediante un `struct Punto`;
- **tipo por referencia**, mediante una `class Jugador`.

El código utiliza dos copias/asignaciones y posteriormente modifica el segundo elemento para observar si el primero conserva o comparte el cambio.

## Código oficial

El código completo se conserva en:

`02_unidad_poo/ejemplos/ejemplo_cs_memoria/Program.cs`

## Estructuras utilizadas

### Tipo por valor

```csharp
public struct Punto
{
    public int X { get; set; }
}
```

### Tipo por referencia

```csharp
public class Jugador
{
    public int Puntaje { get; set; }
}
```

## Experimento 1: copia por valor

El ejemplo crea un primer punto:

```csharp
Punto primerPunto = new Punto();
primerPunto.X = 0;
```

Luego crea un segundo punto y copia el primero:

```csharp
Punto segundoPunto = new Punto();
segundoPunto = primerPunto;
```

Después modifica únicamente el segundo:

```csharp
segundoPunto.X = 3;
```

La salida permite comprobar que ambas variables son independientes después de la copia:

```text
X de primerPunto es 0
X de segundoPunto es 3
```

Dentro del modelo enseñado por la asignatura, el `struct` se comporta como **tipo por valor**: la asignación copia los datos.

## Experimento 2: copia de referencia

El ejemplo crea un objeto `Jugador`:

```csharp
Jugador player1 = new Jugador();
player1.Puntaje = 1000;
```

Luego asigna la misma referencia a otra variable:

```csharp
Jugador player2 = player1;
```

y modifica el puntaje mediante `player2`:

```csharp
player2.Puntaje = 500000;
```

Como ambas variables apuntan a la misma instancia, la salida esperada es:

```text
Puntaje Player1 500000
Puntaje Player2 500000
```

Esto ejemplifica el comportamiento presentado en clase para un **tipo por referencia**.

## Flujo conceptual

```text
STRUCT / VALOR

primerPunto
    │
    └── X = 0

segundoPunto = primerPunto
        ↓
se copia el valor

primerPunto.X  = 0
segundoPunto.X = 3
```

```text
CLASS / REFERENCIA

player1 ─┐
         ├──▶ instancia Jugador
player2 ─┘

player2.Puntaje = 500000
        ↓
la misma instancia cambia

player1.Puntaje = 500000
player2.Puntaje = 500000
```

## Relación con materiales anteriores

Este ejemplo práctico refuerza directamente:

- `02_unidad_poo/apuntes/04_tipos_valor_referencia.md`;
- `02_unidad_poo/apuntes/06_experimento_copia_struct_class.md`;
- `02_unidad_poo/clases/anatomia_clases_puntos_entrada_memoria_csharp.md`.

A diferencia del PDF anterior, que utiliza `Punto` y `Jugador` con valores 10 y 99, esta página de Canvas ejecuta la misma idea utilizando:

- `0` y `3` para `Punto.X`;
- `1000` y `500000` para `Jugador.Puntaje`.

## Conceptos consolidados

- `struct`;
- `class`;
- propiedades autoimplementadas;
- creación de instancias con `new`;
- asignación con `=`;
- copia por valor;
- copia de referencia;
- mutación;
- interpolación de cadenas;
- `static void Main(string[] args)`.

## Alcance

Este documento conserva y explica únicamente el comportamiento mostrado por el código oficial de Canvas. No agrega ejemplos externos ni modifica el código para introducir técnicas que aún no forman parte de esta fuente.
