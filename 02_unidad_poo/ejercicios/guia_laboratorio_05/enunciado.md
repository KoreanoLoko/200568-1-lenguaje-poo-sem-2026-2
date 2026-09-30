# Guía de Laboratorio 05

Material oficial transcrito desde la tarea **Guía de Laboratorio 05** publicada en Canvas para la asignatura.

## Datos de la actividad

- **Fecha de entrega:** no hay fecha de entrega.
- **Puntos:** 0.

## El Sistema de Cuenta Bancaria

La guía solicita construir una aplicación de consola en C# llamada:

```text
SistemaBancario
```

El ejercicio consolida:

- miembros estáticos;
- miembros de instancia;
- propiedades;
- constructores;
- métodos de instancia;
- métodos estáticos;
- validaciones;
- retorno booleano;
- menú interactivo con `do-while` y `switch`.

## Paso 1: Crear el proyecto

Crear una aplicación de consola en C# limpia denominada:

```text
SistemaBancario
```

## Paso 2: Implementar la clase CuentaBancaria

Crear en la raíz del proyecto:

```text
CuentaBancaria.cs
```

El código oficial entregado por la guía se conserva en:

`ejemplo_oficial/CuentaBancaria.cs`

## Arquitectura de CuentaBancaria

### Miembros estáticos

```csharp
private static int contadorCuentas = 0;
private static decimal tasaMantenimientoGlobal = 500.00m;
```

El material introduce dos datos compartidos por la clase:

- `contadorCuentas`;
- `tasaMantenimientoGlobal`.

> Nota de fidelidad: `tasaMantenimientoGlobal` aparece declarada en el código proporcionado, pero no se utiliza posteriormente en el fragmento entregado por la guía.

### Propiedades de instancia

```csharp
public string NumeroCuenta { get; }
public string Titular { get; set; }
public decimal Saldo { get; private set; }
```

La guía combina:

- propiedad de solo lectura externa: `NumeroCuenta`;
- propiedad pública de lectura y escritura: `Titular`;
- propiedad con escritura privada: `Saldo`.

## Constructor

La firma indicada es:

```csharp
public CuentaBancaria(string titular, decimal saldoInicial)
```

El constructor:

1. incrementa el contador estático;
2. genera un número correlativo de cuenta;
3. asigna el titular;
4. asigna el saldo inicial.

El correlativo se genera mediante:

```csharp
NumeroCuenta = "CTA-" + 202600 + contadorCuentas;
```

## Método Depositar

La guía entrega:

```csharp
public void Depositar(decimal monto)
```

El método valida:

```csharp
if (monto > 0)
```

y, si la condición se cumple:

```csharp
Saldo += monto;
```

Luego imprime el saldo resultante.

## Método Retirar

La firma entregada es:

```csharp
public bool Retirar(decimal monto)
```

La condición utiliza:

```csharp
if (monto > 0 && monto <= Saldo)
```

Si se cumple:

- resta el monto;
- informa el nuevo saldo;
- retorna `true`.

Si no se cumple:

- informa fondos insuficientes o monto inválido;
- retorna `false`.

## Método estático

La guía incluye:

```csharp
public static int ObtenerCantidadCuentas()
```

que retorna:

```csharp
contadorCuentas
```

Este método pertenece a la clase y permite consultar la cantidad total de cuentas creadas.

## Desafío de Programación Autónomo

El estudiante debe modificar:

```text
Program.cs
```

para:

1. instanciar `CuentaBancaria`;
2. construir un menú interactivo;
3. utilizar `do-while`;
4. utilizar `switch`;
5. permitir depositar;
6. permitir retirar;
7. consultar saldo;
8. imprimir la cantidad total de cuentas creadas.

## Observaciones de fidelidad

La guía indica literalmente que la cantidad de cuentas corresponde al "sistema escolar". Ese término se conserva como parte del enunciado, aunque el contexto del ejercicio es bancario.

La guía no proporciona el código completo de `Program.cs`; por tanto, este repositorio no inventa una solución oficial.

## Regla de documentación

La estructura esperada para una futura solución es:

```text
guia_laboratorio_05/
├── enunciado.md
├── ejemplo_oficial/
│   └── CuentaBancaria.cs
└── solucion/
    ├── CuentaBancaria.cs
    └── Program.cs
```
