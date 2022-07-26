using System;
using LocacaoVeiculo.Entities;

namespace LocacaoVeiculo
{
    public class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine("---------- ALUGUEL DE CARRO ----------");
            Console.WriteLine();

            Console.WriteLine("Digite os dados do aluguel:");
            Console.WriteLine();

            Console.Write("Modelo Carro: ");
            string modeloCarro = Console.ReadLine();
            Console.Write("Data retirada(dd/MM/yyyy hh:mm): ");
            DateTime dataRetirada = DateTime.Parse(Console.ReadLine());
            Console.Write("Data retorno(dd/MM/yyyy hh:mm): ");
            DateTime dataRetorno = DateTime.Parse(Console.ReadLine());
            Console.Write("Preço por hora: ");
            double valorHora = double.Parse(Console.ReadLine());
            Console.Write("Preço por dia: ");
            double valorDia = double.Parse(Console.ReadLine());

            AluguelCarro aluguelCarro = new AluguelCarro(dataRetirada, dataRetorno, new Veiculo(modeloCarro));

            Console.WriteLine();


        }
    }
}