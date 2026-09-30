# Guía de Laboratorio 06

Material oficial transcrito desde la tarea **Guía de Laboratorio 06** publicada en Canvas para la asignatura.

## Datos de la actividad

- **Fecha de entrega:** no hay fecha de entrega.
- **Puntos:** 0.
- **Tipo de entrega:** cuadro de entrada de texto.
- **Calificación:** la tarea no cuenta para la calificación final.

## 1. Caso Práctico: Gestión de Estacionamiento

La guía plantea un sistema de consola para administrar el flujo diario de vehículos en un estacionamiento.

El sistema debe:

- registrar individualmente cada vehículo;
- acumular minutos de permanencia;
- calcular un cobro personalizado;
- mantener un total global recaudado;
- contabilizar vehículos estacionados simultáneamente.

## Especificaciones técnicas

| Categoría | Miembro de Instancia | Miembro Estático |
| --- | --- | --- |
| Datos / Estado | `Patente` (`string`), `MinutosTranscurridos` (`int`), `EstaPagado` (`bool`) | `tarifaPorMinuto` (`decimal` = 25.00), `totalRecaudadoGlobal` (`decimal`), `vehiculosEstacionadosActualmente` (`int`) |
| Comportamientos | `RegistrarPasoDelTiempo(int)`, `ProcesarSalida() : decimal`, `ObtenerEstado() : string` | `ObtenerEstadisticasGlobales() : void` |

## Uso de decimal

La guía establece que las variables financieras deben utilizar:

```csharp
decimal
```

y muestra el sufijo:

```csharp
25.00m
```

como forma de inicializar un literal decimal.

El material contrapone este tipo con `double` por razones de precisión financiera.

## 2. Construcción del proyecto

La guía solicita:

1. Crear un proyecto de consola.
2. Crear `VehiculoEstacionado.cs` en la raíz del proyecto.
3. Reemplazar el contenido de `Program.cs` por el flujo de simulación entregado.

Los dos archivos oficiales se conservan en:

```text
ejemplo_oficial/
├── VehiculoEstacionado.cs
└── Program.cs
```

## Clase VehiculoEstacionado

### Miembros estáticos

```csharp
private static decimal tarifaPorMinuto = 25.00m;
private static decimal totalRecaudadoGlobal = 0.00m;
private static int vehiculosEstacionadosActualmente = 0;
```

Representan información compartida entre todas las instancias.

### Miembros de instancia

```csharp
public string Patente { get; }
public int MinutosTranscurridos { get; private set; }
public bool EstaPagado { get; private set; }
```

Cada objeto mantiene su propio estado.

## Constructor

```csharp
public VehiculoEstacionado(string patente)
```

La guía utiliza:

```csharp
Patente = patente.ToUpper();
MinutosTranscurridos = 0;
EstaPagado = false;
vehiculosEstacionadosActualmente++;
```

Así, al crear cada objeto:

- la patente se normaliza a mayúsculas;
- el tiempo comienza en cero;
- el vehículo inicia como no pagado;
- aumenta el contador global de vehículos activos.

## RegistrarPasoDelTiempo

```csharp
public void RegistrarPasoDelTiempo(int minutos)
```

Si el valor es mayor que cero:

```csharp
MinutosTranscurridos += minutos;
```

## ProcesarSalida

```csharp
public decimal ProcesarSalida()
```

El método primero evita un doble cobro:

```csharp
if (EstaPagado)
{
    return 0.00m;
}
```

Luego calcula:

```csharp
decimal costoServicio = MinutosTranscurridos * tarifaPorMinuto;
```

y actualiza:

- `EstaPagado = true`;
- `vehiculosEstacionadosActualmente--`;
- `totalRecaudadoGlobal += costoServicio`.

Finalmente retorna el costo del servicio.

## ObtenerEstado

La guía utiliza el operador condicional:

```csharp
EstaPagado ? "PAGADO" : "ACTIVO EN SEDE"
```

y devuelve una cadena interpolada con patente, tiempo y estado.

## ObtenerEstadisticasGlobales

El método estático imprime:

- vehículos actualmente estacionados;
- total global recaudado;
- tarifa vigente por minuto.

Los valores monetarios utilizan formato:

```csharp
:N2
```

## Simulación en Program.cs

La guía crea tres instancias:

```csharp
VehiculoEstacionado auto1
VehiculoEstacionado auto2
VehiculoEstacionado auto3
```

con las patentes:

- `KCDD-54`;
- `PJYT-89`;
- `LKWQ-12`.

### Flujo simulado

- `auto1`: 45 minutos;
- `auto2`: 120 minutos;
- `auto3`: 15 minutos.

Luego:

1. se consulta el estado particular de `auto2`;
2. se procesan las salidas de `auto1` y `auto3`;
3. se consultan estadísticas globales;
4. se intenta procesar nuevamente la salida de `auto1`;
5. se agregan 40 minutos adicionales a `auto2`;
6. se procesa la salida de `auto2`;
7. se muestran estadísticas de cierre.

## 3. Preguntas de Autoevaluación Metacognitiva

La guía solicita analizar:

1. por qué atributos particulares como `Patente` pertenecen a cada objeto, mientras `tarifaPorMinuto` corresponde a un miembro único de clase;
2. por qué `double` puede producir problemas en acumulaciones financieras frente al uso de `decimal`.

## Conceptos incorporados o reforzados

- miembros de instancia;
- miembros estáticos;
- estado global compartido;
- `decimal`;
- sufijo `m`;
- `ToUpper()`;
- propiedades con `private set`;
- contador estático;
- `++` y `--`;
- prevención de doble procesamiento;
- operador ternario `?:`;
- retorno `decimal`;
- formato numérico `:N2`;
- simulación con múltiples objetos independientes.

## Alcance

Este archivo conserva el enunciado, código y modelo conceptual de la guía. No agrega respuestas a las preguntas metacognitivas ni corrige el modelo pedagógico mediante fuentes externas.
