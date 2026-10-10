# Guía 11 — SistemaPersonalSede: respaldo del estudiante

## Procedencia

- Enunciado: [enunciado.md](enunciado.md), transcrito de Canvas.
- PDF docente: [documentación de la Semana 8](../../clases/encapsulamiento_y_herencia_en_csharp.md).
- Código adjunto por el estudiante: `solucion_estudiante/ColaboradorSede.cs`, `solucion_estudiante/DocenteSede.cs`, `solucion_estudiante/Program.cs`.
- Nombre de proyecto exigido y utilizado localmente: `SistemaPersonalSede`.
- Archivo recibido `Program(4).cs` normalizado a `Program.cs` para el respaldo, **sin modificaciones funcionales**.

## Arquitectura y cumplimiento

| Archivo | Namespace | Implementación |
|---|---|---|
| `ColaboradorSede.cs` | `IPVG.Sede.Core` | Clase base, RUT `protected`, nombre, campo privado, propiedad completa `SueldoBase`, `ObtenerRut()` y método `virtual` |
| `DocenteSede.cs` | `IPVG.Sede.Core` | Herencia `: ColaboradorSede`, `HorasOtec`, constructor `base(...)`, método `override` con bono |
| `Program.cs` | `IPVG.Sede.App` | `using`, alias, `List<ColaboradorSede>`, `Add`, `Count`, `foreach`, `do-while`, `switch` |

## Reglas de negocio implementadas

1. Si el sueldo base es inferior a $500.000, la propiedad lo ajusta a $500.000.
2. Bono OTEC = `HorasOtec * 12500.00m`.
3. Sueldo total = sueldo base ajustado + bono OTEC.
4. RUT y nombre vacíos o solo con espacios se rechazan.
5. `decimal.TryParse` valida el sueldo y `int.TryParse` verifica las horas; las horas negativas se rechazan al registrar.
6. La nómina se conserva en memoria mientras está abierto el programa.
7. El cálculo de gasto recorre todos los colaboradores y utiliza el método virtual para obtener el sueldo de cada tipo concreto.

## Pruebas y evidencia

El estudiante **informó haber realizado correctamente las pruebas funcionales** desde Visual Studio y mostró la consola abierta con el menú. No se adjuntan informes automatizados de pruebas, logs completos ni `.csproj`, por lo que no se afirma una compilación independiente por parte del repositorio.

| Caso | Entradas | Resultado esperado |
|---|---|---|
| Nómina vacía | Opción 2, sin registros | Mensaje «No hay colaboradores registrados» |
| Gasto vacío | Opción 3, sin registros | $0 |
| Ajuste mínimo | Sueldo $450.000, 4 horas OTEC | Base $500.000 + bono $50.000 = $550.000 |
| Sueldo normal | Sueldo $720.000, 2 horas OTEC | $745.000 |
| Dos docentes | Opción 3 con ambos registros | $1.295.000 |
| Sueldo inválido | Texto en lugar de número | Mensaje de error, sin agregar |
| Horas inválidas | -3 | Mensaje de error, sin agregar |

La salida `:N0` muestra números sin decimales y sus separadores dependen de la configuración regional.

## Límites del ejercicio, no agregados a la solución

- No hay almacenamiento persistente ni control de RUT duplicados.
- `HorasOtec { get; set; }` tiene escritura pública, tal como lo pide la guía; un código externo podría asignar horas negativas aunque la interfaz de consola las rechace.
- El RUT no tiene validación del dígito verificador.
- Solo se registran docentes; la presentación docente introduce otros roles de manera conceptual.
- Los tres `.cs` son un respaldo del código compartido; se debe conservar el proyecto local completo (incluido `.csproj`) para Canvas.

## Ejecución con SDK .NET desde el proyecto real

```powershell
dotnet build
dotnet run
```

## Materia vinculada

- [Apunte 28: Encapsulación y propiedades](../../apuntes/28_propiedades_completas_modificadores_acceso.md).
- [Apunte 29: Herencia y polimorfismo](../../apuntes/29_herencia_base_virtual_override.md).

**PDF original disponible en el repositorio:** [Encapsulamiento_y_Herencia_en_C.pdf](../../clases/Encapsulamiento_y_Herencia_en_C.pdf).
