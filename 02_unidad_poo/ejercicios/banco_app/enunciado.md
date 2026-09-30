# BancoApp — Menú de Cuenta Bancaria

Enunciado derivado exclusivamente del PDF **Tipos primitivos y clases en C#**.

## Objetivo

Construir el método `Main` para operar una instancia de `CuentaBancaria` mediante la consola.

## Menú requerido

```text
--- MENÚ CAJERO ---

1. Depositar
2. Retirar
3. Ver Saldo
4. Salir

Ingrese su opción:
```

## Restricción principal

La aplicación debe permanecer en ejecución hasta que el usuario seleccione:

```text
4
```

## Arquitectura esperada

La presentación propone:

```text
Instanciar CuentaBancaria
          ↓
do
{
    imprimir menú
    leer Console.ReadLine()

    switch(opcion)
    {
        Depositar()
        Retirar()
        leer Saldo
    }
}
while (opcion != "4");
```

## Elementos que deben utilizarse según la fuente

- creación de una instancia de `CuentaBancaria`;
- consola;
- `Console.ReadLine()`;
- `do-while`;
- `switch`;
- `Depositar()`;
- `Retirar()`;
- lectura del saldo;
- opción 4 para finalizar.

## Entrega indicada

La diapositiva final solicita:

> Cargar el código BancoApp al repositorio antes de la próxima sesión (Semana 4).

## Regla de documentación

Este archivo contiene solo el **enunciado y arquitectura oficial**. La solución deberá mantenerse separada:

```text
banco_app/
├── enunciado.md
└── solucion/
    └── ...
```

## Alcance

El PDF no entrega el código completo de `Main`, por lo que este archivo no inventa una implementación.
