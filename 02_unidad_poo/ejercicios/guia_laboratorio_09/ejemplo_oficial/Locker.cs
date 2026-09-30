using System;

namespace IPVG.Sede.Equipamiento;

public class Locker
{
    public int NumeroLocker { get; }
    public string RutEstudiante { get; private set; }
    public bool EstaOcupado { get; private set; }

    public Locker(int numero)
    {
        NumeroLocker = numero;
        RutEstudiante = "";
        EstaOcupado = false;
    }

    public bool Asignar(string rut)
    {
        if (EstaOcupado) return false;
        RutEstudiante = rut.ToUpper();
        EstaOcupado = true;
        return true;
    }
}
