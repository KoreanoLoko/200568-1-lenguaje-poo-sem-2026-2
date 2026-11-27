using System;

namespace MonitoreoFundo.Core;

// TODO 1: Heredar de la clase base 'Exception'
public class LecturaInvalidaException : Exception
{
    // TODO 2: Crear propiedad autoimplementada 'ValorInvalido' (decimal, get-only)
    public decimal ValorInvalido { get; }

    // TODO 3: Implementar constructor delegando el mensaje a ': base(mensaje)'
    public LecturaInvalidaException(string mensaje, decimal valor)
        : base(mensaje)
    {
        ValorInvalido = valor;
    }
}
