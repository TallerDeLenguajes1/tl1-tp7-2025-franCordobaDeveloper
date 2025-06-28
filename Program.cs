using EspacioCalculadora;

class Program
{
    static void Main()
    {
        Calculadora calculadora = new();

        int opc;
        string? numString;
        bool continuar = true;

        while (continuar)
        {
            do
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1) Sumar");
                Console.WriteLine("2) Restar");
                Console.WriteLine("3) Multiplicar");
                Console.WriteLine("4) Dividir");
                Console.WriteLine("5) Limpiar");
                Console.WriteLine("0) Salir");
                numString = Console.ReadLine();
            } while (!int.TryParse(numString, out opc));

            if (opc == 0)
            {
                Console.WriteLine("Saliendo...");
                continuar = false;
                continue;
            }

            double valor = 0;


            if (opc >= 1 && opc <= 4)
            {
                Console.Write("Ingrese el número: ");
                string? valorStr = Console.ReadLine();

                if (!double.TryParse(valorStr, out valor))
                {
                    Console.WriteLine("Ingreso invalido.");
                    continue;
                }
            }

            switch (opc)
            {
                case 1:
                    calculadora.Sumar(valor);
                    break;
                case 2:
                    calculadora.Restar(valor);
                    break;
                case 3:
                    calculadora.Multiplicar(valor);
                    break;
                case 4:
                    calculadora.Dividir(valor);
                    break;
                case 5:
                    calculadora.Limpiar();
                    Console.WriteLine("limpiar.");
                    break;
                default:
                    Console.WriteLine("Opcion ingresa incorrecta.");
                    break;
            }

            Console.WriteLine($"Resultado actual: {calculadora.Resultado}");
        }

        Console.WriteLine($"Resultado final: {calculadora.Resultado}");
    }
}
