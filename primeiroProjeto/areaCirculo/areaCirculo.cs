// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace areaCirculo
{
    class AreaCirculo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- ÁREA DO CÍRCULO ----------");

            double pi, area;
            pi = 3.14159;

            Console.Write("Digite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A área do círculo é: " + area);
        }
    }
}