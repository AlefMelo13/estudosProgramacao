namespace Contribuintes.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica (string nomePessoa, double rendaAnual, int numeroFuncionarios) : base (nomePessoa, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Imposto()
        {
            double imposto = 0.0;
            if (NumeroFuncionarios > 10)
            {
                imposto = RendaAnual * 14 / 100;
            }
            if (NumeroFuncionarios <= 10)
            {
                imposto = RendaAnual * 16 / 100;
            }

            return imposto;
        }
    }
}