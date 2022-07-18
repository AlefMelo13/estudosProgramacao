using EtiquetaProduto.Entities;

namespace EtiquetaProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- LISTA DE PRODUTOS ----------");
            Console.WriteLine();

            List<Produto> produto = new List<Produto>();

            Console.Write("Quantos produtos deseja adicionar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Produto {i}:");
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                string resposta = Console.ReadLine();

                Console.Write("Nome: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço: ");
                double precoProduto = double.Parse(Console.ReadLine());

                if(resposta == "u" || resposta == "U")
                {
                    Console.Write("Data Fabricação: ");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

                    produto.Add(new ProdutoUsado(nomeProduto, precoProduto, dataFabricacao));
                }
                if (resposta == "i" || resposta == "I")
                {
                    Console.Write("Taxa Alfandega: ");
                    double taxaAlfandega = double.Parse(Console.ReadLine());

                    produto.Add(new ProdutoImportado(nomeProduto, precoProduto, taxaAlfandega));
                }
                if (resposta == "c" || resposta == "C")
                {
                    produto.Add(new Produto(nomeProduto, precoProduto));
                }
            }
            Console.WriteLine();

            Console.WriteLine("Etiquetas de Produtos:");
            Console.WriteLine();

            foreach(Produto prod in produto)
            {
                Console.WriteLine(prod.EtiquetaPreco());
            }
        }
    }
}