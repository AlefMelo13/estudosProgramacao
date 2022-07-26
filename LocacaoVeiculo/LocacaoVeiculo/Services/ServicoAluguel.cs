using LocacaoVeiculo.Entities;

namespace LocacaoVeiculo.Services
{
    public class ServicoAluguel
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        public ServicoAluguel(double precoPorHora, double precoPorDia)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
        }

        public void ProcessaFatura(AluguelCarro aluguelCarro)
        {

        }
    }
}