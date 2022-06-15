using System;
using System.Globalization;

namespace SalarioFuncionario
{
    class SalarioFuncionario
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- SALÁRIO FUNCIONÁRIO ----------");

            Funcionario funcionario1, funcionario2;
            double mediaSalario;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.Write("Digite o nome do primeiro funcionário: ");
            funcionario1.nome = Console.ReadLine();

            Console.Write("Digite o salário do segundo funcionário: ");
            funcionario1.salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o nome do primeiro funcionário: ");
            funcionario2.nome = Console.ReadLine();

            Console.Write("Digite o salário do segundo funcionário: ");
            funcionario2.salario = double.Parse(Console.ReadLine());

            mediaSalario = (funcionario1.salario + funcionario2.salario) / 2;

            Console.WriteLine("A média dos salários dos funcionários é: " + mediaSalario.ToString("F2"));
        }
    }
}