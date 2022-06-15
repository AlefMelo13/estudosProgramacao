// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace diferencaValores
{
    class DiferencaValores
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- DIFERENÇA DO PRODUTO ----------");

            int numero1, numero2, numero3, numero4, produto;

            Console.Write("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            numero3 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            numero4 = int.Parse(Console.ReadLine());

            produto = numero1 * numero2 - numero3 * numero4;

            Console.WriteLine("A diferença do produto dos pares de número é: " + produto);
        }
    }
}