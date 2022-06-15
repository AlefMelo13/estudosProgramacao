using System;
using System.Globalization;

namespace CadastroProduto
{
    class CadastroProduto
    {
        static void Main(string[] args)
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

            Console.WriteLine("Dados do Produto cadastrado: ");
            Console.WriteLine(produto);

            Console.WriteLine("O valor total do estoque do produto é: " + produto.ValorTotalEstoque().ToString("F2"));

            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de produtos a ser adicionada ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(quantidade);

            Console.WriteLine("Dados atualizados do Produto: ");
            Console.WriteLine(produto);
        }
    }
}