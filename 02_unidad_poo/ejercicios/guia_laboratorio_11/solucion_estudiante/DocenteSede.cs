namespace IPVG.Sede.Core;

public class DocenteSede : ColaboradorSede
{
    public int HorasOtec { get; set; }

    public DocenteSede(string rut, string nombre, decimal sueldoBase, int horasOtec)
        : base(rut, nombre, sueldoBase)
    {
        HorasOtec = horasOtec;
    }

    public override decimal CalcularSueldoTotal()
    {
        decimal bonoOtec = HorasOtec * 12500.00m;
        return base.CalcularSueldoTotal() + bonoOtec;
    }
}
