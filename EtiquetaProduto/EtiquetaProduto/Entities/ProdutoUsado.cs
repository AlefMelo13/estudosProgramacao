namespace EtiquetaProduto.Entities
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado (string nomeProduto, double precoProduto, DateTime dataFabricacao) : base (nomeProduto, precoProduto)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string EtiquetaPreco()
        {
            return
            NomeProduto + "(Usado), R$" + PrecoProduto + $", (Data Fabricação: {DataFabricacao})";
        }
    }
}