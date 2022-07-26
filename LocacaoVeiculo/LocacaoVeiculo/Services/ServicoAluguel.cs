using LocacaoVeiculo.Entities;

namespace LocacaoVeiculo.Services
{
    public class ServicoAluguel
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private IServicoTaxa _taxaServico;

        public ServicoAluguel(double precoPorHora, double precoPorDia, IServicoTaxa taxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaServico = taxaServico;
        }

        public void ProcessaFatura(AluguelCarro aluguelCarro)
        {
            TimeSpan duracao = aluguelCarro.DataRetorno.Subtract(aluguelCarro.DataRetirada);

            double pagamentoBasico = 0.0;

            if(duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _taxaServico.Taxa(pagamentoBasico);

            aluguelCarro.Fatura = new Fatura(pagamentoBasico, taxa);
        }
    }
}