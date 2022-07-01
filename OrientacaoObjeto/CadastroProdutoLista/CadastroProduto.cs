using System.Globalization;

namespace CadastroProdutoLista
{

    internal class CadastroProduto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- LISTA DE CADASTRO DE PRODUTO ----------");

            Console.Write("Quantos produtos deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            List<Produto> produto = new List<Produto>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("-----------------------------");

                Console.Write($"Digite o código do produto {i+1}: ");
                int codigo = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine());

                Console.Write("Digite o quantidade do produto: ");
                int quantidade = int.Parse(Console.ReadLine());

                produto.Add(new Produto(codigo, nome, preco, quantidade));
            }

            Console.WriteLine();

            //EXIBE A LISTA DE PRODUTOS CADASTRADA
            foreach (Produto obj in produto)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            //ADICIONA QUANTIDADE AO PRODUTO
            Console.Write("Digite o código do produto para adicionar quantidade: ");
            int idAdicionaQuantidade = int.Parse(Console.ReadLine());
            Produto produtoAlteraQuantidade = produto.Find(x => x.Codigo == idAdicionaQuantidade);

            if (produtoAlteraQuantidade != null)
            {
                Console.Write("Digite a quantidade a ser adicionada: ");
                int quantAdiciona = int.Parse(Console.ReadLine());

                produtoAlteraQuantidade.AdicionaProduto(quantAdiciona);
            }
            else
            {
                Console.WriteLine("Código inválido!");
            }

            Console.WriteLine();

            //EXIBE A LISTA DE PRODUTOS ATUALIZADA
            Console.WriteLine("Lista de produtos atualizada: ");

            foreach (Produto obj in produto)
            {
                Console.WriteLine(obj);
            }

            //ALTERA O PREÇO DE UM PRODUTO
            Console.WriteLine();

            Console.Write("Digite o código do produto para alterar o preço: ");
            int idAlteraPreco = int.Parse(Console.ReadLine());
            Produto produtoAlteraPreco = produto.Find(x => x.Codigo == idAlteraPreco);

            if (produtoAlteraPreco != null)
            {
                Console.Write($"Digite o novo preço do produto {idAlteraPreco}: ");
                double novoPreco = double.Parse(Console.ReadLine());
                produtoAlteraPreco.AlteraPreco(novoPreco);
            }
            else
            {
                Console.WriteLine("Código inválido!");
            }

            Console.WriteLine();

            //EXIBE A LISTA DE PRODUTOS ATUALIZADA
            Console.WriteLine("Lista de produtos atualizada: ");

            foreach (Produto obj in produto)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            //REMOVENDO PRODUTO DA LISTA
            Console.Write("Digite o código do produto a ser removido: ");
            int idRemocaoProduto = int.Parse(Console.ReadLine());

            Produto removeProduto = produto.Find(x => x.Codigo == idRemocaoProduto);

            if (removeProduto != null)
            {
                produto.Remove(removeProduto);
                Console.WriteLine();
                Console.WriteLine("------- Produto Removido! -------");
            }
            else
            {
                Console.WriteLine("Código inválido!");
            }

            Console.WriteLine();

            //EXIBE A LISTA DE PRODUTOS ATUALIZADA
            Console.WriteLine("Lista de produtos atualizada: ");

            foreach (Produto obj in produto)
            {
                Console.WriteLine(obj);
            }
        }
    }
}