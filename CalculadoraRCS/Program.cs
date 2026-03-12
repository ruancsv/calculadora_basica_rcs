using System;
using System.Globalization;

namespace CalculadoraRCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Escolha uma das opções: (+, -, *, /) ");
            string opções = Console.ReadLine();

            double resultado = 0;

            switch (opções)
            {
                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;

                case "/":
                    resultado = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Operação inválida!");
                    return;

            }

            Console.WriteLine("Resultado: " + resultado);

            Console.ReadLine();

        }
    }
}