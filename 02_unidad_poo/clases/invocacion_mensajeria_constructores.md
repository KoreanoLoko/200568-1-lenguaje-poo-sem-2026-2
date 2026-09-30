# Invocación, mensajería y constructores en C#

Documento derivado exclusivamente del material oficial **Invocacion y mensajeria y constructores.pdf**.

> **Fuente original prevista en el repositorio:** `02_unidad_poo/clases/Invocacion y mensajeria y constructores.pdf`

## Identificación

- **Título de portada:** Dominando el Comportamiento y la Memoria en C#
- **Semana:** 4
- **Tema:** Métodos, parámetros especiales (`ref`, `out`) y sobrecarga de constructores
- **Asignatura:** Lenguaje de Programación OO (0568)
- **Institución:** Instituto Profesional Virginio Gómez - Universidad de Concepción
- **Extensión:** 20 páginas

## Mapa del contenido

| Página | Tema |
| ---: | --- |
| 1 | Portada de Semana 4. |
| 2 | Bloque 1: Invocación de métodos y mensajería. |
| 3 | El método como comportamiento activo del objeto. |
| 4 | Operador punto como mecanismo de acceso e invocación. |
| 5 | Anatomía y firma de un método en C#. |
| 6 | Diferencia entre métodos `void` y métodos con `return`. |
| 7 | Bloque 2: Paso de parámetros avanzado en .NET. |
| 8 | Comportamiento estándar: copia por valor. |
| 9 | Referencia bidireccional directa con `ref`. |
| 10 | Parámetro de múltiple salida con `out`. |
| 11 | Matriz de diagnóstico de parámetros. |
| 12 | Bloque 3: Constructores y sobrecarga. |
| 13 | Propósito arquitectónico del constructor. |
| 14 | Reglas sintácticas de un constructor. |
| 15 | Sobrecarga de constructores. |
| 16 | Encadenamiento y delegación mediante `this(...)`. |
| 17 | Bloque 4: Laboratorio Sistema de Impresiones IPVG. |
| 18 | Arquitectura del sistema `CuentaImpresion`. |
| 19 | Implementación de constructores. |
| 20 | Método transaccional con `ref` y `out`. |

---

# Bloque 1 — Invocación de Métodos y Mensajería

## El método define el comportamiento activo del objeto

La presentación distingue entre:

- **estado**: atributos y campos que describen al objeto;
- **comportamiento**: acciones que el objeto puede ejecutar.

El material expresa la comunicación entre objetos como **mensajería**, materializada en C# mediante invocaciones de métodos.

## El operador punto

La diapositiva utiliza como ejemplo:

```csharp
miCuenta.Imprimir();
```

El operador:

```text
.
```

conecta la referencia del objeto con el miembro que se desea utilizar.

El material lo presenta como el mecanismo que permite activar un comportamiento del objeto.

## Anatomía y firma de un método

Ejemplo de la presentación:

```csharp
public void CargarPapel(int cantidadHojas)
```

La diapositiva divide la firma en:

- `public`: modificador de acceso;
- `void`: tipo de retorno;
- `CargarPapel`: identificador del método;
- `int cantidadHojas`: parámetro.

El material también establece como convención que el nombre del método utilice **PascalCase**.

## void frente a return

### Método void

La fuente lo presenta como una acción que puede modificar estado o producir salida, pero que no devuelve un dato al llamador.

### Método con retorno

La fuente indica que debe declarar un tipo de retorno y utilizar `return` para entregar el resultado.

---

# Bloque 2 — Paso de Parámetros Avanzado en .NET

## Paso por valor

La presentación explica que, para tipos por valor, el método recibe una copia aislada.

Conceptualmente:

```text
original
   ↓ copia
parámetro local
```

La modificación de la copia no modifica el valor original.

## ref

El material presenta `ref` como una referencia bidireccional directa.

Características indicadas:

- permite lectura y escritura;
- modifica directamente la variable original;
- la variable debe estar inicializada antes de la llamada.

La analogía visual utilizada es un conducto directo conectado a un saldo existente.

## out

El material presenta `out` como un parámetro de salida.

Características indicadas:

- no requiere información previa;
- el método debe asignarle un valor antes de finalizar;
- permite devolver datos adicionales además del retorno principal.

## Matriz de diagnóstico

