
namespace ContratoCompra.Services
{
    public class ServicoPayPal : IServicoPagamento
    {
        private const double JurosSimples = 0.02;
        private const double JurosMensal = 0.01;

        public double TaxaPagamento(double valorParcela)
        {
            return valorParcela * JurosSimples;
        }

        public double TaxaSimples(double valorParcela, int quantidadeParcelas)
        {
            return valorParcela * JurosMensal * quantidadeParcelas;
        }
    }
}