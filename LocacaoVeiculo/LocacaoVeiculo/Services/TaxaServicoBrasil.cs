namespace LocacaoVeiculo.Services
{
    public class TaxaServicoBrasil : IServicoTaxa
    {
        public double TaxaAluguel(double pagamentoBasico)
        {
            double PorcentagemNormal = 20.0 / 100.0;
            double PorcentagemDesonto = 15.0 / 100.0;

            if (pagamentoBasico <= 100)
            {
                return pagamentoBasico * PorcentagemNormal;
            }
            else
            {
                return pagamentoBasico * PorcentagemDesonto;
            }
        }
    }
}