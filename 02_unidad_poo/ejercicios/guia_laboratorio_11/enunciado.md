# Guía de Laboratorio 11

**Origen:** enunciado de Canvas proporcionado por el estudiante.

- **Fecha de entrega:** Viernes a las 23:59 (no se aportó fecha de calendario específica).
- **Puntos:** 0.
- **Entregando:** una carga de archivo.

## Desafío Práctico: Sistema Integrado de Personal y Recursos Sede IPVG

### Objetivo del ejercicio

Construir una aplicación de consola en C# usando la CLI de .NET (`SistemaPersonalSede`) para gestionar la nómina de colaboradores y docentes de la sede, aplicando capas lógicas de negocio y encapsulamiento avanzado.

### 1. Estructura de proyecto y namespaces

- Usar **File-Scoped Namespaces**: `namespace IPVG.Sede.Core;` y `namespace IPVG.Sede.App;`.
- En `Program.cs` importar los namespaces necesarios con `using` y crear un **alias de tipo** para `ColaboradorSede`.

### 2. Encapsulamiento y validaciones de estado

- Clase base `ColaboradorSede`: declarar `private decimal sueldoBase;` respaldado por la propiedad completa `SueldoBase`.
- Validar que, si el sueldo ingresado es menor que **$500.000**, se asigne automáticamente $500.000.
- Declarar `protected string Rut { get; set; }` para permitir acceso desde las clases derivadas y restringirlo desde código externo no derivado.

### 3. Herencia y constructores base

- Crear `DocenteSede`, derivada de `ColaboradorSede` mediante `:`.
- Incluir `int HorasOtec { get; set; }`.
- Implementar el constructor con `: base(rut, nombre, sueldoBase)`.
- Crear `CalcularSueldoTotal()` que agrega **$12.500 por hora OTEC dictada** al sueldo base.

### 4. Colecciones dinámicas y menú

- Administrar una `List<ColaboradorSede>` en `Program.cs`.
- Usar `do-while` y `switch` para **registrar docentes**, **listar la nómina** y **calcular el gasto total de sueldos**.

## Referencias

- [Semana 8 — PDF documentado](../../clases/encapsulamiento_y_herencia_en_csharp.md).
- [Solución y trazabilidad](README.md).

**Fidelidad:** «mínimo legal» es el término del enunciado; $500.000 se trata como regla académica sin certificar que sea el mínimo legal vigente. Los archivos `.cs` no son ejemplos oficiales del docente, sino una solución aportada por el estudiante.
