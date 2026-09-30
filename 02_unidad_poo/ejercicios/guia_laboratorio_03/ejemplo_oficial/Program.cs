using System;

namespace DemostracionCasino
{
    // Definición de Tipo por Valor (struct)
    public struct CuponDescuento
    {
        public string Codigo;
        public int Porcentaje;
    }

    // Definición de Tipo por Referencia (class)
    public class PedidoCafeteria
    {
        public string Alumno;
        public string Plato;
        public string Estado;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- DEMOSTRACIÓN: STRUCT VS CLASS ---\n");

            // 1. COMPORTAMIENTO DEL STRUCT (TIPO POR VALOR)
            CuponDescuento cupon1 = new CuponDescuento { Codigo = "ALMUERZOVG", Porcentaje = 15 };
            CuponDescuento cupon2 = cupon1; // Copia binaria en el Stack

            cupon2.Porcentaje = 30; // Se modifica solo la copia de cupon2

            Console.WriteLine("[STRUCT] Cupon 1 Original: " + cupon1.Codigo + " - " + cupon1.Porcentaje + "%");
            Console.WriteLine("[STRUCT] Cupon 2 Modificado: " + cupon2.Codigo + " - " + cupon2.Porcentaje + "%");
            Console.WriteLine("(Explicación: El cupón original no cambia porque se copió por valor en el Stack)\n");

            // 2. COMPORTAMIENTO DE LA CLASE (TIPO POR REFERENCIA)
            PedidoCafeteria pedido1 = new PedidoCafeteria { Alumno = "Juan Pérez", Plato = "Pescado frito con puré", Estado = "Pendiente" };
            PedidoCafeteria pedido2 = pedido1; // Copia el puntero del Stack. Ambos apuntan al mismo Heap

            pedido2.Estado = "Entregado"; // Se modifica el objeto compartido en el Heap

            Console.WriteLine("[CLASS] Pedido 1 Original (Estado): " + pedido1.Estado);
            Console.WriteLine("[CLASS] Pedido 2 Referencia (Estado): " + pedido2.Estado);
            Console.WriteLine("(Explicación: Ambos pedidos muestran 'Entregado' porque comparten la misma dirección en el Heap)\n");
        }
    }
}
