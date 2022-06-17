using System;
using System.Globalization;

namespace AumentoFuncionario
{
    class AumentoFuncionario
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- AUMENTO DE SALÁRIO DE FUNCIONÁRIO ----------");

            //ENTRADA DE DADOS DO FUNCIONÁRIO
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite os dados do funcionário:");

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Os dados cadastrados são: " + funcionario);

            //CÁLCULO DO AUMENTO DE SALÁRIO
            Console.Write("Digite a porcentagem de aumento de salário: ");
            double porcentagemAumento = double.Parse(Console.ReadLine());
            funcionario.Aumento(porcentagemAumento);

            Console.WriteLine("Dados atualizados: " + funcionario);
        }
    }
}