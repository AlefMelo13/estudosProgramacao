namespace LocacaoVeiculo.Entities
{
    public class AluguelCarro
    {
        public DateTime DataRetirada { get; set; }
        public DateTime DataRetorno { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public AluguelCarro(DateTime dataRetirada, DateTime dataRetorno, Veiculo veiculo)
        {
            DataRetirada = dataRetirada;
            DataRetorno = dataRetorno;
            Veiculo = veiculo;
        }
    }
}