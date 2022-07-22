using SaqueConta.Entities;
using SaqueConta.Entities.Exceptions;

namespace SaqueConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- SAQUE CONTA ----------");
            Console.WriteLine();

            Console.WriteLine("Digite os dados da conta:");
            Console.WriteLine();

            Console.Write("Número: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Titular: ");
            string titularConta = Console.ReadLine();

            Console.Write("Saldo Inicial: ");
            double saldoConta = double.Parse(Console.ReadLine());

            Console.Write("Limite de Saque:");
            double limiteSaque = double.Parse(Console.ReadLine());

            Conta conta = new Conta(numeroConta, titularConta, saldoConta, limiteSaque);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta.ToString());

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
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Deseja efetuar um saque(s/n)? ");
            resposta = Console.ReadLine();

            if (resposta == "s" || resposta == "S")
            {
                Console.WriteLine();
                Console.Write("Valor do saque: ");
                double valorSaque = double.Parse(Console.ReadLine());

                try
                {
                    conta.Saque(valorSaque);
                    Console.WriteLine();

                    Console.WriteLine("Saldo Atualizado:");
                    Console.WriteLine(conta.ToString());
                }

                catch (DomainException e)
                {
                    Console.WriteLine();
                    Console.WriteLine("Erro: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine(conta.ToString());
            }
        }
    }
}