using System;

// TODO 1: Declarar File-Scoped Namespace (GanaderiaChan.Core)
namespace GanaderiaChan.Core;

public class AnimalGanado
{
    private decimal pesoKilos;

    public string codigoAnimal;
    public string raza;

    // TODO 2: Propiedad Completa PesoKilos (Validación: Si <= 100m, asigna 100m)
    public decimal PesoKilos
    {
        get
        {
            return pesoKilos;
        }
        set
        {
            if (value <= 100m)
                pesoKilos = 100m;
            else 
                pesoKilos = value;
        }
    }

    public AnimalGanado(string codigo, string raza, decimal peso)
    {
        codigoAnimal = codigo;
        this.raza = raza;
        PesoKilos = peso;
    }

    // TODO 3: Declarar método virtual CalcularValorComercial()
    public virtual decimal CalcularValorComercial()
    {
        return PesoKilos * 2000m;
    }

    // TODO 4: Declarar método virtual ObtenerFicha() para mostrar
    //código, raza, peso y valor comercial
    public string ObtenerFicha()
    {
        return $"Codigo: {codigoAnimal} : Raza: {raza} : Peso: {pesoKilos:N2} kg : Valor comercial: {CalcularValorComercial():N2}";
    }
}
