using System;

// Declaración File-Scoped Namespace (C# 10+)
namespace IPVG.Sede.Equipamiento;

public class Locker
{
    // Miembro Estático Global a nivel de Sede
    private static decimal recaudoTotalSede = 0.00m;

    // Propiedades de Instancia Encapsuladas
    public int NumeroLocker { get; }
    public string EstudianteRut { get; private set; }
    public bool EstaOcupado { get; private set; }
    public decimal TarifaMensual { get; private set; }

    // Constructor Estándar
    public Locker(int numeroLocker, decimal tarifaMensual)
    {
        NumeroLocker = numeroLocker;
        TarifaMensual = tarifaMensual > 0 ? tarifaMensual : 3500.00m;
        EstudianteRut = "SIN ASIGNAR";
        EstaOcupado = false;
    }

    // Método de Negocio con parámetro de salida 'out'
    public bool Arrendar(string rut, out decimal cobro)
    {
        if (EstaOcupado)
        {
            cobro = 0.00m; // Obligación estricta de asignación de salida
            return false;
        }

        EstudianteRut = rut.ToUpper();
        EstaOcupado = true;
        cobro = TarifaMensual;
        recaudoTotalSede += cobro; // Acumulador estático global
        return true;
    }

    public static decimal ObtenerRecaudoGlobal() => recaudoTotalSede;

    public string ObtenerFicha()
    {
        string estado = EstaOcupado ? $"OCUPADO (RUT: {EstudianteRut})" : "DISPONIBLE";
        return $"Locker N° {NumeroLocker:D3} | Tarifa: ${TarifaMensual:N2} | Estado: {estado}";
    }
}
