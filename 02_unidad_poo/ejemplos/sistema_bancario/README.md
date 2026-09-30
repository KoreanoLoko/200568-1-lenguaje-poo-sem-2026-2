# SistemaBancario — material oficial

Material derivado del archivo **SistemaBancario.zip** publicado en Canvas.

> **Fuente original prevista en el repositorio:** `02_unidad_poo/ejemplos/sistema_bancario/SistemaBancario.zip`

## Archivos analizados

El material recibido contiene, al menos, los siguientes archivos fuente:

- `CuentaBancaria.cs`
- `Program.cs`

El archivo ZIP completo no fue proporcionado en esta conversación, por lo que esta documentación se limita a los archivos fuente disponibles.

## Relación con la Guía de Laboratorio 05

Este material implementa el mismo dominio trabajado en la **Guía de Laboratorio 05**:

- clase `CuentaBancaria`;
- miembros estáticos;
- propiedades de instancia;
- constructor;
- depósito;
- retiro;
- consulta de cantidad de cuentas;
- menú interactivo.

Además, `Program.cs` completa el desafío autónomo mediante un menú con validaciones de entrada.

## CuentaBancaria.cs

### Miembros estáticos

```csharp
private static int contadorCuentas = 0;
private static decimal tasaMantenimientoGlobal = 500.00m;
```

`contadorCuentas` se utiliza para generar correlativos y consultar cuántas cuentas fueron creadas.

`tasaMantenimientoGlobal` está declarada en el archivo, pero no es utilizada por el código analizado.

### Propiedades

```csharp
public string NumeroCuenta { get; }
public string Titular { get; set; }
public decimal Saldo { get; private set; }
```

### Constructor

```csharp
public CuentaBancaria(string titular, decimal saldoInicial)
```

El constructor:

1. incrementa `contadorCuentas`;
2. genera `NumeroCuenta`;
3. asigna `Titular`;
4. asigna `Saldo`.

El archivo utiliza explícitamente `this`:

```csharp
this.NumeroCuenta = "CTA-" + 202600 + contadorCuentas;
this.Titular = titular;
this.Saldo = saldoInicial;
```

### Documentación XML

Los métodos `Depositar` y `Retirar` incorporan comentarios XML:

```csharp
/// <summary>
/// ...
/// </summary>
```

### Depositar

```csharp
public void Depositar(decimal monto)
```

Valida que el monto sea positivo y modifica el saldo de la instancia.

### Retirar

```csharp
public bool Retirar(decimal monto)
```

Valida simultáneamente:

- monto mayor que cero;
- monto menor o igual al saldo.

Retorna `true` en retiro exitoso y `false` en caso contrario.

## Program.cs

El programa crea inicialmente una referencia:

```csharp
CuentaBancaria cuentaBancaria = null;
```

Luego solicita:

- nombre del cliente;
- saldo inicial;

y crea la cuenta:

```csharp
cuentaBancaria = new CuentaBancaria(cliente, saldoInicial);
```

## Menú interactivo

El ciclo principal utiliza:

```csharp
do
{
    ...
} while (true);
```

y un `switch` con cinco opciones:

1. Depositar.
2. Retirar.
3. Consultar saldo.
4. Consultar cantidad de cuentas.
5. Salir.

La opción de salida utiliza:

```csharp
Environment.Exit(0);
```

## Métodos auxiliares estáticos

`Program` separa responsabilidades mediante métodos auxiliares:

```csharp
mostrarMenu()
leerTexto(...)
leerNumero(...)
```

### leerTexto

La entrada textual se valida con:

```csharp
Console.ReadLine() ?? ""
```

y:

```csharp
string.IsNullOrWhiteSpace(textoLeido)
```

Esto incorpora el operador de coalescencia nula `??` y una validación para impedir texto vacío o compuesto solo por espacios.

### leerNumero para decimal

```csharp
public static decimal leerNumero(string mensaje)
```

utiliza:

```csharp
decimal.TryParse(entrada, out numeroLeido)
```

para validar conversión sin utilizar directamente una excepción.

El propio código conserva comentada la alternativa:

```csharp
decimal.Parse(entrada)
```

y explica que esa alternativa solo convierte y puede lanzar una excepción si la entrada no es válida.

### leerNumero para opciones enteras

Existe una segunda firma:

```csharp
public static int leerNumero(string mensaje, int opMinima, int opcionMax)
```

Este método utiliza:

```csharp
int.TryParse(entrada, out numeroLeido)
```

y además valida el rango:

```csharp
numeroLeido < opMinima || numeroLeido > opcionMax
```

## Sobrecarga observada

El material contiene dos métodos con el mismo nombre:

```text
leerNumero(string mensaje)
leerNumero(string mensaje, int opMinima, int opcionMax)
```

pero con distinta firma y distinto tipo de retorno.

Esto constituye un ejemplo concreto de **sobrecarga de métodos** dentro del código proporcionado.

## Conceptos consolidados o incorporados

- `null`;
- comparación `!= null`;
- operador `??`;
- `string.IsNullOrWhiteSpace`;
- `TryParse`;
- parámetro `out`;
- `decimal.TryParse`;
- `int.TryParse`;
- validación de rango;
- `||`;
- métodos auxiliares;
- métodos `static`;
- sobrecarga de métodos;
- `while (true)`;
- `break`;
- `Environment.Exit(0)`;
- documentación XML;
- uso explícito de `this`.

## Relación con otras fuentes

Este material complementa directamente:

- `02_unidad_poo/ejercicios/guia_laboratorio_05/enunciado.md`;
- `02_unidad_poo/ejercicios/guia_laboratorio_05/ejemplo_oficial/CuentaBancaria.cs`;
- `02_unidad_poo/apuntes/14_sistema_bancario_static_constructor_metodos.md`;
- `02_unidad_poo/ejercicios/banco_app/enunciado.md`.

## Alcance

Este documento describe únicamente los archivos fuente proporcionados. No presupone el contenido de `.csproj`, solución, configuración de compilación ni otros archivos que puedan existir dentro de `SistemaBancario.zip`.
