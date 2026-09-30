using System;

namespace ImpresionesSede
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE IMPRESIONES IPVG - SEMANA 4 ===");

            // Prueba 1: Sobrecarga de constructores
            CuentaImpresion c1 = new CuentaImpresion("Seba Muñoz"); // $1,000 por defecto
            CuentaImpresion c2 = new CuentaImpresion("Majo Rojas", 5000.00m);

            decimal saldoFisicoTarj = 5000.00m; // Debe inicializarse para ref
            int paginasImpresas;
            decimal montoDescontado;

            bool exito = c2.ProcesarImpresion(35, ref saldoFisicoTarj, out paginasImpresas, out montoDescontado);

            if (exito)
            {
                Console.WriteLine("\n[IMPRESIÓN REALIZADA CON ÉXITO]");
                Console.WriteLine($"  Páginas físicas entregadas: {paginasImpresas}");
                Console.WriteLine($"  Monto cobrado: ${montoDescontado:N2}");
                Console.WriteLine($"  Saldo credencial física (ref modificado): ${saldoFisicoTarj:N2}");
            }
        }
    }
}
