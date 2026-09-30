# 17 — Operador de acceso a miembros e invocación de métodos

Apunte derivado exclusivamente del material oficial **Apunte de clases**.

> **Fuente:** `../clases/apunte_clases_operador_punto_parametros.md`

## Operador de punto

En C#, el operador:

```text
.
```

se utiliza para acceder a miembros visibles de un objeto.

Ejemplos conceptuales:

```csharp
cuenta.Saldo
cuenta.Depositar(1000m)
auto.ObtenerEstado()
```

## Sintaxis general

La fuente presenta:

```csharp
identificadorObjeto.NombreMetodo(argumentos);
```

Los componentes son:

```text
identificadorObjeto
        ↓
objeto sobre el que se opera

NombreMetodo
        ↓
comportamiento invocado

argumentos
        ↓
datos enviados al método
```

## Flujo de una llamada

Según la fuente:

```text
flujo principal
     ↓
invocación
     ↓
método
├── parámetros
├── variables locales
└── instrucciones
     ↓
return / fin de void
     ↓
continúa flujo principal
```

## return y void

### return

Permite devolver un valor desde un método.

### void

Indica que el método no retorna un valor.

## Relación con POO

La fuente interpreta la llamada de métodos como una forma de comunicación entre objetos.

En términos utilizados por el material:

```text
objeto
  ↓
operador .
  ↓
miembro visible
```

## Alcance

Este apunte conserva únicamente el modelo explicado en la página de Canvas.
