using System;

namespace IPVG.Sede.Core;

public class ColaboradorSede
{
    private decimal sueldoBase;

    protected string Rut { get; set; }

    public string Nombre { get; private set; }

    public decimal SueldoBase
    {
        get
        {
            return sueldoBase;
        }
        set
        {
            if (value < 500000.00m)
            {
                sueldoBase = 500000.00m;
            }
            else
            {
                sueldoBase = value;
            }
        }
    }

    public ColaboradorSede(string rut, string nombre, decimal sueldoBase)
    {
        Rut = rut;
        Nombre = nombre;
        SueldoBase = sueldoBase;
    }

    public string ObtenerRut()
    {
        return Rut;
    }

    public virtual decimal CalcularSueldoTotal()
    {
        return SueldoBase;
    }
}
