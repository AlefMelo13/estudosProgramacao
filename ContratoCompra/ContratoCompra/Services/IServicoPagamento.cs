namespace ContratoCompra.Services
{
    public interface IServicoPagamento
    {
        double TaxaPagamento(double valorParcela);
        double TaxaSimples(double valorParcela, int quantidadeParcelas);
    }
}