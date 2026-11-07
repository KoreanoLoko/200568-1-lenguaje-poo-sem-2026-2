using System;

namespace AuditoriaAgroindustrial.Core;

// Implementa IValorable e IExportable sin heredar de AnimalGanado
public class MaquinariaAgricola : IValorable, IExportable
{
    public string CodigoActivo { get; set; }
    public string Modelo { get; set; }
    public decimal ValorCompra { get; set; }
    public int AnioFabricacion { get; set; }
    public string PaisDestino { get; set; }
    public bool CumpleNormaFitosanitaria => AnioFabricacion >= 2020;

    public MaquinariaAgricola(string codigo, string modelo, decimal valorCompra, int anio, string paisDestino)
    {
        CodigoActivo = codigo;
        Modelo = modelo;
        ValorCompra = valorCompra;
        AnioFabricacion = anio;
        PaisDestino = paisDestino;
    }

    public decimal CalcularTasacionComercial()
    {
        int antiguedad = DateTime.Now.Year - AnioFabricacion;
        decimal depreciacion = ValorCompra * (antiguedad * 0.08m);
        decimal valorActual = ValorCompra - depreciacion;
        return valorActual > 1000000m ? valorActual : 1000000m;
    }

    public string ObtenerFichaAuditoria()
    {
        return $"[MAQUINARIA] {CodigoActivo} - {Modelo} ({AnioFabricacion}) | Valorizado: ${CalcularTasacionComercial():N2}";
    }

    public string GenerarCertificadoExportacion()
    {
        string estado = CumpleNormaFitosanitaria ? "NORMA ISO CUMPLIDA" : "REQUIERE REVISIÓN TÉCNICA";
        return $"[CERTIFICADO MAQUINARIA] Ref: {CodigoActivo} | Modelo: {Modelo} | Destino: {PaisDestino} | Inspección: {estado}";
    }
}
