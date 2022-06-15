// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace vetorNotasAlunos
{
    class VetorNotasAlunos
    {
        static void Main(string[] args)
        {


            Console.WriteLine("---------- NOTAS ALUNOS ----------");

            string[] aluno;
            string[] notaAluno;

            Console.Write("Digite os nomes dos alunos, separados por vírgula: ");
            aluno = Console.ReadLine().Split(',');

            Console.Write("Digite as notas dos alunos, respectivamente: ");
            notaAluno = Console.ReadLine().Split(',');

            Console.WriteLine("--NOME--NOTA--");
            Console.WriteLine(aluno[0] + ": " + notaAluno[0]);
            Console.WriteLine(aluno[1] + ": " + notaAluno[1]);
            Console.WriteLine(aluno[2] + ": " + notaAluno[2]);
        }
    }
}