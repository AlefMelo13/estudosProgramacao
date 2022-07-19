namespace EtiquetaProduto.Entities
{
    class Produto
    {
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }

        public Produto(string nomeProduto, double precoProduto)
        {
            NomeProduto = nomeProduto;
            PrecoProduto = precoProduto;
        }

        public virtual string EtiquetaPreco()
        {
            return
            NomeProduto + ", R$" + PrecoProduto;
        }
    }
}