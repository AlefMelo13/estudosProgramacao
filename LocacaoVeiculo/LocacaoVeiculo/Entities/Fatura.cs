namespace LocacaoVeiculo.Entities
{
    public class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        public Fatura(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        public double PagamentoTotal
        {
            get { return PagamentoBasico + Taxa; }
        }

        public override string ToString()
        {
            return "Pagamento Básico: R$" + PagamentoBasico.ToString("F2")
                 + "\nTaxa: R$" + Taxa.ToString("F2")
                 + "\nPagamento Total: R$" + PagamentoTotal.ToString("F2");
        }
    }
}