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

            //ESTRUTURA DE CONDIÇÃO PARA DEPÓSITO E SAQUE
            if (resposta == "s")
            {
                Console.Write("Digite o valor a ser depositado: ");
                double valorDeposito = double.Parse(Console.ReadLine());
                Conta conta = new Conta(cliente, numeroConta, valorDeposito);
                Console.WriteLine();
                Console.WriteLine("Dados da conta: " + conta);

                //DEPÓTITO DE DINHEIRO
                Console.WriteLine();
                Console.Write("Digite um valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine());
                conta.SetDeposito(deposito);

                Console.WriteLine("Dados da conta atualizados: " + conta);

                //SAQUE DE DINHEIRO
                Console.WriteLine();
                Console.Write("Digite um valor para saque: ");
                double saque = double.Parse(Console.ReadLine());
                conta.SetSaque(saque);

                Console.WriteLine();
                Console.WriteLine("Dados da conta atualizados: " + conta);
            }
            else
            {
                Conta conta = new Conta(cliente, numeroConta);
                Console.WriteLine(conta);

                //DEPÓSITO DE DINHEIRO
                Console.WriteLine();
                Console.Write("Digite um valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine());
                conta.SetDeposito(deposito);
                Console.WriteLine();
                Console.WriteLine("Dados da conta atualizados: " + conta);

                //SAQUE DE DINHEIRO
                Console.WriteLine();
                Console.Write("Digite um valor para saque: ");
                double saque = double.Parse(Console.ReadLine());
                conta.SetSaque(saque);

                Console.WriteLine();
                Console.WriteLine("Dados da conta atualizados: " + conta);
            }
        }
    }
}