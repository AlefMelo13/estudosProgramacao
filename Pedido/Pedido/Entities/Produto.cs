namespace PedidoVenda.Entities
{
    public class Produto
    {
        public int CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal PrecoProduto { get; set; }
        public int QuantidadeProduto { get; set; }

        public Produto()
        {
        }

        public Produto(int codigoProduto, string descricaoProduto, decimal precoProduto, int quantidadeProduto)
        {
            CodigoProduto = codigoProduto;
            DescricaoProduto = descricaoProduto;
            PrecoProduto = precoProduto;
            QuantidadeProduto = quantidadeProduto;
        }

        public decimal TotalProduto()
        {
            return QuantidadeProduto * PrecoProduto;
        }

        public override string ToString()
        {
            return "Código: " + CodigoProduto
                 + "\nDescrição: " + DescricaoProduto
                 + "\nPreço: " + PrecoProduto
                 + "\nQuantidade: " + QuantidadeProduto;
        }
    }
}