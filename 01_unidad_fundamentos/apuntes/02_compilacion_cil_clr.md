# 02 — Compilación, CIL y CLR

Apunte derivado exclusivamente de la clase oficial **01S01 — Fundamentos de la Plataforma .NET**.

> **Fuente:** `../clases/01S01_Fundamentos_de_la_Plataforma_.NET.pdf`

## Proceso de compilación presentado

La presentación representa el proceso de esta forma:

```text
Código C#
   ↓
Compilador
   ↓
CIL
```

El punto central de la clase es que **C# no se traduce inmediatamente a lenguaje máquina**.

Primero se compila a **CIL (Common Intermediate Language)**, descrito en la presentación como un lenguaje intermedio y universal.

El material establece una comparación conceptual entre CIL y el **bytecode**.

## CIL — Common Intermediate Language

Dentro del modelo enseñado:

- El compilador transforma el código C# en CIL.
- El CIL funciona como representación intermedia.
- El archivo CIL se presenta como universal.
- La traducción final depende del CLR correspondiente al sistema operativo.

## CLR en acción

La presentación atribuye al CLR tres funciones principales.

### 1. Compilación JIT

**JIT (Just-In-Time)** traduce el CIL a lenguaje máquina en tiempo real.

```text
CIL
 ↓
CLR / JIT
 ↓
Lenguaje máquina
```

### 2. Gestión de memoria

El CLR libera automáticamente la memoria que ya no se utiliza mediante el **Garbage Collector**.

### 3. Seguridad

El material señala que el CLR verifica que el código sea seguro antes de ejecutarlo.

## Portabilidad del CIL

La presentación muestra un mismo archivo CIL relacionado con CLR locales en:

- Windows.
- Linux.
- macOS.

La idea expuesta es:

```text
                 → CLR local → Windows
Archivo CIL ────→ CLR local → Linux
                 → CLR local → macOS
```

El archivo CIL es presentado como universal, mientras que el CLR de cada sistema operativo se encarga de la traducción final.

## Relación entre los conceptos

```text
Código C#
   ↓
Compilador
   ↓
CIL
   ↓
CLR
   ├── Compilación JIT
   ├── Gestión de memoria
   └── Seguridad
   ↓
Ejecución en el sistema operativo
```

## Conceptos que deben distinguirse

| Concepto | Función según el material |
| --- | --- |
| .NET | Ecosistema completo de desarrollo. |
| CIL | Lenguaje intermedio y universal. |
| CLR | Motor que ejecuta y gestiona el código. |
| JIT | Traduce CIL a lenguaje máquina en tiempo real. |
| Garbage Collector | Libera automáticamente memoria que ya no se utiliza. |

## Límites de este apunte

Este resumen reproduce únicamente el modelo presentado en la clase. No agrega detalles internos adicionales sobre compiladores, ensamblados, metadatos, CTS, CLS, versiones de runtime u otros conceptos que el PDF no desarrolla.
