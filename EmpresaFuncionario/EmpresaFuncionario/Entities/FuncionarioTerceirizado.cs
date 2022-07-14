namespace EmpresaFuncionario.Entities
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public FuncionarioTerceirizado(string nome, int horasTrabalhadas, double valorHora, double despesaAdicional) : base(nome, horasTrabalhadas, valorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            base.Pagamento();
            return DespesaAdicional * 110 / 100;
        }
    }
}