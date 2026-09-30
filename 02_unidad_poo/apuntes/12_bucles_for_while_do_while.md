# 12 — Bucles: for, while y do-while

Apunte derivado exclusivamente del PDF **Tipos primitivos y clases en C#**.

> **Fuente:** `../clases/Tipos primitivos y clases en C#.pdf`

## for

La fuente lo presenta como una estructura de **iteración contada**.

Se utiliza cuando conocemos de antemano cuántas veces se repetirá el ciclo.

## while

La fuente lo presenta como una estructura de **condición primero**.

La condición se evalúa antes de ejecutar el bloque.

Por lo tanto, según el material, puede ejecutarse cero veces si la condición inicial es falsa.

## do-while

La fuente lo presenta como una estructura de **ejecución primero**.

El bloque se ejecuta antes de comprobar la condición.

Por ello garantiza al menos una ejecución.

## Comparación conceptual

```text
for
→ cantidad de repeticiones conocida

while
→ condición primero

do-while
→ ejecución primero
```

## Uso destacado en la materia

El PDF utiliza `do-while` como base para construir un menú interactivo de consola:

```text
do
{
    mostrar menú
    capturar opción
    ejecutar acción
}
while (opcion != "4");
```

## Relación con switch

En el ejemplo de BancoApp:

```text
do-while
   ↓
mantiene vivo el menú

switch
   ↓
elige qué operación ejecutar
```

## Alcance

Este apunte registra la comparación y uso indicados por la presentación, sin agregar variantes de sintaxis no mostradas.
