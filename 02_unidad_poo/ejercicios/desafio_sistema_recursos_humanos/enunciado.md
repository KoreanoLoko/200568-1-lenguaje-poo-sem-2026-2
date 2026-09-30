# Desafío de Ingeniería — Sistema de Recursos Humanos

Enunciado derivado exclusivamente del PDF **Anatomía de Clases, Puntos de Entrada y Memoria en C#**.

## Modalidad indicada

- **Trabajo:** individual.
- **Tiempo:** 40 minutos.

## Contexto

Diseñar el núcleo de un sistema de control de horas para una organización.

## Requerimientos estrictos

1. Crear una clase `Colaborador`, tratada por el material como tipo por referencia.
2. Crear un `struct RegistroHoras`, tratado como tipo por valor.
3. La clase `Colaborador` debe tener propiedades autoimplementadas para:
   - `Nombre`;
   - `Cargo`.
4. La clase `Colaborador` debe incluir el método:

```csharp
RegistrarJornada(RegistroHoras registro)
```

## Arquitectura esperada

La diapositiva siguiente muestra el siguiente diseño esquemático.

### RegistroHoras

```text
«Struct» RegistroHoras
----------------------
string Dia
int Horas
```

### Colaborador

```text
«Class» Colaborador
-------------------
string Nombre
string Cargo
int TotalHoras
-------------------
RegistrarJornada()
```

La presentación muestra una relación entre `RegistroHoras` y `Colaborador`.

## Conceptos que el desafío busca aplicar

- definición de `struct`;
- definición de `class`;
- propiedades;
- tipos por valor;
- tipos por referencia;
- métodos con parámetros;
- modelado de entidades para una organización.

## Regla de documentación

Este archivo contiene únicamente el **enunciado oficial**. La solución deberá mantenerse separada, por ejemplo:

```text
desafio_sistema_recursos_humanos/
├── enunciado.md
└── solucion/
    └── ...
```

## Alcance

El PDF no entrega en las páginas analizadas una implementación completa del desafío, por lo que este archivo no inventa una solución.
