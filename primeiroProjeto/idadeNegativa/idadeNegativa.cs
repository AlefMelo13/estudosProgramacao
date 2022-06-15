// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace idadeNegativa
{
    class IdadeNegativa
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- IDADE NEGATIVA ----------");

            double idade, somaIdade, mediaIdade, cont;
            somaIdade = 0;
            cont = 0;

            Console.Write("Digite uma idade: ");
            idade = double.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                if (idade >= 0)
                {
                    somaIdade += idade;
                    cont += 1;
                }
                Console.Write("Digite uma idade: ");
                idade = double.Parse(Console.ReadLine());
            }
            if (cont == 0 && idade < 0)
            {
                Console.WriteLine("Idade Inválida!");
            }
            else
            {
                mediaIdade = somaIdade / cont;
                Console.Write("A média das idades digitadas é: " + mediaIdade.ToString("F2"));
            }
        }
    }
}