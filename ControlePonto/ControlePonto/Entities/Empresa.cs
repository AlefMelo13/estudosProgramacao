using System.Collections.Generic;
using ControlePonto.Entities;

namespace ControlePonto.Entities
{
    public class Empresa
    {
        public string NomeEmpresa { get; set; }
        public string CnpjEmpresa { get; set; }
        public List<Funcionario> FuncionarioEmpresa { get; set; } = new List<Funcionario>();

        public Empresa(string nomeEmpresa, string cnpjEmpresa)
        {
            NomeEmpresa = nomeEmpresa;
            CnpjEmpresa = cnpjEmpresa;
        }
    }
}