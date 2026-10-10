# 28 — Propiedades completas y modificadores de acceso

**Fuente:** PDF de Semana 8, págs. 4–5. **Aplicación:** Guía de Laboratorio 11.

## Campo privado + propiedad completa

```csharp
private decimal sueldoBase;

public decimal SueldoBase
{
    get { return sueldoBase; }
    set
    {
        if (value < 500000.00m)
            sueldoBase = 500000.00m;
        else
            sueldoBase = value;
    }
}
```

- `get` recupera el campo. `set` aplica la regla antes de modificar el dato.
- `value` representa el valor recibido por el setter.
- La asignación `SueldoBase = sueldoBase;` en el constructor ejecuta la validación.
- El mínimo de $500.000 procede **del ejercicio**, no de una comprobación independiente de la ley.

**Diferencia:** `public string Nombre { get; private set; }` es una propiedad autoimplementada; permite lectura externa y escritura privada, sin una validación personalizada.

## Visibilidad

| Modificador | Alcance |
|---|---|
| `private` | Clase declarante |
| `protected` | Clase declarante y derivadas |
| `internal` | Mismo ensamblado |
| `public` | Acceso público según visibilidad de su tipo |

Canvas exige `protected string Rut { get; set; }`. El código `Program` no puede acceder a `Rut` directamente. La solución permite consultarlo mediante un método público `ObtenerRut()`.

**Material previo relacionado:** `05_encapsulamiento_campos_propiedades.md`, `09_tipos_primitivos_decimal_var.md` y `24_namespaces_using_alias_tipos.md`.
