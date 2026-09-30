# Apunte de clases — Operador de acceso e intercambio de parámetros

Material oficial transcrito y organizado desde la página **Apunte de clases** publicada en Canvas.

## 1.1 El Operador de Acceso a Miembros (.) e Invocación de Métodos

La fuente presenta el operador de punto:

```text
.
```

como el mecanismo utilizado en C# para acceder a campos, propiedades y métodos visibles de un objeto previamente instanciado.

La sintaxis general indicada es:

```csharp
identificadorObjeto.NombreMetodo(argumentos);
```

El material explica que, al invocar un método:

1. el flujo secuencial se desvía temporalmente hacia el método;
2. se inicializan variables locales y parámetros;
3. el método realiza su trabajo;
4. el flujo retorna mediante `return` o continúa al finalizar un método `void`.

## Acceso a miembros

El operador de punto permite acceder a miembros públicos como:

```csharp
objeto.Propiedad
objeto.Campo
objeto.Metodo()
```

Dentro del enfoque de la fuente, esta interacción se presenta como parte de la comunicación entre objetos.

---

## 1.2 Mecanismos de Paso de Parámetros: por Valor, ref y out

La página distingue tres mecanismos.

### Paso por valor

Es el comportamiento por defecto.

La fuente indica que el método recibe una copia del argumento.

#### Para tipos por valor

Ejemplos mencionados:

- `int`;
- `struct`.

Los cambios realizados dentro del método no afectan la variable original.

#### Para tipos por referencia

La fuente explica que se copia la referencia del objeto. Por ello, el método puede modificar el contenido del objeto compartido, pero no sustituir desde el llamador la variable original por una nueva instancia externa.

## ref

El modificador:

```csharp
ref
```

establece un paso por referencia bidireccional.

La variable usada como argumento:

- debe estar inicializada antes de la llamada;
- puede ser modificada por el método;
- refleja esos cambios directamente en la variable original.

## out

El modificador:

```csharp
out
```

establece un parámetro de salida.

Según la fuente:

- no requiere que la variable argumento esté inicializada previamente;
- el método debe asignar un valor al parámetro antes de terminar;
- se utiliza para obtener múltiples resultados desde un método.

## Comparación

| Mecanismo | Tipo de transferencia | Requisito del argumento | Obligación del método |
| --- | --- | --- | --- |
| Por valor | Copia exacta del valor o referencia. | Debe estar inicializado. | No existe obligación de reasignación. |
| `ref` | Referencia a la variable original. | Debe estar inicializada explícitamente. | Puede modificar o no el parámetro. |
| `out` | Referencia de salida hacia la variable original. | No requiere inicialización previa. | Debe asignar un valor antes de finalizar. |

## Relación con materiales anteriores

Este apunte amplía conceptos ya vistos en:

- tipos por valor y referencia;
- métodos;
- `TryParse` con parámetro `out`;
- objetos compartidos en memoria.

Ahora se formaliza la diferencia entre:

```text
paso por valor
ref
out
```

y se introduce explícitamente el operador de acceso a miembros:

```text
.
```

## Conceptos incorporados

- operador de acceso a miembros `.`;
- invocación de métodos;
- argumentos;
- parámetros;
- `return`;
- `void`;
- paso por valor;
- `ref`;
- `out`;
- requisito de inicialización;
- modificación directa de variables del llamador;
- parámetros de salida.

## Alcance

Este documento conserva la terminología, tabla comparativa y explicación entregadas por la fuente oficial de Canvas. No reemplaza sus descripciones mediante documentación externa.
