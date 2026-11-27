using System;

// TODO 1: Declarar File-Scoped Namespace (PesqueraChan.Core)


public class PezCultivo
{
    private decimal pesoKilos; // Backing field privado

    protected string codigoLote;
    protected string especie;

    // TODO 2: Implementar la Propiedad Completa 'PesoKilos'
    // Regla: Si el valor ingresado es <= 50.0m, asignar 50.0m (piso mínimo de seguridad). 
    // Si es mayor, asignar el valor.
    public decimal PesoKilos
    {
        get
        {
            return pesoKilos;
        }
        set
        {
            pesoKilos = value;
        }
    }

    public PezCultivo(string codigo, string especie, decimal peso)
    {
        codigoLote = codigo;
        this.especie = especie;
        PesoKilos = peso; // Dispara la validación del setter
    }

    // TODO 3: Declarar el método virtual 'CalcularValorComercial()' (Base: $3.200 por kg)

    // TODO 4: Declarar el método virtual 'ObtenerFicha()' que muestre Código, especie y valor comercial

}
