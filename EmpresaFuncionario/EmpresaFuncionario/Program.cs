using System.Collections.Generic;
using EmpresaFuncionario.Entities;

namespace EmpresaFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- EMPRESA FUNCIONÁRIOS ----------");

            Console.Write("Quantos funcionários serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");

            List<Funcionario> funcionario = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite os dados do funcionario {i}: ");
                Console.WriteLine();

                Console.Write("O funcionário é terceirizado(s/n)? ");
                string resposta = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas trabalhadas: ");
                int horasTrabalhadas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine());

                if (resposta == "s" || resposta == "S")
                {
                    Console.Write("Despesa adicional: ");
                    double despesaAdicional = double.Parse(Console.ReadLine());

                    funcionario.Add(new FuncionarioTerceirizado(nome, horasTrabalhadas, valorHora, despesaAdicional));
                }
                else
                {
                    funcionario.Add(new Funcionario(nome, horasTrabalhadas, valorHora));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Pagamentos:");

            foreach (Funcionario fun in funcionario)
            {
                Console.WriteLine(fun.Nome + ": R$" + fun.Pagamento().ToString("F2"));
            }
        }
    }
}