# 18 — Paso de parámetros: valor, ref y out

Apunte derivado exclusivamente del material oficial **Apunte de clases**.

> **Fuente:** `../clases/apunte_clases_operador_punto_parametros.md`

## Paso por valor

Es el mecanismo por defecto.

La fuente señala que el método recibe una copia del argumento.

### Con tipos por valor

```text
variable original
      ↓ copia
parámetro
```

Modificar el parámetro no modifica la variable original.

### Con tipos por referencia

La fuente explica que se copia la referencia.

Por ello, el método puede modificar el estado interno del objeto compartido.

## ref

Sintaxis conceptual:

```csharp
Metodo(ref variable);
```

Características señaladas:

- la variable debe estar inicializada;
- el método recibe acceso por referencia;
- puede modificar directamente la variable original.

## out

Sintaxis conceptual:

```csharp
Metodo(out variable);
```

Características:

- no necesita valor inicial;
- el método debe asignarle un valor antes de terminar;
- permite obtener resultados adicionales.

## Comparación resumida

| Mecanismo | ¿Requiere valor inicial? | ¿El método debe asignar? | ¿Puede cambiar la variable original? |
| --- | ---: | ---: | ---: |
| Valor | Sí | No | No para tipos por valor |
| `ref` | Sí | No | Sí |
| `out` | No | Sí | Sí |

## Relación con TryParse

Materiales anteriores mostraron:

```csharp
decimal.TryParse(entrada, out numeroLeido)
```

Este nuevo apunte permite interpretar formalmente `out numeroLeido` como un parámetro de salida que el método debe asignar.

## Diferencia conceptual ref vs. out

```text
ref
→ entra con un valor
→ puede salir modificado

out
→ puede entrar sin valor
→ debe salir con un valor asignado
```

## Conceptos habilitados

A partir de esta fuente ya forman parte explícita de la asignatura:

- paso por valor;
- `ref`;
- `out`;
- variables argumento;
- parámetros;
- requisitos de inicialización;
- salida múltiple de métodos.

## Alcance

Este apunte no agrega ejemplos de implementación que la fuente no haya mostrado.
