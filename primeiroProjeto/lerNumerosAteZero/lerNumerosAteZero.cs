// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace lerNumerosAteZero
{
    class LerNumeroAteZero
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- ENQUANTO NÃO FOR ZERO ----------");

            int zero, soma;
            soma = 0;

            Console.Write("Digite um número diferente de zero: ");
            zero = int.Parse(Console.ReadLine());

            while (zero != 0)
            {
                Console.Write("Digite um número diferente de zero: ");
                soma +=  zero;
                zero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A soma dos números digitados é: " + soma);
        }
    }
}