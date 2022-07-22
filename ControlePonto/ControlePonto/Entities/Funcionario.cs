using ControlePonto.Entities;

namespace ControlePonto.Entities
{
    public class Funcionario
    {
        public string NomeFuncionario { get; set; }
        public int IdadeFunconario { get; set; }
        public string CpfFuncionario { get; set; }
        public StatusFuncionario StatusFuncionario { get; set; }

        public Funcionario(string nomeFuncionario, int idadeFunconario, string cpfFuncionario, StatusFuncionario statusFuncionario)
        {
            NomeFuncionario = nomeFuncionario;
            IdadeFunconario = idadeFunconario;
            CpfFuncionario = cpfFuncionario;
            StatusFuncionario = statusFuncionario;
        }


    }
}