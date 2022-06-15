// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace crescenteDecrescente
{
    class CrescenteDecrescente
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- CRESCENTE OU DECRESCENTE ----------");

            int numero1, numero2;
            string[] vet;

            Console.Write("Digite dois números: ");
            vet = Console.ReadLine().Split(",");

            numero1 = int.Parse(vet[0]);
            numero2 = int.Parse(vet[1]);

            while (numero1 != numero2)
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine("Decrescente!");
                }
                else
                {
                    Console.WriteLine("Crescente!");
                }
                Console.Write("Digite dois números: ");
                vet = Console.ReadLine().Split(",");

                numero1 = int.Parse(vet[0]);
                numero2 = int.Parse(vet[1]);
            }
        }
    }
}