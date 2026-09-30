# Certamen 1 — Caso de Estudio: Sistema de Préstamos de Notebooks Sede IPVG

Material oficial transcrito desde Canvas para la asignatura **Lenguaje de Programación Orientado al Objeto**.

## Contexto

La biblioteca de la sede administra un inventario de computadores portátiles para préstamos presenciales a estudiantes.

Se solicita construir una aplicación de consola en C# utilizando programación orientada a objetos sobre .NET.

## 1. Atributos y Encapsulación de Instancia

Crear la clase:

```csharp
NotebookSede
```

Cada préstamo debe almacenar:

- nombre del estudiante;
- identificador físico del notebook;
- minutos de retraso en la devolución.

Las propiedades públicas deben proteger la escritura mediante:

```csharp
private set;
```

## 2. Miembros Estáticos de la Sede

La clase debe mantener:

```csharp
notebooksDisponiblesSede
```

como entero inicializado en:

```text
15
```

y:

```csharp
montoMultasRecaudadas
```

como `decimal` inicializado en:

```csharp
0.00m
```

## 3. Sobrecarga de Constructores

### Constructor 1

Debe recibir:

- nombre del estudiante;
- identificador del equipo.

Los minutos de retraso deben iniciar en cero.

### Constructor 2

Debe recibir:

- nombre del estudiante;
- identificador del equipo;
- minutos iniciales de retraso.

## 4. Método ProcesarDevolucion

Debe crearse un método de instancia llamado:

```csharp
ProcesarDevolucion
```

con los siguientes parámetros:

- `int minutosRealesUso`;
- `ref int stockSede`;
- `out decimal multaCalculada`.

El método debe retornar:

```csharp
bool
```

### Regla de negocio

Si los minutos de retraso acumulados son mayores que cero:

```text
multa = minutos de retraso × $120.00
```

Al finalizar exitosamente:

1. incrementar el stock físico mediante `ref`;
2. sumar la multa calculada al acumulador estático de la sede;
3. retornar un valor booleano de éxito.

## 5. Menú Interactivo

`Program.cs` debe utilizar:

- `do-while`;
- `switch`.

Opciones requeridas:

```text
[1] Registrar un Nuevo Préstamo de Notebook
[2] Procesar Devolución del Notebook
[3] Visualizar Estadísticas del Stock e Ingresos de la Sede
[4] Salir de la aplicación
```

## Conceptos evaluados

- C# / .NET;
- `decimal` para dinero;
- encapsulación;
- propiedades `get; private set;`;
- miembros de instancia;
- miembros `static`;
- sobrecarga de constructores;
- `ref`;
- `out`;
- retorno `bool`;
- `do-while`;
- `switch`;
- métodos de instancia;
- métodos estáticos;
- acumuladores globales.

## Solución entregada

La solución proporcionada junto con este material se conserva en:

```text
solucion_entregada/
├── NotebookSede.cs
└── Program.cs
```

## Observaciones de fidelidad

- El enunciado nombra el parámetro de entrada de `ProcesarDevolucion` como `minutosRealesUso`.
- La solución entregada utiliza el nombre `minutosRetraso` en la firma.
- La rúbrica menciona como ejemplo una propiedad `EstaDevuelto`, aunque esa propiedad no aparece en las especificaciones del caso entregadas aquí.
- La rúbrica también contiene una referencia a una posible multa “por días de exceso”, mientras que el enunciado define la multa por **minutos** de retraso.

Estas diferencias se conservan como parte del registro de la fuente y no se corrigen silenciosamente.
