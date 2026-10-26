using System;
using System.Collections.Generic;
using System.Text;

namespace CineIPVG.Core;
    internal class SnackCine : Producto
{
    public string Tamaño { get; set; } // "MEDIANO" o "GIGANTE"
    public bool EsCombo { get; set; }

    // TODO 9: Constructor invocando a : base(...)
    public SnackCine(string codigo, string nombre, decimal precioBase, string tamaño, bool esCombo)
        : base(codigo, nombre, precioBase)
    {
        Tamaño = !string.IsNullOrWhiteSpace(tamaño) ? tamaño.ToUpper() : "MEDIANO";
        EsCombo = esCombo;
    }
    

    // TODO 10: Sobrescribir 'CalcularPrecioFinal()' (override)
    public override decimal CalcularPrecioFinal()
    {
        // TODO: Reglas: GIGANTE (+25% recargo), EsCombo (10% descuento final)
        decimal precio = PrecioBase;
        if (Tamaño == "GIGANTE")
        {
            decimal recargo = precio * 0.25m;
            precio += recargo;
        }
        if (EsCombo)
        {
            decimal descuento = precio * 0.10m;
            precio -= descuento; 
        }
        return precio;
    }

    public override string ObtenerDetalle()
    {
        string comboStr = EsCombo ? "COMBO CON BEBIDA" : "INDIVIDUAL";
        return $"{base.ObtenerDetalle()} | Snack {Tamaño} ({comboStr}) -> Final: $${CalcularPrecioFinal():N2}";
    }

}
