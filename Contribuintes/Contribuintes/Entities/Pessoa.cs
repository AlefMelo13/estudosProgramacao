namespace Contribuintes.Entities
{
    abstract class Pessoa
    {
        public string NomePessoa { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa (string nomePessoa, double rendaAnual)
        {
            NomePessoa = nomePessoa;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
    }
}