using System;
using System.Globalization;

namespace CadastroProduto
{
    class CadastroProduto
    {
        static void Main(string[] args) // eu mexi aquio
        {
            Console.WriteLine("---------- CADASTRO DE PRODUTO ---------");

            Produto produto = new Produto();

            Console.WriteLine("Digite as informações do produto");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados cadastrados com sucesso!");
            Console.WriteLine();

            Console.WriteLine($"Nome do produto: {produto.Nome}");
            Console.WriteLine("Preço do produto: " + produto.Preco.ToString("F2"));
            Console.WriteLine($"Quantidade do produto: {produto.Quantidade}");

            Console.WriteLine("O valor total do estoque do produto é: " + produto.ValorTotalEstoque().ToString("F2"));
        }
    }
}