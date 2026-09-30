# Ejemplo — Campus Inteligente / Sistema Integrado de Lockers

Este directorio conserva los archivos fuente adjuntos entregados junto al material de **Arquitectura de Software para un Campus Inteligente**.

## Archivos

```text
campus_inteligente_lockers/
├── README.md
├── Locker.cs
└── Program.cs
```

## Relación con otros materiales

Este ejemplo se relaciona directamente con:

- `02_unidad_poo/clases/arquitectura_campus_inteligente.md`
- `02_unidad_poo/ejercicios/guia_laboratorio_10/`
- `02_unidad_poo/apuntes/25_list_foreach_add_find_lambda.md`
- `02_unidad_poo/apuntes/26_arquitectura_modular_campus_inteligente.md`
- `02_unidad_poo/apuntes/27_array_arraylist_list_genericos.md`

## Locker.cs

El archivo adjunto coincide funcionalmente con el `Locker.cs` preservado en la Guía de Laboratorio 10.

Contiene:

- file-scoped namespace `IPVG.Sede.Equipamiento`;
- acumulador estático `recaudoTotalSede`;
- propiedades encapsuladas con `private set`;
- constructor con tarifa por defecto mediante operador ternario;
- método `Arrendar(..., out decimal cobro)`;
- método estático `ObtenerRecaudoGlobal()`;
- método `ObtenerFicha()`.

## Program.cs

El archivo adjunto es una variante muy cercana al `Program.cs` de la Guía de Laboratorio 10.

Mantiene:

- `List<CasilleroSede>`;
- alias de tipo para `Locker`;
- `foreach`;
- `List.Add()`;
- `List.Find()`;
- expresión lambda;
- `out decimal cobro`;
- menú `do-while` + `switch`.

### Diferencias relevantes frente al Program.cs preservado en la Guía 10

La variante adjunta utiliza nombres más descriptivos en la búsqueda:

```csharp
int codigoABuscar
CasilleroSede casilleroEncontrado
elCodigo => elCodigo.NumeroLocker == codigoABuscar
```

en lugar de identificadores abreviados.

Además agrega esta salida después del arriendo:

```csharp
Console.WriteLine(
    $"Total recaudado hasta ahora es ${Locker.ObtenerRecaudoGlobal():N2}");
```

Esto conecta explícitamente el menú con el acumulador estático global de `Locker`.

## Conservación de la fuente

Los archivos se preservan como material adicional y **no reemplazan** el ejemplo oficial de la Guía de Laboratorio 10.

El archivo descargado como `Program(3).cs` se normaliza en el repositorio a `Program.cs`, manteniendo su contenido.
