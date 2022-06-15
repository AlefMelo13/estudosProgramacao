// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace vetorSomaMedia
{
    class VetorSomaMedia
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- VETOR SOMA MÉDIA ----------");

            int i, n;
            int[] numero;

            Console.Write("Digite a quantidade de números a serem lidos: ");
            n = int.Parse(Console.ReadLine());

            numero = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("Digite um número: ");
                numero[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Valor: " + numero[i]);
            }
        }
    }
}