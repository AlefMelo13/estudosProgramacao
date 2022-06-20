using System;
using System.Globalization;

namespace ContaBancaria
{
    class ContaBancaria
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- CONTA BANCÁRIA ----------");

            Console.Write("Digite o número da conta: ");
            double numeroConta = double.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string cliente = Console.ReadLine();

            Console.Write("Haverá depósito inicial(s/n): ");
            string resposta = Console.ReadLine();

            if (resposta == "s")
            {
                Console.Write("Digite o valor a ser depositado: ");
                double valorDeposito = double.Parse(Console.ReadLine());
            }
                Conta conta = new Conta();

                Console.WriteLine(conta);
        }
    }
}