// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace VetorNomePessoas
{
    class VetorNomePessoas
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- LISTA DE NOMES DE PESSOAS ----------");

            string[] nome;
            int i;
            nome = new string[5];

            //PARA i = 1, DE 1 ATÉ 10 FAÇA (i++ ACRESCENTA 1 EM i)
            for (i = 0; i <= 4; i++)
            {
                Console.Write("Digite um nome para lista: ");
                nome[i] = Console.ReadLine();
            }

            Console.WriteLine("LISTA DE NOMES");

            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("Nome " + i + ": " + nome[i]);
            }
        }
    }
}