# 13 — CuentaBancaria: encapsulamiento, constructor y static

Apunte derivado exclusivamente del PDF **Tipos primitivos y clases en C#**.

> **Fuente:** `../clases/Tipos primitivos y clases en C#.pdf`

## Estructura presentada

La clase de ejemplo es:

```csharp
public class CuentaBancaria
```

y combina:

- estado privado;
- propiedades;
- miembro estático;
- constructor;
- métodos de negocio;
- validaciones.

## Campo privado

```csharp
private decimal _saldo;
```

La fuente lo utiliza para proteger el saldo interno.

## Propiedad con setter privado

```csharp
public decimal Saldo { get; private set; }
```

En la explicación de encapsulamiento, este patrón se presenta como acceso público de lectura con escritura restringida.

## Propiedad estática

```csharp
public static int TotalCuentas { get; private set; }
```

`TotalCuentas` pertenece a la clase y representa un contador global de cuentas.

## Propiedad Titular

```csharp
public string Titular { get; }
```

La diapositiva la describe como de solo lectura tras la inicialización del objeto.

## Constructor

```csharp
public CuentaBancaria(string titular)
{
    Titular = titular;
    _saldo = 0;
    TotalCuentas++;
}
```

El constructor introduce explícitamente:

- parámetros de constructor;
- inicialización de estado;
- operador `++`;
- actualización de un miembro estático.

## Depositar

```csharp
public void Depositar(decimal monto)
{
    if (monto > 0)
    {
        _saldo += monto;
    }
}
```

Conceptos utilizados:

- método de instancia;
- parámetro `decimal`;
- validación con `if`;
- acumulación con `+=`.

## Retirar

```csharp
public void Retirar(decimal monto)
{
    if (monto > 0 && _saldo >= monto)
    {
        _saldo -= monto;
    }
}
```

La condición combina dos validaciones mediante:

```text
&&
```

y utiliza:

```text
>=
```

para verificar fondos suficientes.

## Instancia vs. static

```text
miCuenta.Depositar()
        │
        └── operación sobre una instancia

CuentaBancaria.TotalCuentas
        │
        └── dato compartido por la clase
```

## Conceptos incorporados o reforzados

- constructor;
- propiedad con `private set`;
- propiedad de solo lectura;
- campo privado;
- miembro estático;
- `++`;
- `+=`;
- `-=`;
- `&&`;
- `>=`;
- métodos de negocio;
- validación de reglas antes de modificar estado.

## Alcance

Este documento mantiene los fragmentos y explicaciones mostrados en la fuente oficial sin completar la clase más allá de lo visible en el PDF.
