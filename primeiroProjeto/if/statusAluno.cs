// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace statusAluno
{
    class StatusAluno
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- STATUS ALUNO ----------");

            string nomeAluno;
            double nota1, nota2, notaFinal;

            Console.Write("Digite seu nome: ");
            nomeAluno = Console.ReadLine();

            Console.Write("Digite sua nota do 1º sementre: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite sua nota do 2º sementre: ");
            nota2 = double.Parse(Console.ReadLine());

            notaFinal = nota1 + nota2;

            Console.WriteLine(nomeAluno + ", sua nota final é: " + notaFinal.ToString("F1"));

            if (notaFinal < 60.00)
            {
                Console.WriteLine("Você foi REPROVADO!");
            }
            else
            {
                Console.WriteLine("Você foi APROVADO!");
            }
        }
    }
}