namespace SistemaBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuentaBancaria = null;

            string cliente = leerTexto("Ingrese Nombre del Cliente");
            decimal saldoInicial = leerNumero("Ingrese Monto inicial de la Cuenta");
            cuentaBancaria = new CuentaBancaria(cliente, saldoInicial);
            do
            {
                mostrarMenu();
                int opcion = leerNumero("Seleccione una opción (1-5):", 1, 5);
                switch (opcion)
                {
                    case 1:// Depositar
                        decimal montoDeposito = leerNumero("Ingrese el monto a depositar:");
                        if (cuentaBancaria != null)
                        {
                            cuentaBancaria.Depositar(montoDeposito);
                        }
                        break;

                    case 2:// Retirar
                        decimal montoRetiro = leerNumero("Ingrese el monto a retirar:");
                        if (cuentaBancaria != null)
                        {
                            cuentaBancaria.Retirar(montoRetiro);
                        }
                        break;
                    case 3:// Consultar Saldo
                        if (cuentaBancaria != null)
                        {
                            Console.WriteLine($"Saldo actual: ${cuentaBancaria.Saldo}");
                        }
                        break;
                    case 4://consultar cantidad de cuentas
                        Console.WriteLine($"Cantidad de cuentas creadas: {CuentaBancaria.ObtenerCantidadCuentas()}");
                        break;
                    case 5:// Salir
                        Console.WriteLine("Gracias por usar el Sistema Bancario.");
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }

        public static void mostrarMenu()
        {
            Console.WriteLine("Bienvenido al Sistema Bancario");

            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Consultar Saldo");
            Console.WriteLine("4. Consultar Cantidad de Cuentas");
            Console.WriteLine("5. Salir");
        }

        public static string leerTexto(string mensaje)
        {

            string textoLeido = "";
            Console.WriteLine(mensaje);
            do
            {
                textoLeido = Console.ReadLine() ?? "";
                if (!string.IsNullOrWhiteSpace(textoLeido))
                {

                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un texto válido.");
                }

            } while (true);
            return textoLeido;
        }
        public static decimal leerNumero(string mensaje)
        {
            decimal numeroLeido = 0;
            bool esNumeroValido = false;

            Console.WriteLine(mensaje);
            do
            {
                string entrada = Console.ReadLine();
                esNumeroValido = decimal.TryParse(entrada, out numeroLeido); //valida Conversion de string a decimal
                //numeroLeido = decimal.Parse(entrada); //Solo Comvierte el string a decimal, si no es un numero valido, lanza una excepcion

                if (!esNumeroValido)
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                }
                else
                {
                    return numeroLeido;
                }



            } while (true);

        }

        public static int leerNumero(string mensaje, int opMinima, int opcionMax)
        {
            int numeroLeido = 0;
            bool esNumeroValido = false;

            Console.WriteLine(mensaje);
            do
            {
                string entrada = Console.ReadLine();
                esNumeroValido = int.TryParse(entrada, out numeroLeido); //valida Conversion de string a decimal
                if (!esNumeroValido || numeroLeido < opMinima || numeroLeido > opcionMax)
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                }
                else
                {
                    return numeroLeido;
                }



            } while (true);

        }
    }
}
