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
            Console.Write("Digite o valor do saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            try
            {
                conta.Saque(valorSaque);
                Console.WriteLine();

                Console.WriteLine("Novo Saldo: " + conta.SaldoConta);
            }

            catch (DomainException e)
            {
                Console.WriteLine();
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}