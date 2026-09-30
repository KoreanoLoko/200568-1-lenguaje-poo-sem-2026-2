namespace ControlHoras
{
    public class Colaborador //Clase Colaborador
    {
        public string Nombre { get; set; } 
        public string Cargo { get; set; }
        public int TotalHoras
        {
            get => totalHoras;
            set => totalHoras = value;
        }

        private int totalHoras = 0;

        public void registrarJornada(RegistroHoras registro)
        {
            //totalhoras es variable Local del método 
            int totalHoras = 0;

            totalHoras = registro.Horas;

            //this.totalHoras es mienbro de la clase.
            this.TotalHoras += totalHoras;
        }

    }
    public struct RegistroHoras
    {
        public string Dia { get; set; }
        public int Horas { get; set; }
    }

    //Esta es la clase Principal -- La clase que se ejecuta
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aquí empieza el trabajo:");

            Colaborador gerente = new Colaborador();
            gerente.Nombre = "Alan Brito";
            gerente.Cargo = "Finanzas";

            RegistroHoras nuevoRegistro = new RegistroHoras
            {
                Dia = "lunes",
                Horas = 5
            };

            gerente.registrarJornada(nuevoRegistro);


            nuevoRegistro = new RegistroHoras
            {
                Dia = "martes",
                Horas = 8
            };
            gerente.registrarJornada(nuevoRegistro);

            Console.WriteLine($"El Total de horas trabajasas por {gerente.Nombre}" +
                $" es {gerente.TotalHoras}");

        }
    }
}
