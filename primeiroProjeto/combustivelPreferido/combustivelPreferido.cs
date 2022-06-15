// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace combustivelPreferido
{
    class PlanoCartesiano
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- COMBUSTIVEL PREFERIDO ----------");

            int combustivel;

            Console.WriteLine("Digite seu combustivel favorito?");
            Console.WriteLine("1. Álcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. Fim");
            combustivel = int.Parse(Console.ReadLine());

            while (combustivel <= 0 && combustivel > 4)
            {
                Console.WriteLine("Digite seu combustivel favorito?");
                Console.WriteLine("1. Álcool");
                Console.WriteLine("2. Gasolina");
                Console.WriteLine("3. Diesel");
                Console.WriteLine("4. Fim");
                combustivel = int.Parse(Console.ReadLine());
            }
            if (combustivel == 1)
            {
                Console.WriteLine("Seu combustivel favorito é Álcool!");
            }
            else if (combustivel == 2)
            {
                Console.WriteLine("Seu combustivel favorito é Gasolina!");
            }
            else if (combustivel == 3)
            {
                Console.WriteLine("Seu combustivel favorito é Diesel!");
            }
            else
            {
                Console.WriteLine("Fim!");
            }
        }
    }
}