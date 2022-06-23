namespace VetorProduto
{
    internal class VetorProduto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- CADASTRO DE PRODUTO E PREÇO ----------");

            Console.WriteLine("Digite a quantidade de produto a ser cadastrada: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] produto = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine());

                produto[i] = new Produto { Nome = nome, Preco = preco };
            }

            for (int i =0; i < n; i++)
            {
                Console.WriteLine(produto[i]);
            }

        }
    }
}