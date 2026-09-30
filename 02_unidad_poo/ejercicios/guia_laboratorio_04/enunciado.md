# Guía de Laboratorio 04

Material oficial transcrito desde la tarea **Guía de Laboratorio 04** publicada en Canvas para la asignatura.

## Datos de la actividad

- **Fecha de entrega:** 26 de agosto, 23:59.
- **Puntos:** 0.
- **Tipo de entrega:** carga de archivo.
- **Intentos:** 1.
- **Intentos permitidos:** 1.
- **Disponible hasta:** 26 de agosto, 23:59.
- **Estado indicado:** la tarea fue bloqueada el 26 de agosto a las 23:59.
- **Calificación:** la captura de Canvas indica que esta tarea no cuenta para la calificación final.

## Sistema de Bandejas de Almuerzo

La guía solicita implementar individualmente un sistema básico de compra de bandejas de almuerzo para el Casino de Virginio Gómez.

El objetivo es consolidar de manera concreta los conceptos de **tipo por valor** y **tipo por referencia** mediante una arquitectura orientada a objetos.

## 1. Diseñar el Tipo por Valor

Crear un `struct` denominado:

```csharp
DetallePago
```

Debe contener dos campos públicos:

```csharp
decimal Monto;
string MetodoPago;
```

Ejemplos de método de pago mencionados por la guía:

- Débito;
- Efectivo;
- Junaeb.

## 2. Diseñar el Tipo por Referencia

Crear una clase denominada:

```csharp
BandejaAlmuerzo
```

Debe contener las propiedades públicas autoimplementadas:

```csharp
string Estudiante
string MenuPrincipal
```

Además, debe incorporar un campo público de tipo `DetallePago` denominado:

```csharp
Pago
```

La arquitectura solicitada puede representarse de esta forma:

```text
struct DetallePago
├── decimal Monto
└── string MetodoPago

class BandejaAlmuerzo
├── string Estudiante
├── string MenuPrincipal
└── DetallePago Pago
```

## 3. Demostrar el comportamiento en Main()

La guía solicita crear una bandeja de almuerzo con los siguientes datos:

- **Estudiante:** María Carrasco.
- **Menú:** Tallarines con salsa bolognesa.
- **Monto:** $3.500.
- **Método de pago:** Junaeb.

Luego se debe copiar la variable utilizando:

```csharp
=
```

en una nueva variable denominada:

```csharp
bandeja2
```

Después se solicita modificar:

- el estudiante de `bandeja2` a **Pedro Soto**;
- el monto del pago a **$4.000**;
- el método de pago a **Débito**.

## Análisis solicitado

La guía pide imprimir en consola los valores de ambas bandejas y responder/discutir:

> ¿Por qué el nombre del estudiante cambió en ambas variables, mientras que los datos del detalle del pago (struct embebido) se comportan de forma diferente cuando se altera la estructura completa?

El resultado debe discutirse con el docente al término de la sesión.

## Conceptos trabajados

- `struct` como tipo por valor;
- `class` como tipo por referencia;
- tipo `decimal`;
- campos públicos;
- propiedades públicas autoimplementadas;
- composición de un `struct` dentro de una clase;
- instanciación;
- asignación mediante `=`;
- alias/referencia compartida de una instancia de clase;
- modificación de estado;
- impresión y análisis de resultados.

## Observación de fidelidad

La guía formula explícitamente una comparación entre el cambio del nombre del estudiante y el comportamiento del `struct DetallePago` embebido cuando se altera la estructura completa.

El material proporcionado **no incluye una implementación oficial ni una salida esperada exacta** para esa parte. Por ello, este documento conserva el enunciado sin inferir una respuesta o corregir su planteamiento.

## Regla de documentación

Este archivo contiene únicamente el **enunciado oficial**. Una solución desarrollada por el estudiante deberá mantenerse separada, por ejemplo:

```text
guia_laboratorio_04/
├── enunciado.md
└── solucion/
    └── ...
```
