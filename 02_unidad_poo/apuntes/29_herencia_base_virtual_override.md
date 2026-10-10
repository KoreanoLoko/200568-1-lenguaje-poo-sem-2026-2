# 29 — Herencia, constructor base y polimorfismo

**Fuente:** Semana 8, págs. 9–13. **Caso:** Guía de Laboratorio 11.

## DRY y relación Is-A

La fuente presenta la duplicación de RUT, nombre y sueldo en cada rol como problema de mantenimiento. Una clase base agrupa lo común. La derivada añade lo particular.

```csharp
public class DocenteSede : ColaboradorSede
{
    public int HorasOtec { get; set; }
}
```

La relación «un docente **es un** colaborador» habilita guardar instancias de `DocenteSede` en `List<ColaboradorSede>`.

## Constructor padre

```csharp
public DocenteSede(string rut, string nombre,
                   decimal sueldoBase, int horasOtec)
    : base(rut, nombre, sueldoBase)
{
    HorasOtec = horasOtec;
}
```

`base(...)` invoca el constructor superior. `this(...)` invocaría otro constructor de la misma clase.

## Método virtual y especialización

```csharp
// ColaboradorSede
public virtual decimal CalcularSueldoTotal() { return SueldoBase; }

// DocenteSede
public override decimal CalcularSueldoTotal()
{
    decimal bonoOtec = HorasOtec * 12500.00m;
    return base.CalcularSueldoTotal() + bonoOtec;
}
```

Sueldo docente = sueldo base validado + horas OTEC × $12.500.

## Despacho polimórfico

```csharp
foreach (ColaboradorSede colaborador in nomina)
{
    gastoTotal += colaborador.CalcularSueldoTotal();
}
```

Si el objeto real es `DocenteSede`, se ejecuta el método sobrescrito aunque el elemento del `foreach` esté declarado `ColaboradorSede`.

**Ejemplo:** $450.000 ingresados se ajustan a $500.000; cuatro horas generan $50.000 de bono; el total es $550.000.

**Alcance:** el PDF ilustra también personal administrativo y directivo, pero la guía solo exige docentes.
