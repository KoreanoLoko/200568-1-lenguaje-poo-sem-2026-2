using System;
using System.Runtime.InteropServices.Marshalling;

// TODO 11: Importar Namespace CineIPVG.Core y declarar Alias de Tipo 'ProductoCine'
using ProductoCine = CineIPVG.Core.Producto;
using Entrada = CineIPVG.Core.EntradaCine;
using Snack = CineIPVG.Core.SnackCine;
namespace CineIPVG.App;

class Program
{
    // TODO 12: Método transaccional 'ProcesarVenta' (ref decimal cajaCine, out decimal descuentoAplicado)
    static decimal ProcesarVenta(ProductoCine producto, ref decimal cajaGlobalCine, out decimal descuentoAplicado)
    {
        decimal PrecioFinal = producto.CalcularPrecioFinal();
        descuentoAplicado = producto.PrecioBase - PrecioFinal;
        if (descuentoAplicado <= 0)
            descuentoAplicado = 0;
        cajaGlobalCine += PrecioFinal;
        return PrecioFinal;
    }

    static void Main(string[] args)
    {
        decimal cajaGlobalCine = 0.00m;

        // TODO 13: Declarar colección genérica List llamada 'carrito'
        List<ProductoCine> carrito = new List<ProductoCine>();

        string opcion = "";
        do
        {
            Console.WriteLine("=== CINE SEDE IPVG — TAQUILLA Y CONFITERÍA === ");
            Console.WriteLine("1. Agregar Entrada de Cine");
            Console.WriteLine("2. Agregar Snack / Combo");
            Console.WriteLine("3. Ver Carrito de Compras (Polimorfismo)");
            Console.WriteLine("4. Pagar y Procesar Venta (ref / out)");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    carrito.Add(new Entrada("E-101", "Avatar 3", 4500m, true, "IMAX"));
                    Console.WriteLine("-> Entrada agregada al carrito con éxito.");
                    break;

                case "2":
                    carrito.Add(new Snack("S-201", "Popcorn Mantequilla", 3000m, "GIGANTE", true));
                    Console.WriteLine("-> Snack agregado al carrito con éxito.");
                    break;

                case "3":
                    Console.WriteLine("-- - DETALLE DEL CARRITO-- - ");
                    // TODO 14: Recorrer polimórficamente la lista 'carrito' con 'foreach'
                    foreach (ProductoCine venta in carrito)
                    {
                        Console.WriteLine($"{venta.ObtenerDetalle()}");
                    }

                    break;

                case "4":
                    decimal totalBoleta = 0.00m;
                    Console.WriteLine("-- - COBRO DE BOLETA-- - ");
                    // TODO 15: Recorrer invocando 'ProcesarVenta' con 'ref' y 'out', y vaciar con Clear()
                    foreach (ProductoCine productoCine in carrito)
                    {
                        decimal descuentoAplicado;
                        totalBoleta += ProcesarVenta(productoCine, ref cajaGlobalCine, out descuentoAplicado);
                        Console.WriteLine($"");
                    }
                        
                    break;

                case "5":
                    Console.WriteLine("Cerrando sistema de taquilla...");
                    break;
            }

        } while (opcion != "5");
    }
}
