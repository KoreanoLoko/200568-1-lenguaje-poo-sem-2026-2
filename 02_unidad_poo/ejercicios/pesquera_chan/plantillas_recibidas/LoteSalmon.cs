using System;

// TODO 5: Asignar al mismo espacio de nombres PesqueraChan.Core

public class LoteSalmon // Heredar de  PezCultivo
{
    public string TipoAgua { get; set; } // "SALADA" o "DULCE"
    public bool EsCertificadoASC { get; set; }

    // TODO 6: Implementar el constructor delegando a la superclase mediante ': base(...)'

    // TODO 7: Sobrescribir 'CalcularValorComercial()' (override)
    // Reglas:
    // - Subtotal base por kg salmón: PesoKilos * $4.000m
    // - Si TipoAgua == "SALADA", sumar +$150.000m (centro de engorda en mar)
    // - Si EsCertificadoASC == true, aplicar un 25% de recargo sobre el subtotal acumulado (subtotal *= 1.25m)



    public override string ObtenerFicha()
    {
        string ascStr = EsCertificadoASC ? "CERTIFICACIÓN SUSTENTABLE ASC" : "ESTÁNDAR";
        return $"{base.ObtenerFicha()} | Salmón ({TipoAgua}) [{ascStr}] -> Valor: ${CalcularValorComercial():N2}";
    }
}

