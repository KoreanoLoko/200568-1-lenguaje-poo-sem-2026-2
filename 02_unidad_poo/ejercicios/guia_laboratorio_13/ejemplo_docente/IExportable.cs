using System;

namespace AuditoriaAgroindustrial.Core;

// Contrato que exige normas de exportación internacional
public interface IExportable
{
    string PaisDestino { get; set; }
    bool CumpleNormaFitosanitaria { get; }
    string GenerarCertificadoExportacion();
}
