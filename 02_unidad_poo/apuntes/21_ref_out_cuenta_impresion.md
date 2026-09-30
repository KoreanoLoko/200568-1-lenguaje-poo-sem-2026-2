# 21 — ref y out aplicados a CuentaImpresion

Apunte derivado exclusivamente del PDF **Invocacion y mensajeria y constructores.pdf**.

> **Fuente:** `../clases/Invocacion y mensajeria y constructores.pdf`

## Método transaccional

La presentación utiliza:

```csharp
public void ProcesarImpresion(
    ref decimal saldoActual,
    int costoDoc,
    out int paginas)
```

para integrar paso por valor, `ref` y `out`.

## Parámetro por valor

```csharp
int costoDoc
```

se utiliza como dato de entrada.

## Parámetro ref

```csharp
ref decimal saldoActual
```

se utiliza para:

1. leer el saldo actual;
2. modificar ese mismo saldo si se puede procesar la impresión.

Ejemplo:

```csharp
saldoActual -= costoDoc;
```

## Parámetro out

```csharp
out int paginas
```

representa el resultado adicional del número de páginas.

La fuente inicializa obligatoriamente:

```csharp
paginas = 0;
```

antes de las rutas de salida.

Si hay saldo suficiente:

```csharp
paginas = costoDoc / 20;
```

## Flujo

```text
saldoActual (ref)
      ↓
leer saldo
      ↓
¿saldo >= costoDoc?
   ├── sí
   │   ├── descontar costo
   │   └── calcular paginas (out)
   └── no
       └── mantener paginas = 0
```

## Matriz de uso aplicada

| Parámetro | Modificador | Papel |
| --- | --- | --- |
| `saldoActual` | `ref` | entrada + modificación directa |
| `costoDoc` | ninguno | entrada por valor |
| `paginas` | `out` | salida obligatoria |

## Relación con TryParse

Materiales anteriores ya utilizaban:

```csharp
TryParse(..., out valor)
```

Este PDF amplía el concepto mostrando un método propio que declara y utiliza un parámetro `out`.

## Alcance

Este apunte conserva el ejemplo transaccional mostrado en el PDF y no agrega variantes externas.
