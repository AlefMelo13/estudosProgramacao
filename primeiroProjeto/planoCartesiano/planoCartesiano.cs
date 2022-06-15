// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace planoCartesiano
{
    class PlanoCartesiano
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- PLANO CARTESIANO ----------");

            int x, y;
            string[] vet;

            Console.Write("Digite o valor de x e y simultaneamente: ");
            vet = Console.ReadLine().Split(",");

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y >0)
                {
                    Console.WriteLine("Primeiro Quadrante!");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante!");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante!");
                }
                else
                {
                    Console.WriteLine("Quarto Quadrante!");
                }
                Console.Write("Digite o valor de x e y simultaneamente: ");
                vet = Console.ReadLine().Split(",");

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
            Console.WriteLine("Valor Inválido!");
        }
    }
}