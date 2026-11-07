using System;

namespace AuditoriaAgroindustrial.Core;

public class AnimalGanado : IValorable
{
    protected string codigo;
    protected decimal pesoKilos;

    public string CodigoActivo => codigo;

    public AnimalGanado(string codigo, decimal pesoKilos)
    {
        this.codigo = codigo;
        this.pesoKilos = pesoKilos >= 100m ? pesoKilos : 100m;
    }

    public virtual decimal CalcularTasacionComercial() => pesoKilos * 2000m;

    public virtual string ObtenerFichaAuditoria() =>
        $"[GANADO] Código: {codigo} | Peso: {pesoKilos:N1} kg | Tasación: ${CalcularTasacionComercial():N2}";
}
