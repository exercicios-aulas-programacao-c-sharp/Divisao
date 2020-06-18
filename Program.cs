using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numerador, denominador, resultado;

            Console.Write("Digite o numerador....: ");
            numerador = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o denominador..: ");
            denominador = Convert.ToDecimal(Console.ReadLine());

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
