using System;
using PedidoVenda.Entities;
using PedidoVenda.Services;
using System.Collections.Generic;

namespace PedidoVenda
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- PEDIDO ----------");
            Console.WriteLine();
            Cliente cliente = new Cliente();

            Console.WriteLine("Digite os dados do cliente do pedido: ");
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("CPF ou CNPJ: ");
            string cpfCnpj = Console.ReadLine();
            Console.Write("Limite de crédito: ");
            decimal limiteCreditoCliente = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            cliente = new Cliente(nomeCliente, cpfCnpj, limiteCreditoCliente);

            Console.Write("Quantos Produtos Deseja Adicionar no Pedido? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Produto> produto = new List<Produto>();

            Console.WriteLine("Dados do Produto: ");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("---------------------------");
                Console.Write($"Código Produto {i}: ");
                int codigoProduto = int.Parse(Console.ReadLine());
                Console.Write("Descrição Produto: ");
                string descricaoProduto = Console.ReadLine();
                Console.Write("Preço Produto: ");
                decimal precoProduto = decimal.Parse(Console.ReadLine());
                Console.Write("Quantidade Produto: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());

                produto.Add(new Produto(codigoProduto, descricaoProduto, precoProduto, quantidadeProduto));
            }
            Console.WriteLine("================================");
            Console.WriteLine("Cliente:");
            Console.WriteLine(cliente.ToString());
            Console.WriteLine("================================");

            Console.WriteLine("Produtos do Pedido: ");
            foreach (Produto prod in produto)
            {
                Console.WriteLine(prod.ToString());
            }
        }
    }
}