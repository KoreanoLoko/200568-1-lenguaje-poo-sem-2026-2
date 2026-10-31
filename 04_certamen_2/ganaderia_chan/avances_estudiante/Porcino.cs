using System;

// TODO 8: Asignar al espacio de nombres GanaderiaChan.Core
namespace GanaderiaChan.Core;
public class Porcino : AnimalGanado
{
    public string TipoAlimentacion { get; set; } // "PASTOREO" u "INTENSIVA"
    public int CantidadLechones { get; set; }

    // TODO 9: Constructor invocando a : base(...)
    public Porcino(string codigo, string raza, decimal peso, string tipoAlimentacion, int cantidadLechones) : base(codigo, raza, peso)
    {
        TipoAlimentacion = !string.IsNullOrWhiteSpace(tipoAlimentacion) ? tipoAlimentacion.ToUpper() : "INTENSIVA";
        CantidadLechones = cantidadLechones >= 0 ? cantidadLechones : 0;
    }

    // TODO 10: Sobrescribir CalcularValorComercial()
    //Calcula la tasación a $1.800m por kg.
    //Aplica un recargo del 15% si la alimentación
    //es de "PASTOREO" y suma un bono
    //reproductor fijo de +$80.000m si la camada es
    //mayor a 5 lechones.
    public override decimal CalcularValorComercial()
    {
        decimal valor = PesoKilos * 1800m;
        if (TipoAlimentacion == "PASTOREO")
            valor = valor * 1.15m;

        if (CantidadLechones > 5)
            valor += 80000m;

        return valor;
    }

    public override string ObtenerFicha()
    {
        return $"{base.ObtenerFicha()} | Porcino ({TipoAlimentacion}) [Lechones: {CantidadLechones}] -> Valor: ${CalcularValorComercial():N2}";
    }
}
