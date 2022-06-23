using System;
using System.Globalization;

namespace CadastroProduto
{
    class CadastroProduto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- CADASTRO DE PRODUTO ---------");


            Console.WriteLine("Digite as informações do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            //ATRIBUIÇÃO DE VALORES AO CONSTRUTOR
            Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados cadastrados com sucesso!");
            Console.WriteLine();

            Console.WriteLine("Dados do Produto cadastrado: ");
            Console.WriteLine(produto);

            Console.WriteLine("O valor total do estoque do produto é: " + produto.ValorTotalEstoque().ToString("F2"));

            Console.WriteLine();

            //ADICIONANDO QUANTIDADE NO ESTOQUE DO PRODUTO

            Console.Write("Digite a quantidade de produtos a ser ADICIONADA ao estoque: ");
            int adicionaQuantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(adicionaQuantidade);

            Console.WriteLine("Dados atualizados do Produto: ");
            Console.WriteLine(produto);

            Console.WriteLine("O valor total do estoque do produto é: " + produto.ValorTotalEstoque().ToString("F2"));

            //REMOVENDO QUANTIDADE NO ESTOQUE DO PRODUTO
            Console.Write("Digite a quantidade de produtos a ser REMOVIDA ao estoque: ");
            int removeQuantidade = int.Parse(Console.ReadLine());
            produto.RemoverProduto(removeQuantidade);

            Console.WriteLine("Dados atualizados do Produto: ");
            Console.WriteLine(produto);

            Console.WriteLine("O valor total do estoque do produto é: " + produto.ValorTotalEstoque().ToString("F2"));

            Console.WriteLine(produto.GetNome());
            Console.WriteLine(produto.GetPreco());
            Console.WriteLine(produto.GetQuantidade());
        }
    }
}