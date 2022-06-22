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

            //ESTRUTURA DE CONDIÇÃO PARA DEPÓSITO INICIAL
            if (resposta == "s")
            {
                Console.Write("Digite o valor a ser depositado: ");
                double valorDeposito = double.Parse(Console.ReadLine());
                Conta conta = new Conta(cliente, numeroConta, valorDeposito);
                Console.WriteLine("Dados da conta: " + conta);
            }
            else
            {
                Conta conta = new Conta(cliente, numeroConta);
                Console.WriteLine(conta);
            }

            //DEPÓSITO DE DINHEIRO EM CONTA
            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());

            Conta conta2 = new Conta(cliente, numeroConta);
            conta2.SetDeposito(deposito);

            Console.WriteLine("Dadoss da conta atualizados: " + conta2);
        }
    }
}