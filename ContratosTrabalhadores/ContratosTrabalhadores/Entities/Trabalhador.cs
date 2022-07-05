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

        public double Ganho(int ano, int mes)
        {
            double soma = BaseSalario;
            foreach (HoraContrato contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotalContrato();
                }
            }

            return soma;
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                  +"\r\nNível: " + Nivel
                  +"\r\nBase Salário: " + BaseSalario
                  +"\r\nDepartamento: " + Departamento;
        }
    }
}