using System;

// TODO 5: Asignar al espacio de nombres GanaderiaChan.Core

public class Bovino
{
    public string TipoProduccion { get; set; } // "CARNE" o "LECHE"
    public bool EsPedigree { get; set; }

    // TODO 6: Constructor invocando a : base(...)
    public Bovino(string codigo, 
        string raza,
        decimal peso,
        string tipoProduccion,
        bool esPedigree)   
    {
        TipoProduccion = !string.IsNullOrWhiteSpace(tipoProduccion) ? tipoProduccion.ToUpper() : "CARNE";
        EsPedigree = esPedigree;
    }

    // TODO 7: Programar CalcularValorComercial() 
    // Calcula el valor comercial a $2.500m el kg.
    // Adiciona un bono genético de +$150.000m si es de "LECHE" o
    // +$200.000m si es de "CARNE".
    // Si cuenta con certificación Pedigree ,
    // recarga un 20% adicional al valor subtotal.
    public decimal CalcularValorComercial()
    {
        
        return 0;
    }

    public override string ObtenerFicha()
    {
        string pedigreeStr = EsPedigree ? "PEDIGREE CERTIFICADO" : "CONVENCIONAL";
        return $"{base.ObtenerFicha()} | Bovino ({TipoProduccion}) [{pedigreeStr}] -> Valor: ${CalcularValorComercial():N2}";
    }
}
