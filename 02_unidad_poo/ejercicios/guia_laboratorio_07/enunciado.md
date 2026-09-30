# Guía de Laboratorio 07

Material oficial transcrito desde la tarea **Guía de Laboratorio 07** publicada en Canvas para la asignatura.

## Datos de la actividad

- **Fecha de entrega:** no hay fecha de entrega.
- **Puntos:** 0.
- **Tipo de entrega:** carga de archivo.
- **Calificación:** la tarea no cuenta para la calificación final.

# Métodos, Parámetros Especiales (ref/out) y Sobrecarga de Constructores

## ¿Qué aprenderemos en esta sesión?

La guía indica que esta sesión consolida la teoría de la Unidad Temática 3 y prepara para el Certamen 1 de la semana siguiente.

Los objetivos declarados son:

- invocar métodos de instancia utilizando nomenclatura profesional **PascalCase**;
- utilizar variables por referencia mediante `ref`;
- utilizar parámetros de salida obligatorios mediante `out`;
- comprender el rol de los constructores en el Heap;
- aplicar sobrecarga de constructores;
- encadenar constructores mediante `this(...)`.

## Cuadro de Control Técnico: Paso de Parámetros

| Criterio | `ref` | `out` |
| --- | --- | --- |
| Propósito | Modificación bidireccional y lectura de una variable física en Stack. | Retornar múltiples resultados independientes desde un mismo método. |
| Inicialización en llamador | Obligatoria antes de invocar. | No requerida. |
| Asignación en método | Opcional. | Obligatoria antes de retornar. |

# Caso de Estudio: Cuenta de Impresión de la Sede IPVG

La guía modela el saldo de impresión estudiantil.

## Uso de ref

La fuente indica que el saldo de una credencial externa se descuenta directamente mediante un parámetro:

```csharp
ref decimal tarjetaSaldo
```

## Uso de out

El método entrega dos datos obligatorios:

- cantidad de páginas impresas;
- costo total de la operación.

## Sobrecarga de constructores

La guía contempla:

- cuenta estándar con saldo por defecto de $1.000;
- cuenta preferencial con saldo personalizado.

# Código Fuente de Solución

Los códigos oficiales entregados por Canvas se conservan en:

```text
ejemplo_oficial/
├── CuentaImpresion.cs
└── Program.cs
```

## CuentaImpresion

La clase oficial posee:

```csharp
public string Estudiante { get; set; }
public decimal Saldo { get; private set; }
public string TipoCuenta { get; }
```

### Constructor estándar

```csharp
public CuentaImpresion(string estudiante)
    : this(estudiante, 1000.00m, "Estándar")
```

### Constructor preferencial

```csharp
public CuentaImpresion(string estudiante, decimal saldoInicial)
    : this(estudiante, saldoInicial, "Preferencial")
```

### Constructor principal privado

```csharp
private CuentaImpresion(string estudiante, decimal saldo, string tipo)
```

Este constructor concentra la inicialización y normaliza el nombre mediante:

```csharp
Estudiante = estudiante.ToUpper();
```

## Método transaccional avanzado

La firma oficial es:

```csharp
public bool ProcesarImpresion(
    int paginasSolicitadas,
    ref decimal tarjetaSaldo,
    out int paginasImpresas,
    out decimal costoTotal)
```

Dentro del método:

- el costo por página es `40.00m`;
- `costoTotal` recibe obligatoriamente el costo calculado;
- `tarjetaSaldo` se descuenta mediante `ref`;
- `Saldo` se sincroniza con la tarjeta externa;
- `paginasImpresas` se asigna tanto en éxito como en falla;
- el método retorna `true` o `false`.

# Punto de Entrada e Invocación

El `Program.cs` oficial:

1. crea una cuenta estándar;
2. crea una cuenta preferencial;
3. inicializa un saldo físico externo de `5000.00m`;
4. declara las variables que serán utilizadas como `out`;
5. invoca `ProcesarImpresion`;
6. imprime los resultados si la operación fue exitosa.

La llamada principal es:

```csharp
bool exito = c2.ProcesarImpresion(
    35,
    ref saldoFisicoTarj,
    out paginasImpresas,
    out montoDescontado);
```

# Desafío de Preparación — Pre-Certamen 1

La guía solicita dos extensiones:

1. Agregar una variable:

```csharp
static int totalTrabajosSede
```

que se incremente por cada impresión exitosa.

2. Crear un método estático que imprima el acumulado global de trabajos.

> **Nota de fidelidad:** en la captura de Canvas el nombre visible del método aparece como `public static void MostrarInfoIglobal()`. Se conserva esa escritura en el archivo del desafío, sin corregirla silenciosamente.

El desafío también se registra en:

`03_certamen_1/ejercicios/desafio_pre_certamen_1_impresiones.md`

# Conceptos incorporados o reforzados

- PascalCase en métodos;
- `ref`;
- `out`;
- múltiples parámetros `out`;
- retorno `bool`;
- sobrecarga de constructores;
- constructor privado;
- constructor principal;
- delegación con `: this(...)`;
- `ToUpper()`;
- `decimal`;
- `private set`;
- propiedad de solo lectura;
- sincronización entre estado externo e interno;
- miembros `static` como preparación para el Certamen 1.

# Alcance

Este documento conserva el enunciado, códigos y desafío de la Guía de Laboratorio 07. No implementa la solución del desafío Pre-Certamen, porque la fuente lo deja como trabajo del estudiante.
