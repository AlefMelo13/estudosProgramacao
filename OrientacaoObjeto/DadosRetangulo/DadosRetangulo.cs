using System;
using System.Globalization;

namespace DadosRetangulo
{
    class DadosRetangulo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- DADOS RETÂNGULO ----------");

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Digite os dados do retângulo:");
            Console.Write("Base: ");
            retangulo.Base = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("A área do retângulo é: " + retangulo.Area().ToString("F2"));

            Console.WriteLine("O perimetro do retângulo é: " + retangulo.Perimetro().ToString("F2"));

            Console.WriteLine("A diagonal do retângulo é: " + retangulo.Diagonal().ToString("F2"));
        }
    }
}