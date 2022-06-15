// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace totalVenda
{
    class TotalVenda
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- TOTAL VENDA ----------");

            string nomeProduto1, nomeProduto2;
            double quantidadeProduto1, quantidadeProduto2, valorUnitarioProduto1, valorUnitarioProduto2, totalVenda;

            Console.Write("Digite o nome do primeiro produto: ");
            nomeProduto1 = Console.ReadLine();

            Console.Write("Digite a quantidade comprada de " + nomeProduto1 + " : ");
            quantidadeProduto1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário de " + nomeProduto1 + " : ");
            valorUnitarioProduto1 = double.Parse(Console.ReadLine());

            //INFORMAÇÕES DO PRODUTO 2

            Console.Write("Digite o nome do segundo produto: ");
            nomeProduto2 = Console.ReadLine();

            Console.Write("Digite a quantidade comprada de " + nomeProduto2 + " : ");
            quantidadeProduto2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário de " + nomeProduto2 + " : ");
            valorUnitarioProduto2 = double.Parse(Console.ReadLine());

            totalVenda = quantidadeProduto1 * valorUnitarioProduto1 + quantidadeProduto2 * valorUnitarioProduto2;

            Console.WriteLine("O total da venda é: R$" + totalVenda.ToString("F2"));
        }
    }
}