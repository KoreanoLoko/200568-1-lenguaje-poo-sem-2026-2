namespace PruebaMemoria
{
    public struct Punto
    {
        public int X { get; set; }
    }

    public class Jugador
    {
        public int Puntaje { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Por valor

            Punto primerPunto = new Punto();
            primerPunto.X = 0;

            Punto segundoPunto = new Punto();
            segundoPunto = primerPunto;

            segundoPunto.X = 3;

            Console.WriteLine($"X de primerPunto es {primerPunto.X}");
            Console.WriteLine($"X de segundoPunto es {segundoPunto.X}");

            // por ref
            Jugador player1 = new Jugador();
            player1.Puntaje = 1000;

            Jugador player2 = player1;
            player2.Puntaje = 500000;

            Console.WriteLine($"Puntaje Player1 {player1.Puntaje}");
            Console.WriteLine($"Puntaje Player2 {player2.Puntaje}");
        }
    }
}
