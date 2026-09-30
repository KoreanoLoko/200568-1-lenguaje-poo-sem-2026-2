# Sistema de Impresiones IPVG — Laboratorio guiado

Enunciado derivado exclusivamente del Bloque 4 del PDF **Invocacion y mensajeria y constructores.pdf**.

## Contexto

Construir el módulo central del tarjetero de fotocopias de la sede mediante una clase:

```csharp
CuentaImpresion
```

## Requisitos de arquitectura

### Estado

```text
Rut   : string
Saldo : decimal
```

### Constructores

Se requieren tres formas de creación:

```csharp
CuentaImpresion()
CuentaImpresion(decimal saldo)
CuentaImpresion(decimal saldo, bool promo)
```

La presentación indica:

- constructor por defecto;
- constructor con saldo inicial;
- constructor promocional.

## Precisión financiera

El saldo debe utilizar:

```csharp
decimal
```

y no `double` ni `float`, de acuerdo con la regla de precisión financiera utilizada por el material.

## Método transaccional

La arquitectura muestra:

```csharp
ProcesarImpresion(ref decimal saldo, out int paginas)
```

mientras que el código de la página final incorpora además:

```csharp
int costoDoc
```

como parámetro de entrada:

```csharp
public void ProcesarImpresion(
    ref decimal saldoActual,
    int costoDoc,
    out int paginas)
```

> **Nota de fidelidad:** se conservan ambas representaciones porque ambas aparecen en el PDF. La diapositiva de arquitectura resume la firma sin `costoDoc`, mientras que la diapositiva de implementación sí lo incluye.

## Comportamiento esperado en el código mostrado

1. Inicializar `paginas = 0`.
2. Verificar si `saldoActual >= costoDoc`.
3. Si existe saldo:
   - descontar `costoDoc`;
   - calcular `paginas = costoDoc / 20`;
   - mostrar el saldo restante.
4. Si no existe saldo suficiente:
   - mostrar el mensaje correspondiente.

## Constructores mostrados

El fragmento oficial de código se conserva en:

```text
fragmento_oficial/CuentaImpresion.cs
```

## Conceptos que busca aplicar

- métodos;
- parámetros;
- `ref`;
- `out`;
- `decimal`;
- constructores;
- sobrecarga;
- delegación con `: this(...)`;
- propiedades;
- validación transaccional.

## Regla de documentación

Este archivo contiene el enunciado y arquitectura visibles en el PDF. No se inventa un `Program.cs`, ni se completa el manejo de `Rut`, porque la presentación no proporciona ese código.
