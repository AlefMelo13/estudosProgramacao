// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace salarioComposto
{
    class SalarioComposto
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- SALÁRIO COMPOSTO ----------");

            string nomeVendedor;
            double salarioFixo, vendasMes, salarioFinal, comissao;

            Console.Write("Digite seu nome: ");
            nomeVendedor = Console.ReadLine();

            Console.Write("Digite seu salário fixo: ");
            salarioFixo = double.Parse(Console.ReadLine());

            Console.Write("Digite seu total de vendas no mês, em R$: ");
            vendasMes = double.Parse(Console.ReadLine());

            comissao = vendasMes * 15 / 100;

            salarioFinal = salarioFixo + comissao;

            Console.WriteLine(nomeVendedor + ", seu salário final é: R$" + salarioFinal.ToString("F2"));
        }
    }
}