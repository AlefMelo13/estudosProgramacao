using System;
using System.Globalization;

namespace CadastroPessoa
{
    class CadastroPessoa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- CADASTRO DE PESSOA ----------");

            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.Write("Digite o nome da pessoa1: ");
            pessoa1.Nome = Console.ReadLine();

            Console.Write("Digite a idade da pessoa1: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da pessoa1: ");
            pessoa1.Nome = Console.ReadLine();

            Console.Write("Digite a idade da pessoa1: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é: {pessoa1.Nome}");
            }
            else
            {
                Console.WriteLine($"A pessoa mais velha é: {pessoa2.Nome}");
            }
        }
    }
}