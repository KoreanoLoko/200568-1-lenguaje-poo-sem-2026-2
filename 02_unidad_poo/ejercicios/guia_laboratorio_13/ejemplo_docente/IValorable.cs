using System;

namespace AuditoriaAgroindustrial.Core;

// Contrato que exige capacidad de tasación comercial
public interface IValorable
{
    string CodigoActivo { get; }
    decimal CalcularTasacionComercial();
    string ObtenerFichaAuditoria();
}
