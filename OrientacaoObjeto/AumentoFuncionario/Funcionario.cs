using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentoFuncionario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double Porcentagem;

        public override string ToString()
        {
            return Nome + ", R$" + SalarioLiquido().ToString("F2");
        }
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void Aumento(double porcentagemAumento)
        {
            SalarioBruto = ((porcentagemAumento / 100) * SalarioBruto) + SalarioBruto;
        }
    }
}
