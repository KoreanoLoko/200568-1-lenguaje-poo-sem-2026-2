# 14 — Sistema Bancario: miembros static, constructor y métodos transaccionales

Apunte derivado exclusivamente de la **Guía de Laboratorio 05**.

> **Fuente:** `../ejercicios/guia_laboratorio_05/enunciado.md`

## Miembros estáticos

La guía utiliza:

```csharp
private static int contadorCuentas = 0;
private static decimal tasaMantenimientoGlobal = 500.00m;
```

Ambos pertenecen a la clase `CuentaBancaria`.

`contadorCuentas` se utiliza para conocer cuántas cuentas se han creado.

## Miembros de instancia

```csharp
public string NumeroCuenta { get; }
public string Titular { get; set; }
public decimal Saldo { get; private set; }
```

Cada objeto `CuentaBancaria` mantiene sus propios valores para estas propiedades.

## Constructor con parámetros

```csharp
public CuentaBancaria(string titular, decimal saldoInicial)
```

La guía utiliza el constructor para garantizar que cada cuenta nazca con:

- titular;
- saldo inicial;
- número de cuenta generado automáticamente.

## Correlativo automático

```csharp
contadorCuentas++;
NumeroCuenta = "CTA-" + 202600 + contadorCuentas;
```

Esto relaciona un miembro estático con la creación de múltiples instancias.

## Propiedades con distintos niveles de escritura

### Solo lectura externa

```csharp
public string NumeroCuenta { get; }
```

### Lectura y escritura pública

```csharp
public string Titular { get; set; }
```

### Escritura privada

```csharp
public decimal Saldo { get; private set; }
```

## Métodos de instancia

### Depositar

```csharp
public void Depositar(decimal monto)
```

modifica el estado de una cuenta particular.

### Retirar

```csharp
public bool Retirar(decimal monto)
```

además de modificar estado, devuelve un resultado booleano.

## Método estático

```csharp
public static int ObtenerCantidadCuentas()
```

no requiere una instancia específica para consultar el contador global.

## Operadores y estructuras reforzadas

La guía reutiliza:

- `++`;
- `+=`;
- `-=`;
- `&&`;
- `<=`;
- `if`;
- `return true`;
- `return false`.

## Desafío de consola

La guía vuelve a combinar:

```text
do-while
   +
switch
```

para crear un menú interactivo capaz de operar una `CuentaBancaria`.

## Alcance

Este apunte conserva únicamente lo introducido por la Guía de Laboratorio 05 y no completa el `Program.cs` que la actividad deja como trabajo autónomo.
