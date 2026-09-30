# 20 — Constructores, sobrecarga y delegación con this

Apunte derivado exclusivamente del PDF **Invocacion y mensajeria y constructores.pdf**.

> **Fuente:** `../clases/Invocacion y mensajeria y constructores.pdf`

## Constructor

La fuente presenta el constructor como la rutina de inicialización del objeto.

Se relaciona directamente con:

```csharp
new
```

y con la creación de un estado inicial consistente.

## Reglas sintácticas

### Mismo nombre que la clase

```csharp
public class CuentaImpresion
{
    public CuentaImpresion()
    {
    }
}
```

### Sin tipo de retorno

Un constructor no declara:

```text
void
int
decimal
...
```

antes de su nombre.

## Sobrecarga

La misma clase puede declarar constructores diferentes si sus firmas pueden distinguirse.

Ejemplos mostrados:

```csharp
CuentaImpresion()
CuentaImpresion(decimal saldo)
CuentaImpresion(decimal saldo, bool promo)
```

## Constructor maestro

El PDF concentra la inicialización principal en:

```csharp
public CuentaImpresion(decimal saldoInicial)
{
    Saldo = saldoInicial;
}
```

## Delegación con this

Constructor por defecto:

```csharp
public CuentaImpresion() : this(0.0m)
{
}
```

Constructor promocional:

```csharp
public CuentaImpresion(decimal saldo, bool promo) : this(saldo)
{
    if (promo) Saldo += 500.0m;
}
```

## Flujo conceptual

```text
CuentaImpresion()
       ↓
   this(0.0m)
       ↓
constructor maestro
```

```text
CuentaImpresion(saldo, promo)
       ↓
   this(saldo)
       ↓
constructor maestro
       ↓
aplicar bono si promo
```

## Principio DRY

La fuente relaciona la delegación con evitar repetir lógica de inicialización en varios constructores.

## Conceptos habilitados

- constructor;
- sobrecarga de constructores;
- constructor maestro;
- `: this(...)`;
- delegación;
- inicialización consistente;
- propiedad con `private set`.

## Alcance

Este documento conserva únicamente el contenido del Bloque 3 y el código mostrado en la presentación.
