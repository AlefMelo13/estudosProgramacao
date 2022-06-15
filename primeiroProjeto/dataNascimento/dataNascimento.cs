// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace dataNascimento
{
    class DataNascimento
    {
        static void Main(string[] args)
        {


            Console.WriteLine("---------- DATA DE NASCIMENTO ----------");

            string nome;
            double idade, dataNascimento, anoAtual;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            idade = double.Parse(Console.ReadLine());

            Console.Write("Digite o ano atual: ");
            anoAtual = double.Parse(Console.ReadLine());

            dataNascimento = anoAtual - idade;

            Console.WriteLine(nome + ", você nasceu em " + dataNascimento);
        }
    }
}