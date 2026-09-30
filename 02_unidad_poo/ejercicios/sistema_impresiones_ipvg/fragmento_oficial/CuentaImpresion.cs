public class CuentaImpresion
{
    public decimal Saldo { get; private set; }

    // Constructor Maestro
    public CuentaImpresion(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }

    // Constructor por defecto (Delega enviando 0)
    public CuentaImpresion() : this(0.0m)
    {
    }

    // Constructor Promocional (Delega y luego aplica bono)
    public CuentaImpresion(decimal saldo, bool promo) : this(saldo)
    {
        if (promo) Saldo += 500.0m;
    }

    public void ProcesarImpresion(ref decimal saldoActual, int costoDoc, out int paginas)
    {
        // 1. OUT: Asignación obligatoria inicial (Bandeja vacía)
        paginas = 0;

        // 2. REF: Lectura del tanque original de dinero
        if (saldoActual >= costoDoc)
        {
            // 3. REF: Modificación bidireccional directa
            saldoActual -= costoDoc;

            // 4. OUT: Emisión del dato de salida final
            paginas = costoDoc / 20; // 20 pesos por hoja
            Console.WriteLine($"Impresión OK. Saldo restante: ${saldoActual}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para imprimir.");
        }
    }
}
