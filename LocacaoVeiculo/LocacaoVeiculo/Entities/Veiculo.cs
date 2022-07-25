namespace LocacaoVeiculo.Entities
{
    public class Veiculo
    {
        public string ModeloVeiculo { get; set; }

        public Veiculo(string modeloVeiculo)
        {
            ModeloVeiculo = modeloVeiculo;
        }
    }
}