| Mecanismo | ¿Requiere inicio? | Dirección de datos | Uso mostrado |
| --- | --- | --- | --- |
| Por valor | Sí | Unidireccional / entrada | Enviar un dato solo para lectura. |
| `ref` | Sí | Bidireccional | Modificar un saldo existente. |
| `out` | No | Salida obligatoria | Emitir un resultado adicional. |

---

# Bloque 3 — Métodos Constructores y Sobrecarga

## Propósito del constructor

La presentación describe el constructor como la rutina de inicialización del objeto y le atribuye dos propósitos:

1. trabajar junto con `new` en la creación de la instancia;
2. establecer un estado inicial consistente.

La diapositiva relaciona una mala inicialización con posibles errores posteriores y presenta al constructor como el punto en que deben quedar definidos valores válidos para el estado del objeto.

## Características sintácticas

El material destaca dos reglas:

1. el nombre del constructor debe coincidir exactamente con el nombre de la clase;
2. no declara tipo de retorno, ni siquiera `void`.

Ejemplo:

```csharp
public class CuentaImpresion
{
    public CuentaImpresion(string rut)
    {
    }
}
```

## Sobrecarga de constructores

La presentación muestra una misma clase con distintas formas de creación:

```text
CuentaImpresion()
CuentaImpresion(decimal saldoBase)
CuentaImpresion(decimal saldo, bool esPromo)
```

La diferencia está en la firma: cantidad y/o tipos de parámetros.

## Encadenamiento y delegación con this

La fuente introduce:

```csharp
:this(...)
```

como mecanismo para delegar desde un constructor hacia otro constructor de la misma clase.

El propósito pedagógico mostrado es evitar duplicar lógica de inicialización y concentrarla en un **constructor maestro**.

---

# Bloque 4 — Sistema de Impresiones IPVG

## Arquitectura planteada

La diapositiva define:

```text
CuentaImpresion
------------------------------
- Rut: string
- Saldo: decimal
------------------------------
+ CuentaImpresion()
+ CuentaImpresion(saldo: decimal)
+ CuentaImpresion(saldo: decimal, promo: bool)
+ ProcesarImpresion(ref saldo: decimal,
                    out paginas: int): void
```

La actividad enfatiza:

- `decimal` para dinero;
- tres constructores;
- `ref` para modificar el saldo real;
- `out` para entregar la cantidad de páginas.

## Código Paso 1 — Constructores

La diapositiva muestra:

```csharp
public class CuentaImpresion
{
    public decimal Saldo { get; private set; }

    // Constructor Maestro
    public CuentaImpresion(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }

    // Constructor por defecto (Delega enviando 0)
    public CuentaImpresion() : this(0.0m)
    {
    }

    // Constructor Promocional (Delega y luego aplica bono)
    public CuentaImpresion(decimal saldo, bool promo) : this(saldo)
    {
        if (promo) Saldo += 500.0m;
    }
}
```

Este fragmento se conserva también en:

`02_unidad_poo/ejercicios/sistema_impresiones_ipvg/fragmento_oficial/CuentaImpresion.cs`

## Código Paso 2 — Motor transaccional

La presentación agrega el método:

```csharp
public void ProcesarImpresion(ref decimal saldoActual, int costoDoc, out int paginas)
{
    paginas = 0;

    if (saldoActual >= costoDoc)
    {
        saldoActual -= costoDoc;
        paginas = costoDoc / 20;
        Console.WriteLine($"Impresión OK. Saldo restante: ${saldoActual}");
    }
    else
    {
        Console.WriteLine("Saldo insuficiente para imprimir.");
    }
}
```

El material utiliza:

- `ref decimal saldoActual` para leer y modificar el saldo entregado;
- `out int paginas` para garantizar un valor de salida;
- asignación inicial `paginas = 0`;
- validación con `if`;
- descuento directo sobre el saldo;
- cálculo de páginas a razón de 20 pesos por hoja.

## Conceptos incorporados o reforzados

- mensajería entre objetos;
- operador de punto;
- firma de métodos;
- PascalCase para métodos;
- `void`;
- `return`;
- paso por valor;
- `ref`;
- `out`;
- constructor;
- constructor maestro;
- sobrecarga de constructores;
- delegación mediante `: this(...)`;
- principio DRY mencionado por la fuente;
- propiedad con `private set`;
- parámetros especiales combinados en un método transaccional.

## Alcance

Este documento conserva la organización, terminología, ejemplos y código mostrados en las 20 páginas del PDF. Cuando una afirmación corresponde al modelo pedagógico de la presentación, se documenta como tal y no se sustituye por una explicación externa.
