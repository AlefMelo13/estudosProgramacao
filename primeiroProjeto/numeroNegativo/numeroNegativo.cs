// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace NumeroNegativo
{
    class NumeroNegativo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- NÚMERO NEGATIVO ----------");

            int i, n;
            int[] numero;

            Console.Write("Digite a quantidade de números a serem digitados: ");
            n = int.Parse(Console.ReadLine());

            numero = new int[n];

            for (i=0; i<n; i++)
            {
                Console.Write("Digite o " + i + "º número: ");
                numero[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("***** CARREGANDO *****");

            for (i=0; i<n; i++)
            {
                if (numero[i] < 0)
                {
                    Console.WriteLine("O(s) número(s) negativo(s) é(são): " + numero[i]);
                }
            }
        }
    }
}