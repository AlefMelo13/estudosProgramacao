using ContratosTrabalhadores.Entities.Enums;

namespace ContratosTrabalhadores.Entities
{
    internal class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double BaseSalario { get; set; }
        public Departamento Departamento { get; set; }
        public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>();

        //CONSTRUTORES
        public Trabalhador()
        {
        }

        public Trabalhador(string nome, NivelTrabalhador level, double baseSalario, Departamento departamento)
        {
            Nome = nome;
            Nivel = level;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }

        public void AddContrato(HoraContrato contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoveContrato(HoraContrato contrato)
        {
            Contratos.Remove(contrato);
        }
    }
}