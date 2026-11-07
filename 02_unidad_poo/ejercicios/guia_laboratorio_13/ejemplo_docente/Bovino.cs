using System;

namespace AuditoriaAgroindustrial.Core;

// Hereda de AnimalGanado e implementa IExportable (IValorable viene heredado)
public class Bovino : AnimalGanado, IExportable
{
    public string Raza { get; set; }
    public string PaisDestino { get; set; }
    public bool CumpleNormaFitosanitaria { get; set; }

    public Bovino(string codigo, decimal peso, string raza, string pais, bool cumpleNorma)
        : base(codigo, peso)
    {
        Raza = raza;
        PaisDestino = pais;
        CumpleNormaFitosanitaria = cumpleNorma;
    }

    public override decimal CalcularTasacionComercial()
    {
        decimal baseVal = base.CalcularTasacionComercial() * 1.25m;
        return CumpleNormaFitosanitaria ? baseVal + 100000m : baseVal;
    }

    public string GenerarCertificadoExportacion()
    {
        string estado = CumpleNormaFitosanitaria ? "APROBADO" : "RECHAZADO";
        return $"[CERTIFICADO BOVINO] Ref: {codigo} | Raza: {Raza} | Destino: {PaisDestino} | Fitosanitario: {estado}";
    }
}
