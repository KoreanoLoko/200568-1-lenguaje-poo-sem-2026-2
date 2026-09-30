# 19 — Métodos, mensajería, firma y retorno

Apunte derivado exclusivamente del PDF **Invocacion y mensajeria y constructores.pdf**.

> **Fuente:** `../clases/Invocacion y mensajeria y constructores.pdf`

## Estado vs. comportamiento

La presentación separa:

```text
Objeto
├── estado
└── comportamiento
```

Los métodos representan acciones que el objeto puede ejecutar.

## Mensajería

La fuente utiliza la idea de que los objetos se comunican mediante mensajes, que en C# se materializan como llamadas a métodos.

## Operador punto

Ejemplo:

```csharp
miCuenta.Imprimir();
```

El punto conecta:

```text
objeto . miembro
```

## Firma de un método

Ejemplo oficial:

```csharp
public void CargarPapel(int cantidadHojas)
```

| Parte | Significado en la fuente |
| --- | --- |
| `public` | visibilidad |
| `void` | tipo de retorno |
| `CargarPapel` | nombre del método |
| `int cantidadHojas` | parámetro |

## Convención de nombre

La presentación indica utilizar **PascalCase** para métodos.

## void y return

```text
void
→ ejecuta una acción
→ no devuelve un dato

tipo + return
→ procesa
→ devuelve un dato al llamador
```

## Alcance

Este apunte reproduce únicamente el contenido del Bloque 1 del PDF.
