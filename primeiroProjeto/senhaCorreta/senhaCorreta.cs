// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace senhaCorreta
{
    class SenhaCorreta
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- SENHA CORRETA ----------");

            int senha;

            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2022)
            {
                Console.WriteLine("SENHA INCORRETA!");
                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
        }
    }
}