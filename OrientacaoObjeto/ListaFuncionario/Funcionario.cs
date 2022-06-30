using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFuncionario
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }

        public void AcrescimoSalario(double percentual)
        {
            Salario += Salario * percentual / 100;
        }

        public override string ToString()
        {
            return "ID: " + Id + "; Nome: " + Nome + ", Salário: R$" + Salario.ToString("F2");
        }
    }
}
