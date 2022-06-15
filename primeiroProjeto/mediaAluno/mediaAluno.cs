// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace mediaAluno
{
    class MediaAluno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- MÉDIA ALUNO ----------");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite sua segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            Console.WriteLine(nome + " sua média é: " + media.ToString("F2"));
        }
    }
}