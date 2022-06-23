using System;
using System.Globalization;

namespace ContaBancaria
{
    class ContaBancaria
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- CONTA BANCÁRIA ----------");

            Conta conta;

            Console.Write("Digite o número da conta: ");
            double numeroConta = double.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial(s/n): ");
            string resposta = Console.ReadLine();

            //ESTRUTURA DE CONDIÇÃO PARA DEPÓSITO E SAQUE
            if (resposta == "s" || resposta == "S")
            {
                Console.Write("Digite o valor a ser depositado: ");
                double valorDeposito = double.Parse(Console.ReadLine());
                conta = new Conta(titular, numeroConta, valorDeposito);
            }
            else
            {
                conta = new Conta(titular, numeroConta);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            //DEPÓTITO DE DINHEIRO
            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.SetDeposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            //SAQUE DE DINHEIRO
            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta.SetSaque(saque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}