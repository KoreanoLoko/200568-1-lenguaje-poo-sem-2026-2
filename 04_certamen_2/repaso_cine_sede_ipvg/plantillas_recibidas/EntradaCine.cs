using System;
using System.Collections.Generic;
using System.Text;

namespace CineIPVG.Core;
    internal class EntradaCine : Producto
    {
    public bool Es3D { get; set; }
    public string FormatoSala { get; set; } // "NORMAL" o "IMAX"

    // TODO 6: Constructor invocando a : base(...)
    public EntradaCine(string codigo, string nombre, decimal precioBase, bool es3D, string formatoSala)
        : base(codigo, nombre, precioBase)
    {
        Es3D = es3D;
        FormatoSala = !string.IsNullOrWhiteSpace(formatoSala) ? formatoSala.ToUpper() : "NORMAL";
    }


    // TODO 7: Sobrescribir 'CalcularPrecioFinal()' (override)
    public override decimal CalcularPrecioFinal()
    {
        decimal precio = PrecioBase;
        if (Es3D) precio += 1500m;
        if (FormatoSala == "IMAX") precio += 2000m;
        return precio;
    }

    public override string ObtenerDetalle()
    {
        string tipo = Es3D ? "3D" : "2D";
        return $"{base.ObtenerDetalle()} | Entrada {tipo} (Sala {FormatoSala}) -> Final: $${CalcularPrecioFinal():N2}";
    }

}
