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
            int searchId = int.Parse(Console.ReadLine());
            Produto alteraQuantidade = produto.Find(x => x.Codigo == searchId);

            if (alteraQuantidade != null)
            {
                Console.Write("Digite a quantidade a ser adicionada: ");
                int quantAdiciona = int.Parse(Console.ReadLine());

                alteraQuantidade.AdicionaProduto(quantAdiciona);
            }
            else
            {
                Console.WriteLine("Código inválido!");
            }

            Console.WriteLine();

            Console.WriteLine("Lista de produtos atualizada: ");

            foreach (Produto obj in produto)
            {
                Console.WriteLine(obj);
            }

            //ALTERA O PREÇO DE UM PRODUTO
            Console.WriteLine();

            Console.Write("Digite o código do produto para alterar o preço: ");
            int serachId = int.Parse(Console.ReadLine());
            Produto alteraPreco = produto.Find(x => x.Codigo == serachId);

            if (alteraPreco != null)
            {
                Console.WriteLine($"Digite o novo preço do produto {searchId}: ");
                int novoPreco = int.Parse(Console.ReadLine());
                alteraPreco.AlteraPreco(novoPreco);
            }
            else
            {
                Console.WriteLine("Código inválido!");
            }

            Console.WriteLine();

            Console.WriteLine("Lista de produtos atualizada: ");

            foreach (Produto obj in produto)
            {
                Console.WriteLine(obj);
            }
        }
    }
}