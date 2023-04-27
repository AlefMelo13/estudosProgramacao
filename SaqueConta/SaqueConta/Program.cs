using SaqueConta.Entities;
using SaqueConta.Entities.Exceptions;
using System.ComponentModel.Design;

namespace SaqueConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("---------- CONTA BANCÁRIA ----------");
            Console.WriteLine();

            Conta conta = new Conta();

            Console.WriteLine("Digite os dados da conta:");
            Console.WriteLine();

            int numeroConta = 0;

            while (numeroConta <= 0 || numeroConta == null)
            {
                try
                {
                    Console.Write("Número: ");
                    numeroConta = int.Parse(Console.ReadLine());
                    conta.NumConta(numeroConta);
                }
                catch (DomainException f)
                {
                    Console.WriteLine(f.Message);
                    Thread.Sleep(2000);
                    Console.Clear();
                    Menu();
                }
                catch (FormatException f)
                {
                    Console.WriteLine("Digite um número inteiro!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Menu();
                }
            }

            Console.Write("Titular: ");
            string titularConta = Console.ReadLine();

            Console.Write("Saldo Inicial: ");
            double saldoConta = double.Parse(Console.ReadLine());

            Console.Write("Limite de Saque: ");
            double limiteSaque = double.Parse(Console.ReadLine());

            conta = new Conta(numeroConta, titularConta, saldoConta, limiteSaque);


            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta.ToString());
            Console.WriteLine();

            Console.Write("Deseja fazer um depósito(s/n)? ");
            string resposta = Console.ReadLine();

            if (resposta == "s" || resposta == "S")
            {
                Console.Write("Valor do Depósito: ");
                double valorDeposito = double.Parse(Console.ReadLine());

                conta.Deposito(valorDeposito);

                Console.WriteLine();
                Console.WriteLine("Saldo Atualizado:");
                Console.WriteLine(conta.ToString());
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Continuação do programa...");
            }
            Console.WriteLine();
            Console.Write("Deseja efetuar um saque(s/n)? ");
            resposta = Console.ReadLine();

            if (resposta == "s" || resposta == "S")
            {
                double valorSaque = 0.0;

                while (valorSaque <= 0.0 || valorSaque > saldoConta || valorSaque > limiteSaque)
                {
                    Console.WriteLine();
                    Console.Write("Valor do saque: ");
                    valorSaque = double.Parse(Console.ReadLine());

                    try
                    {
                        conta.Saque(valorSaque);
                        Console.WriteLine();
                        Console.WriteLine("*** Saque Efetuado! ***");
                        Console.WriteLine();

                        Console.WriteLine("Saldo Atualizado:");
                        Console.WriteLine();
                        Console.WriteLine(conta.ToString());
                    }

                    catch (DomainException e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Erro: " + e.Message);
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("*** Programa Finalizado! ***");
                Console.WriteLine();

                Console.WriteLine("Dados da Conta: ");
                Console.WriteLine(conta.ToString());
            }
        }
    }
}