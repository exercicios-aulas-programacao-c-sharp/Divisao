using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numerador, denominador, resultado;
            bool numeradorValido, denominadorValido;

            Console.Write("Digite o numerador....: ");
            numeradorValido = Decimal.TryParse(Console.ReadLine(), out numerador);

            if (!numeradorValido)
            {
                Console.WriteLine("O numerador informado não é um número válido");
                Environment.Exit(1);
            }

            Console.Write("Digite o denominador..: ");
            denominadorValido = Decimal.TryParse(Console.ReadLine(), out denominador);

            if (!denominadorValido)
            {
                Console.WriteLine("O denominador informado não é um número válido");
                Environment.Exit(1);
            }

            if (denominador == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            else
            {
                resultado = numerador / denominador;
                Console.WriteLine($"{numerador} dividido por {denominador} é {resultado}.");
            }

            
        }
    }
}
