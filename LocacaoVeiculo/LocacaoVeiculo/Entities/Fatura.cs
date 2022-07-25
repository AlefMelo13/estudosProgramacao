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
            return "Pagamento Básico: " + PagamentoBasico.ToString("F2")
                 + "\nTaxa: " + Taxa.ToString("F2")
                 + "\nPagamento Total: " + PagamentoTotal.ToString("F2");
        }
    }
}