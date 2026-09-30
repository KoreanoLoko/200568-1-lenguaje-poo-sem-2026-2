# 22 — CuentaImpresion: constructores delegados, ref y múltiples out

Apunte derivado exclusivamente de la **Guía de Laboratorio 07**.

> **Fuente:** `../ejercicios/guia_laboratorio_07/enunciado.md`

## Objetivo

La guía integra en un solo caso:

- sobrecarga de constructores;
- constructor principal privado;
- delegación mediante `: this(...)`;
- parámetro `ref`;
- dos parámetros `out`;
- retorno `bool`.

## Constructores públicos

### Cuenta estándar

```csharp
public CuentaImpresion(string estudiante)
    : this(estudiante, 1000.00m, "Estándar")
```

### Cuenta preferencial

```csharp
public CuentaImpresion(string estudiante, decimal saldoInicial)
    : this(estudiante, saldoInicial, "Preferencial")
```

Ambos delegan en un único constructor principal.

## Constructor principal privado

```csharp
private CuentaImpresion(
    string estudiante,
    decimal saldo,
    string tipo)
```

La guía utiliza este constructor para centralizar:

```csharp
Estudiante = estudiante.ToUpper();
Saldo = saldo;
TipoCuenta = tipo;
```

## Flujo de delegación

```text
CuentaImpresion("Seba")
       ↓
this("Seba", 1000m, "Estándar")
       ↓
constructor privado
```

```text
CuentaImpresion("Majo", 5000m)
       ↓
this("Majo", 5000m, "Preferencial")
       ↓
constructor privado
```

## Método ProcesarImpresion

```csharp
public bool ProcesarImpresion(
    int paginasSolicitadas,
    ref decimal tarjetaSaldo,
    out int paginasImpresas,
    out decimal costoTotal)
```

### Parámetro por valor

```csharp
int paginasSolicitadas
```

es una entrada normal.

### ref

```csharp
ref decimal tarjetaSaldo
```

requiere inicialización previa y puede ser modificado.

### out 1

```csharp
out decimal costoTotal
```

recibe:

```csharp
costoTotal = paginasSolicitadas * costoPorPagina;
```

### out 2

```csharp
out int paginasImpresas
```

debe asignarse en todas las rutas:

```text
éxito → paginasSolicitadas
falla → 0
```

## Retorno bool

El retorno principal informa si la impresión fue exitosa:

```text
true  → impresión procesada
false → saldo insuficiente
```

Esto demuestra que un mismo método puede producir:

- un retorno normal `bool`;
- modificación de una variable mediante `ref`;
- dos resultados adicionales mediante `out`.

## Sincronización de estado

En éxito:

```csharp
tarjetaSaldo -= costoTotal;
Saldo = tarjetaSaldo;
```

La guía sincroniza el saldo externo entregado por referencia con la propiedad interna del objeto.

## Invocación

```csharp
bool exito = c2.ProcesarImpresion(
    35,
    ref saldoFisicoTarj,
    out paginasImpresas,
    out montoDescontado);
```

## Relación con Certamen 1

La propia guía declara que esta sesión prepara para el Certamen 1 e incorpora un desafío que agrega:

- `static int totalTrabajosSede`;
- un método `static` para mostrar el acumulado global.

## Alcance

Este apunte conserva exclusivamente la arquitectura y el comportamiento provistos por la Guía de Laboratorio 07.
