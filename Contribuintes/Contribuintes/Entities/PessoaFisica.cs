using Contribuintes.Entities;

namespace Contribuintes.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }

        public PessoaFisica (string nomePessoa, double rendaAnual, double gastosSaude) : base (nomePessoa, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double Imposto()
        {
            double imposto = 0.0;
            if (RendaAnual < 20000)
            {
                imposto = RendaAnual * 15 / 100;
            }
            if (RendaAnual >= 20000)
            {
                imposto = RendaAnual * 25 / 100;
            }
            if (GastosSaude >0)
            {
                imposto -= ( GastosSaude * 50 / 100);
            }

            return imposto;
        }
    }
}