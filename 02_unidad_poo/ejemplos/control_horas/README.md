# ControlHoras — ejemplo oficial

Material derivado del archivo **ControlHoras.zip** publicado en Canvas.

> **Fuente original prevista en el repositorio:** `02_unidad_poo/ejemplos/control_horas/ControlHoras.zip`

## Relación con la materia

Este ejemplo implementa en código el desafío de control de horas presentado previamente en el material **Anatomía de Clases, Puntos de Entrada y Memoria en C#**.

El programa utiliza:

- una clase `Colaborador`;
- un `struct RegistroHoras`;
- propiedades;
- una propiedad con campo de respaldo;
- un método que recibe un `RegistroHoras` como parámetro;
- una variable local;
- `this` para distinguir el miembro de la instancia;
- creación de objetos con `new`;
- inicializadores de objeto;
- acumulación de horas;
- interpolación de cadenas.

## Archivo analizado

El archivo recibido y conservado es:

`Program.cs`

No se recibió el contenido completo del ZIP ni archivos como `.csproj`, por lo que esta documentación se limita al código fuente disponible.

## Namespace

El programa utiliza:

```csharp
namespace ControlHoras
```

## Clase Colaborador

La clase contiene:

```csharp
public string Nombre { get; set; }
public string Cargo { get; set; }
```

y una propiedad `TotalHoras` respaldada por un campo privado:

```csharp
public int TotalHoras
{
    get => totalHoras;
    set => totalHoras = value;
}

private int totalHoras = 0;
```

### Campo de respaldo

`totalHoras` mantiene el valor interno utilizado por la propiedad `TotalHoras`.

### Método registrarJornada

El método recibe un registro de horas:

```csharp
public void registrarJornada(RegistroHoras registro)
```

Dentro del método se declara una variable local con el mismo nombre base que el campo:

```csharp
int totalHoras = 0;
```

Luego se copia en ella el valor del registro:

```csharp
totalHoras = registro.Horas;
```

y se acumula en la propiedad de la instancia:

```csharp
this.TotalHoras += totalHoras;
```

Este fragmento permite observar la diferencia entre:

- la variable local `totalHoras`;
- el estado del objeto accesible mediante `this.TotalHoras`.

> Nota de fidelidad: el comentario del código fuente menciona `this.totalHoras`, mientras que la instrucción ejecutada utiliza `this.TotalHoras`. El repositorio conserva el código exactamente como fue proporcionado.

## struct RegistroHoras

El tipo por valor contiene:

```csharp
public struct RegistroHoras
{
    public string Dia { get; set; }
    public int Horas { get; set; }
}
```

Representa un registro individual de jornada compuesto por:

- día;
- cantidad de horas.

## Ejecución en Main

El programa crea un colaborador:

```csharp
Colaborador gerente = new Colaborador();
gerente.Nombre = "Alan Brito";
gerente.Cargo = "Finanzas";
```

Luego registra dos jornadas.

### Lunes

```csharp
RegistroHoras nuevoRegistro = new RegistroHoras
{
    Dia = "lunes",
    Horas = 5
};

gerente.registrarJornada(nuevoRegistro);
```

### Martes

```csharp
nuevoRegistro = new RegistroHoras
{
    Dia = "martes",
    Horas = 8
};

gerente.registrarJornada(nuevoRegistro);
```

## Acumulación esperada según el código

```text
5 horas
+ 8 horas
---------
13 horas
```

Por lo tanto, el valor final de:

```csharp
gerente.TotalHoras
```

es `13`.

La salida final construida por el programa es:

```text
Aquí empieza el trabajo:
El Total de horas trabajasas por Alan Brito es 13
```

La palabra `trabajasas` se conserva porque aparece así en el código fuente original.

## Flujo conceptual

```text
Colaborador gerente
      │
      ├── Nombre = "Alan Brito"
      ├── Cargo = "Finanzas"
      └── TotalHoras = 0
               │
               ├── RegistroHoras("lunes", 5)
               │          ↓
               │   registrarJornada()
               │          ↓
               │      TotalHoras = 5
               │
               └── RegistroHoras("martes", 8)
                          ↓
                   registrarJornada()
                          ↓
                     TotalHoras = 13
```

## Conceptos que consolida

- `class`;
- `struct`;
- propiedades autoimplementadas;
- propiedad con campo de respaldo;
- `get` y `set`;
- campo privado;
- variable local;
- alcance de variables;
- `this`;
- métodos con parámetros;
- inicializadores de objeto;
- acumulación mediante `+=`;
- instanciación con `new`;
- interpolación de cadenas;
- punto de entrada clásico con `Main`.

## Relación con otras fuentes del repositorio

Este ejemplo complementa:

- `02_unidad_poo/ejercicios/desafio_sistema_recursos_humanos/enunciado.md`;
- `02_unidad_poo/apuntes/02_clases_objetos_instanciacion.md`;
- `02_unidad_poo/apuntes/05_encapsulamiento_campos_propiedades.md`;
- `02_unidad_poo/apuntes/06_experimento_copia_struct_class.md`.

## Alcance

Este documento describe el comportamiento del `Program.cs` proporcionado. No modifica ni corrige el código oficial y no presupone el contenido de los demás archivos del ZIP.
