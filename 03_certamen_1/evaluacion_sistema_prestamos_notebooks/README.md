# Certamen 1 — Sistema de Préstamos de Notebooks

Carpeta de evaluación asociada al caso práctico **Sistema de Préstamos de Notebooks Sede IPVG**.

## Contenido

```text
evaluacion_sistema_prestamos_notebooks/
├── README.md
├── enunciado.md
├── rubrica.md
└── solucion_entregada/
    ├── NotebookSede.cs
    └── Program.cs
```

## Fuente

El enunciado y la rúbrica fueron proporcionados desde Canvas.

Los archivos `NotebookSede.cs` y `Program.cs` corresponden a la solución adjunta junto con este material y se conservan sin reescritura funcional.

## Relación con la materia

Este certamen integra contenidos desarrollados previamente en:

- encapsulación;
- miembros de instancia y `static`;
- constructores y sobrecarga;
- `decimal`;
- `ref`;
- `out`;
- retorno `bool`;
- `do-while`;
- `switch`;
- estadísticas globales.

## Trazabilidad de la solución entregada

### NotebookSede.cs

La clase contiene:

- `notebooksDisponiblesSede = 15`;
- `montoMultasRecaudadas = 0.00m`;
- propiedades con `private set`;
- dos constructores;
- `ProcesarDevolucion(...)`;
- `ObtenerEstadisticasGlobales()`.

### Program.cs

El punto de entrada contiene:

- referencia de préstamo activo;
- variable local `stockSede = 15`;
- menú `do-while`;
- `switch` con cuatro opciones;
- registro de préstamo;
- procesamiento de devolución;
- estadísticas globales;
- salida mediante opción 4.

## Alcance

Esta carpeta conserva la evaluación y la solución proporcionada. No asigna puntaje ni corrige automáticamente la entrega.
