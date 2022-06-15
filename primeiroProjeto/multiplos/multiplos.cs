// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace multiplos
{
    class Multiplos
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- MÚLTIPLOS DE DOIS ----------");

            double a, b, modA, modB;

            Console.Write("Digite dois números: ");
            string[] vet = Console.ReadLine().Split(",");

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            //ARMAZENA EM A O RESTO DA DIVISÃO DE A/2
            modA = a % 2;

            modB = b % 2;

            if (modA == 0 && modB == 0)
            {
                Console.WriteLine("São Múltiplos de 2");
            }
            else
            {
                Console.WriteLine("Não São Múltiplos de 2");
            }
        }
    }
}