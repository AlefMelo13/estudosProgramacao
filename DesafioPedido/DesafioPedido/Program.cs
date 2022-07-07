using DesafioPedido.Entities;
using DesafioPedido.Entities.Enums;

namespace DesafioPedido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- PEDIDO ----------");

            Console.WriteLine("Digite os dados do cliente:");
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();

            Console.Write("E-mail: ");
            string emailCliente = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            DateTime dateNascimentoCliente = DateTime.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nomeCliente, emailCliente, dateNascimentoCliente);

            Console.Write("Digite o status do pedido: ");
            StatusPedido statusPedido = Enum.Parse<StatusPedido>(Console.ReadLine());

            Pedido pedido = new Pedido(DateTime.Now, cliente, statusPedido);

            Console.Write("Quantos itens tem o pedido? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite os dados do item {i}:");

                Console.Write("Nome Produto: ");
                string nomeProduto = Console.ReadLine();

                Console.Write("Preço Produto: ");
                double precoProduto = double.Parse(Console.ReadLine());

                Console.Write("Quantidade: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());

                Produto produto = new Produto(nomeProduto, precoProduto);

                PedidoItem pedidoItem = new PedidoItem(produto, quantidadeProduto, precoProduto);

                pedido.AdicionaItem(pedidoItem);
            }
            Console.WriteLine();

            Console.WriteLine("Lista de Pedidos:");
            Console.WriteLine();
            
            Console.WriteLine(pedido.ToString());
        }
    }
}