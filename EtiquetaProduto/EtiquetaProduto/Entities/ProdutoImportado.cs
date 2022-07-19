namespace EtiquetaProduto.Entities
{
    class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado(string nomeProduto, double precoProduto, double taxaAlfandega) : base (nomeProduto, precoProduto)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public double PrecoTotal()
        {
            return PrecoProduto + TaxaAlfandega;
        }
        public override string EtiquetaPreco()
        {
            return
            NomeProduto + ", R$" + PrecoTotal().ToString("F2") + $", (Taxa Alfandega: R${TaxaAlfandega})";
        }
    }
}