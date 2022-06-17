using System;
using System.Globalization;

namespace StatusAluno
{
    class StatusAluno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- STATUS ALUNO ----------");

            Aluno aluno = new Aluno();

            //ENTRADA DE DADOS DO ALUNO
            Console.WriteLine("Digite os dados do aluno:");
            Console.WriteLine();
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Agora entre com as notas do aluno");
            Console.Write("Nota01: ");
            aluno.Nota01 = double.Parse(Console.ReadLine());

            Console.Write("Nota02: ");
            aluno.Nota02 = double.Parse(Console.ReadLine());

            Console.Write("Nota03: ");
            aluno.Nota03 = double.Parse(Console.ReadLine());

            //RETORNA A NOTA FINAL DO ANO
            Console.WriteLine("Nota Final: " + aluno.NotaFinal().ToString("F2"));

            //VERIFICA STATUS DO ALUNO
            if (aluno.NotaFinal() > 60)
            {
                Console.WriteLine("ALUNO APROVADO!");
            }
            else
            {
                Console.WriteLine("ALUNO REPROVADO");
                Console.WriteLine("Faltam " + aluno.RestoNota() + " pontos para ser aprovado");
            }
        }
    }
}