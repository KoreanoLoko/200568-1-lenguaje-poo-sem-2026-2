using System;

// TODO 8: Asignar al mismo espacio de nombres PesqueraChan.Core


public class LoteEspecieMarina // Heredar de PezCultivo
{
    public string TipoAlimentacion { get; set; } // "ORGANICA" u "ESTANDAR"
    public int CantidadUnidades { get; set; }

    // TODO 9: Implementar el constructor invocando a ': base(...)'

    // TODO 10: Sobrescribir 'CalcularValorComercial()' (override)
    // Reglas:
    // - Subtotal base por kg especie marina: PesoKilos * $3.000m
    // - Si TipoAlimentacion == "ORGANICA", aplicar 18% de recargo (subtotal *= 1.18m)
    // - Si CantidadUnidades > 500, sumar bono por densidad/volumen de +$100.000m


    public override string ObtenerFicha()
    {
        return $"{base.ObtenerFicha()} | Especie Marina ({TipoAlimentacion}) [Unidades: {CantidadUnidades}] -> Valor: ${CalcularValorComercial():N2}";
    }
}

