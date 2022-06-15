// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace numeroMaior
{
    class NumeroMaior
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- NÚMERO MAIOR ----------");

            double a, b, c;

            Console.Write("Digite 3 números: ");
            string[] vet = Console.ReadLine().Split(",");

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if (a < b && a < c)
            {
                Console.WriteLine("O menor é " + a);
            }
            else
            {
                if (b < a && b < c)
                {
                    Console.WriteLine("O menor é " + b);
                }
                else
                {
                    Console.WriteLine("O menor é " + c);
                }
            }
        }
    }
}