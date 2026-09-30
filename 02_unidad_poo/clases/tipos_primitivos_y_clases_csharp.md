# Tipos primitivos y clases en C#

Documento derivado exclusivamente del material oficial **Tipos primitivos y clases en C#.pdf**.

> **Fuente original prevista en el repositorio:** `02_unidad_poo/clases/Tipos primitivos y clases en C#.pdf`

## Identificación

- **Título de portada:** Lenguaje de Programación OO
- **Código indicado:** 0568
- **Semana:** 3
- **Tema:** De Tipos Primitivos a Clases en C# y .NET
- **Institución:** Instituto Profesional Virginio Gómez - Universidad de Concepción
- **Extensión:** 11 páginas

## Mapa del contenido

| Página | Tema |
| ---: | --- |
| 1 | Portada: Semana 3, de tipos primitivos a clases en C# y .NET. |
| 2 | Tipos y variables: `int`, `long`, `decimal`, `string`, `char`, `bool` e inferencia con `var`. |
| 3 | Control de flujo con `if / else if / else` y `switch`. |
| 4 | Iteración con `for`, `while` y `do-while`. |
| 5 | Encapsulamiento: campos privados y propiedades públicas. |
| 6 | Comparación entre miembros de instancia y miembros estáticos. |
| 7 | Clase `CuentaBancaria`: `TotalCuentas`, `_saldo`, `Titular` y constructor. |
| 8 | Métodos `Depositar` y `Retirar` con validaciones. |
| 9 | Actividad: construir `Main` con menú de cajero. |
| 10 | Arquitectura esperada del menú con `do-while` y `switch`. |
| 11 | Competencias logradas y entrega de `BancoApp`. |

---

## 1. Tipos y variables

La presentación agrupa los tipos en tres bloques.

### Tipos numéricos

- `int`
- `long`

El material los presenta como enteros para uso general.

### Tipo financiero

La fuente destaca:

```csharp
decimal
```

como tipo de alta precisión recomendado para dinero.

### Texto y lógica

- `string`
- `char`
- `bool`

### Inferencia con var

La diapositiva utiliza:

```csharp
var mensaje = "Hola";
```

y señala que el compilador determina el tipo estático.

---

## 2. Control de flujo

### if / else if / else

La fuente lo presenta para evaluaciones secuenciales de condiciones booleanas.

Ejemplo mostrado:

```csharp
if (saldo > monto)
{
    Retirar(monto);
}
else
{
    Rechazar();
}
```

### switch

La presentación lo recomienda para menús de opciones o estados definidos.

Ejemplo mostrado:

```csharp
switch (opcion)
{
    case "1": Depositar(); break;
    case "2": Retirar(); break;
    default: Salir(); break;
}
```

---

## 3. Iteración

El material compara tres estructuras.

### for

Se presenta como **iteración contada**.

Uso indicado: cuando se conoce exactamente cuántas veces debe repetirse el ciclo.

### while

Se presenta como **condición primero**.

La condición se evalúa antes de entrar y el bloque puede ejecutarse cero veces.

### do-while

Se presenta como **ejecución primero**.

Garantiza al menos una ejecución antes de evaluar la condición y se destaca como adecuada para menús interactivos.

---

## 4. Encapsulamiento

La página dedicada a anatomía de clases contrasta:

```csharp
private decimal _saldo;
```

con:

```csharp
public decimal Saldo { get; private set; }
```

La fuente utiliza el campo privado para representar datos internos protegidos y la propiedad pública para controlar el acceso.

La propiedad con:

```csharp
private set;
```

se presenta como una forma de permitir lectura pública y restringir la escritura.

---

## 5. Miembros de instancia vs. miembros estáticos

La presentación compara ambos tipos de miembros.

| Característica | Miembros de instancia | Miembros estáticos |
| --- | --- | --- |
| Pertenencia | Objeto individual creado con `new`. | Clase en sí misma. |
| Gestión presentada | Asignado por cada objeto. | Asignado una sola vez para la clase. |
| Ejemplo de acceso | `miCuenta.Depositar()` | `CuentaBancaria.TotalCuentas` |
| Caso práctico | Saldo específico de una cuenta. | Contador global de cuentas. |

---

## 6. Ejemplo CuentaBancaria

La presentación muestra una clase:

```csharp
public class CuentaBancaria
```

con los siguientes miembros.

### Miembro estático

```csharp
public static int TotalCuentas { get; private set; }
```

Se utiliza como contador global de instancias.

### Campo privado

```csharp
private decimal _saldo;
```

### Propiedad de solo lectura después de inicialización

```csharp
public string Titular { get; }
```

### Constructor

```csharp
public CuentaBancaria(string titular)
{
    Titular = titular;
    _saldo = 0;
    TotalCuentas++;
}
```

El constructor:

1. recibe el titular;
2. inicializa el saldo;
3. incrementa el contador estático.

---

## 7. Métodos de negocio

### Depositar

La presentación muestra:

```csharp
public void Depositar(decimal monto)
{
    if (monto > 0)
    {
        _saldo += monto;
    }
}
```

La validación evita depósitos negativos.

### Retirar

El material muestra:

```csharp
public void Retirar(decimal monto)
{
    if (monto > 0 && _saldo >= monto)
    {
        _saldo -= monto;
    }
}
```

Aquí se utiliza:

```text
&&
```

para exigir simultáneamente:

- monto positivo;
- saldo suficiente.

---

## 8. Actividad BancoApp

La página 9 solicita construir el método `Main` para operar una `CuentaBancaria` desde consola.

El menú indicado es:

```text
--- MENÚ CAJERO ---

1. Depositar
2. Retirar
3. Ver Saldo
4. Salir

Ingrese su opción:
```

### Restricción

La aplicación debe mantenerse en ejecución hasta que el usuario seleccione la opción:

```text
4
```

---

## 9. Arquitectura del menú

La diapositiva 10 representa el siguiente flujo:

```text
Instanciar CuentaBancaria
          ↓
do
{
    imprimir menú
    capturar Console.ReadLine()
          ↓
    switch(opcion)
      ├── Depositar()
      ├── Retirar()
      └── Leer Saldo
}
while (opcion != "4");
```

Esto integra:

- instanciación de objetos;
- lectura desde consola;
- `do-while`;
- `switch`;
- invocación de métodos;
- lectura de propiedades.

---

## 10. Competencias logradas según la presentación

La página final resume:

### Tipos seguros

Uso de:

- `decimal`;
- `var`.

### Control de flujo

Uso de:

- `switch`;
- `do-while`.

### Diseño OOP

Uso de:

- miembros de instancia;
- miembros estáticos;
- protección de datos mediante propiedades.

El material señala que se ha construido un primer sistema orientado a objetos robusto y compilable en .NET.

También solicita:

> Cargar el código BancoApp al repositorio antes de la próxima sesión (Semana 4).

## Apuntes derivados

- `02_unidad_poo/apuntes/12_bucles_for_while_do_while.md`
- `02_unidad_poo/apuntes/13_cuenta_bancaria_encapsulamiento_static.md`

## Actividad derivada

- `02_unidad_poo/ejercicios/banco_app/enunciado.md`

## Alcance

Este documento conserva el contenido y modelo pedagógico del PDF. No agrega implementaciones externas ni completa código que la presentación no entrega.
