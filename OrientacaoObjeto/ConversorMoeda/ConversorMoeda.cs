using System;
using System.Globalization;

namespace ConversorMoeda
{
    class ConversorMoeda
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- CONVERSOR DE MOEDA ----------");

            Console.Write("Digite a cotação do dólar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de dolar a ser comprado: ");
            double quantiaDolar = double.Parse(Console.ReadLine());

            double total = Conversor.Converte(cotacaoDolar, quantiaDolar);

            Console.WriteLine("Total a receber: " + total.ToString("F2"));
        }
    }
}