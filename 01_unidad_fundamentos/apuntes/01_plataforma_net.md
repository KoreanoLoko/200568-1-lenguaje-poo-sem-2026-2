# 01 — Plataforma .NET

Apunte derivado exclusivamente de la clase oficial **01S01 — Fundamentos de la Plataforma .NET**.

> **Fuente:** `../clases/01S01_Fundamentos_de_la_Plataforma_.NET.pdf`

## ¿Qué es la plataforma .NET?

La presentación describe .NET como un **ecosistema de desarrollo completo**, comparándolo con la plataforma Java.

Según el material, contiene lo necesario para:

- Construir aplicaciones.
- Compilar aplicaciones.
- Ejecutar aplicaciones.

El esquema de la clase sitúa a **.NET** en el centro y lo relaciona con:

- Lenguajes, incluyendo C#.
- Bibliotecas.
- Herramientas.

## Arquitectura .NET presentada en clase

La arquitectura se representa en capas:

1. Código C#.
2. Bibliotecas de clases.
3. CLR — Common Language Runtime.
4. Sistema operativo.

El material identifica al **CLR como el corazón del sistema** y señala que actúa como motor principal, aislando el código del hardware subyacente.

La presentación lo compara conceptualmente con la **JVM de Java**.

## CLR — Common Language Runtime

Dentro de la arquitectura presentada, el CLR es el componente responsable de ejecutar y gestionar el código.

Las funciones específicas mostradas en la clase se detallan en el apunte:

- `02_compilacion_cil_clr.md`

## Portabilidad

El material vincula la portabilidad con el uso de un archivo CIL universal y un CLR local en cada sistema operativo.

Los sistemas operativos ilustrados son:

- Windows.
- Linux.
- macOS.

La idea expresada por la presentación es que el CIL se mantiene como representación intermedia y el CLR de cada sistema realiza la traducción final.

## Entorno de trabajo

La herramienta indicada es **Visual Studio Community 2026**.

La presentación lo define como un IDE donde se trabaja mediante tres acciones principales:

1. Escribir.
2. Depurar.
3. Ejecutar.

## Resumen de la clase

La página de resumen presenta:

| Concepto | Definición utilizada en el material |
| --- | --- |
| .NET | El ecosistema completo de desarrollo. |
| CIL | El lenguaje intermedio y universal. |
| CLR | El motor que ejecuta y gestiona el código. |

## Límites de este apunte

Este documento no incorpora características de .NET que no aparezcan en la presentación. Su propósito es conservar fielmente el nivel y terminología utilizados en la clase.
