using System;

namespace MonitoreoFundo.Core;

public class SensorAmbiental
{
    public string CodigoSensor { get; set; }
    public string TipoVariable { get; set; } // 'PH' o 'TEMPERATURA'
    public bool EstadoActivo { get; set; }

    public SensorAmbiental(string codigo, string tipo, bool activo)
    {
        // TODO 4: Validar si 'codigo' es nulo o vacío. Si lo es, lanzar 'ArgumentNullException'
        if (string.IsNullOrWhiteSpace(codigo))
            throw new ArgumentNullException(nameof(codigo), "El código del sensor es obligatorio.");

        CodigoSensor = codigo;
        TipoVariable = tipo.ToUpper();
        EstadoActivo = activo;
    }

    public decimal RegistrarLectura(decimal valor)
    {
        // TODO 5: Si 'EstadoActivo' es false, lanzar 'InvalidOperationException'
        if (!EstadoActivo)
            throw new InvalidOperationException($"El sensor [{CodigoSensor}] está apagado.");

        // TODO 6: Validar rangos normativos y lanzar 'LecturaInvalidaException' si se excede el límite
        if (TipoVariable == "PH")
        {
            if (valor < 0.0m || valor > 14.0m)
                throw new LecturaInvalidaException($"pH {valor:N1} fuera de escala (0-14).", valor);
        }
        else if (TipoVariable == "TEMPERATURA")
        {
            if (valor < 0.0m || valor > 45.0m)
                throw new LecturaInvalidaException($"Temperatura {valor:N1}°C excede límite crítico (0-45°C).", valor);
        }

        return valor;
    }
}
