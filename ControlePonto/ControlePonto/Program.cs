using System;
using ControlePonto.Entities;
using System.Collections.Generic;

namespace ControlePonto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- CONTROLE DE PONTO ----------");
            Console.WriteLine();

            Console.WriteLine("=== Cadastro de Empresa ===");
            Console.WriteLine("------------------------");
            Console.Write("Nome Empresa: ");
            string nomeEmpresa = Console.ReadLine();
            Console.Write("CNPJ Empresa: ");
            string cnpjEmpresa = Console.ReadLine();

            Empresa empresa = new Empresa(nomeEmpresa, cnpjEmpresa);
            Console.WriteLine();

            Console.WriteLine("=== Cadastro de Funcionários ===");
            Console.WriteLine("------------------------");

            List<Funcionario> funcionario = new List<Funcionario>();

            Console.Write("Nome Funcionário: ");
            string nomeFuncionario = Console.ReadLine();
            Console.Write("Idade Funcionário: ");
            int idadeFuncionario = int.Parse(Console.ReadLine());
            Console.Write("CPF Funcionário: ");
            string cpfFuncionario = Console.ReadLine();
            Console.Write("Status Funcionário(0=Presente; 1=Ausente): ");
            StatusFuncionario statusFuncionario = (StatusFuncionario)Enum.Parse(typeof(StatusFuncionario), Console.ReadLine());
        }
    }
}