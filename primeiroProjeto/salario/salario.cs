// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace salario
{
    class Salario
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- SALÁRIO ----------");

            string nome;
            double horasTrabalhadasMes, valorHora, salario;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a quantidade de horas trabalhadas no mês: ");
            horasTrabalhadasMes = double.Parse(Console.ReadLine());

            Console.Write("Quanto você ganha por hora: ");
            valorHora = double.Parse(Console.ReadLine());

            salario = double.Parse((horasTrabalhadasMes * valorHora).ToString("F2"));

            Console.WriteLine(nome + ", seu salário total é: R$" + salario.ToString("F2"));
        }
    }
}