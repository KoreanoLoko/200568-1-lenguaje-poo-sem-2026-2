# 30 — Polimorfismo, despacho dinámico, sobrecarga y sobrescritura

> **Base:** presentación oficial «Arquitectura-Herencia y Polimorfismo», Semana 9, páginas 6–10.  
> **Contexto:** Guía de Laboratorio 12 — Sistema de Gestión de Personal IPVG.

## 1. Por qué una misma operación debe poder variar

Según la presentación, tanto el docente como el administrativo necesitan `MarcarAsistencia()`. Su registro de asistencia, sin embargo, sigue reglas diferentes. En vez de recorrer cada tipo por separado, el sistema utiliza una clase base con un contrato de comportamiento modificable mediante `virtual`.

## 2. Sobrecarga (overload)

Consiste en declarar métodos con **mismo nombre** y distinta cantidad o tipo de parámetros, por ejemplo:

```csharp
void Imprimir(string texto) { }
void Imprimir(int cantidad) { }
```

La elección entre estas firmas se determina de acuerdo con los argumentos en compilación. No es necesario disponer de una jerarquía base/derivada para este ejemplo.

## 3. Sobrescritura (override)

Permite especializar la implementación de un método virtual heredado **manteniendo su firma**:

```csharp
public class Empleado
{
    public virtual string ObtenerFicha() => "Empleado";
}
public class Docente : Empleado
{
    public override string ObtenerFicha() => "Docente";
}
```

El ejemplo anterior es **explicativo y derivado**, no una copia literal del código oficial de Semana 9. En los archivos adjuntos sí figuran `ObtenerFicha()` con `virtual` y `override`.

## 4. Dynamic dispatch y la lista polimórfica

Una `List<ColaboradorSede>` puede almacenar objetos de tipos derivados: docente, administrativo y guardia. En el ciclo:

```csharp
foreach (ColaboradorSede colaborador in nominaSede)
{
    Console.WriteLine(colaborador.ObtenerFicha());
}
```

C# despacha la invocación virtual al método redefinido por **el tipo real del objeto**. Por ello no es necesario inspeccionar explícitamente el tipo del elemento para imprimir una ficha especializada.

## 5. Constructors y reutilización con base

- `: base(rut, nombre, sueldoBase)` inicializa el estado común al construir el derivado.
- `base.ObtenerFicha()` obtiene la ficha común desde el cuerpo del método redefinido y permite agregar la parte de cada rol.

## 6. Cómo se relaciona con la Guía 12

- `DocenteSede`: bono de 12.500 por hora OTEC en el código adjunto.
- `AdministrativoSede`: bono de 25.000 por año de servicio en el código adjunto.
- `GuardiaSede`: **requerido por Canvas pero no adjuntado**; debe incorporar horas extra de 8.500 y eventual bono nocturno fijo de 45.000.
- `ObtenerFicha()` debe tener un método virtual en la base y versiones sobrescritas en derivados, tal como muestran los archivos de docente y administrativo.

**Diferencia de firma a resolver cuando se programe la guía:** Canvas escribe `CalcularSueldoTotal()` para el guardia, mientras el proyecto base adjunto usa `CalcularSueldoLiquido()` como método virtual para la nómina. La documentación deja registrada la discrepancia y **no la corrige en silencio**.

## Relación con clases previas

- [Semana 8](../clases/encapsulamiento_y_herencia_en_csharp.md): herencia, `protected`, `base(...)`, `virtual` y `override`.
- [Apunte 29](29_herencia_base_virtual_override.md): primera aplicación del cálculo polimórfico.
- [Guía 12](../ejercicios/guia_laboratorio_12/README.md): requisitos nuevos y estado real de los archivos.
