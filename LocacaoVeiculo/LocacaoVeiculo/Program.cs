using System;
using LocacaoVeiculo.Entities;
using LocacaoVeiculo.Services;

namespace LocacaoVeiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- ALUGUEL DE CARRO ----------");
            Console.WriteLine();

            Console.WriteLine("Digite os dados do aluguel:");
            Console.WriteLine();

            Console.Write("Modelo Carro: ");
            string modeloCarro = Console.ReadLine();
            Console.Write("Data retirada(dd/MM/yyyy hh:mm): ");
            DateTime dataRetiradaCarro = DateTime.Parse(Console.ReadLine());
            Console.Write("Data retorno(dd/MM/yyyy hh:mm): ");
            DateTime dataRetornoCarro = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite o preço por hora: ");
            double precoPorHora = double.Parse(Console.ReadLine());
            Console.Write("Digite o preço por dia: ");
            double precoPorDia = double.Parse(Console.ReadLine());

            AluguelCarro aluguelCarro = new AluguelCarro(dataRetiradaCarro, dataRetornoCarro, new Veiculo(modeloCarro));

            ServicoAluguel servicoAluguel = new ServicoAluguel(precoPorHora, precoPorDia, new TaxaServicoBrasil());

            servicoAluguel.CriaFatura(aluguelCarro);

            Console.WriteLine();
            Console.WriteLine("FATURA:");
            Console.WriteLine();

            Console.WriteLine(aluguelCarro.Fatura);

        }
    }
}