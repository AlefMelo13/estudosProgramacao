namespace EmpresaFuncionario.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }

        public Funcionario(string nome, int horasTrabalhadas, double valorHora)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorHora = valorHora;
        }

        public virtual double Pagamento()
        {
            return HorasTrabalhadas * ValorHora;
        }
    }
}