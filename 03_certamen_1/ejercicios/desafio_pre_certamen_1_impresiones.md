# Desafío de Preparación — Pre-Certamen 1: Sistema de Impresiones

Fuente: **Guía de Laboratorio 07**.

## Contexto

La guía indica que este desafío se utiliza como entrenamiento para el Certamen 1 de la semana siguiente.

Debe extenderse el proyecto de `CuentaImpresion` trabajado en la Guía de Laboratorio 07.

## Requisito 1 — Contador global

Agregar en la clase:

```csharp
static int totalTrabajosSede
```

El valor debe incrementarse cada vez que un proceso de impresión sea exitoso.

## Requisito 2 — Método estático de información global

La captura de Canvas muestra literalmente:

```csharp
public static void MostrarInfoIglobal()
```

El método debe imprimir el acumulado de trabajos que todos los estudiantes han impreso en la sede.

> **Nota de fidelidad:** se mantiene `MostrarInfoIglobal()` tal como aparece visualmente en Canvas. Este archivo no corrige el nombre ni implementa la solución.

## Conceptos que evalúa

- miembros `static`;
- estado compartido a nivel de clase;
- incremento de contador;
- método estático;
- combinación con métodos de instancia;
- integración con `ProcesarImpresion`;
- aplicación de lógica solo cuando la impresión resulta exitosa.

## Regla de trabajo

Este archivo contiene únicamente el desafío oficial. La solución debe mantenerse separada si posteriormente se desarrolla:

```text
03_certamen_1/ejercicios/
├── desafio_pre_certamen_1_impresiones.md
└── solucion_desafio_impresiones/
    └── ...
```
