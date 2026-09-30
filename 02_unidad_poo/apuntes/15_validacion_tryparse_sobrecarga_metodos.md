# 15 — Validación de entrada, TryParse y sobrecarga de métodos

Apunte derivado exclusivamente del material oficial **SistemaBancario.zip** y de sus archivos `CuentaBancaria.cs` y `Program.cs`.

> **Fuente documental:** `../ejemplos/sistema_bancario/README.md`

## Validación de texto

El código utiliza:

```csharp
textoLeido = Console.ReadLine() ?? "";
```

El operador:

```text
??
```

permite utilizar una cadena vacía cuando `Console.ReadLine()` no entrega un valor.

Después se valida mediante:

```csharp
string.IsNullOrWhiteSpace(textoLeido)
```

## TryParse

Para entradas monetarias:

```csharp
decimal.TryParse(entrada, out numeroLeido)
```

Para opciones enteras:

```csharp
int.TryParse(entrada, out numeroLeido)
```

El resultado de `TryParse` se almacena en un `bool` y el valor convertido se entrega mediante el parámetro `out`.

## Parse vs. TryParse dentro del propio material

El archivo conserva comentado:

```csharp
decimal.Parse(entrada)
```

con una observación que distingue:

- `Parse`: convierte y puede lanzar una excepción si la entrada no es válida;
- `TryParse`: permite comprobar si la conversión fue válida.

## Validación de rango

El método entero utiliza:

```csharp
if (!esNumeroValido || numeroLeido < opMinima || numeroLeido > opcionMax)
```

Aquí aparece el operador lógico:

```text
||
```

para combinar condiciones alternativas de error.

## Sobrecarga de métodos

El material define dos métodos llamados `leerNumero`:

```csharp
public static decimal leerNumero(string mensaje)
```

y:

```csharp
public static int leerNumero(string mensaje, int opMinima, int opcionMax)
```

Comparten nombre, pero poseen listas de parámetros diferentes.

Dentro de este ejemplo, esto constituye una demostración de **sobrecarga**.

## Métodos auxiliares static

`Program` separa tareas mediante:

- `mostrarMenu()`;
- `leerTexto(...)`;
- `leerNumero(...)`.

Todos están definidos como `static` y son invocados desde `Main`.

## Control del ciclo

El menú utiliza:

```csharp
do
{
    ...
} while (true);
```

La salida explícita ocurre en la opción 5:

```csharp
Environment.Exit(0);
```

## null

El código inicializa:

```csharp
CuentaBancaria cuentaBancaria = null;
```

y posteriormente comprueba:

```csharp
if (cuentaBancaria != null)
```

antes de utilizar la instancia en varias opciones del menú.

## Alcance

Este apunte documenta únicamente las técnicas que aparecen en los archivos proporcionados y no amplía su comportamiento con características externas de C#.
