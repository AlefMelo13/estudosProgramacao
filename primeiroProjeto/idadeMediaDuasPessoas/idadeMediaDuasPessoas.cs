// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace idadeMediaDuasPessoas
{
    class IdadeMediaDuasPessoas
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- MÉDIA DE IDADE DE DUAS PESSOAS ----------");

            string nomePessoa1, nomePessoa2;
            double idadePessoa1, idadePessoa2, idadeMedia;

            Console.Write("Digite o nome da primeira pessoa: ");
            nomePessoa1 = Console.ReadLine();

            Console.Write("Digite a idade da primeira pessoa: ");
            idadePessoa1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o nome da segunda pessoa: ");
            nomePessoa2 = Console.ReadLine();

            Console.Write("Digite a idade da segunda pessoa: ");
            idadePessoa2 = double.Parse(Console.ReadLine());

            idadeMedia = (idadePessoa1 + idadePessoa2) / 2;

            Console.WriteLine("A idade média de " + nomePessoa1 + " e " + nomePessoa2 + " é " + idadeMedia.ToString("F1") + " anos!");
        }
    }
}