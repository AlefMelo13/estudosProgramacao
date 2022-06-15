// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace areaRetangulo
{
    class AreaRetangulo
    {
        static void Main(string[] args)
        {

            // INCOMPLETO

            Console.WriteLine("---------- ÁREA DO RETANGULO ----------");

            double baseRetangulo, alturaRetangulo, areaRetangulo, perimetroRetangulo, diagonal;

            Console.Write("Digite a medida da base do retângulo: ");
            baseRetangulo = double.Parse(Console.ReadLine());

            Console.Write("Digite a medida da altura do retângulo: ");
            alturaRetangulo = double.Parse(Console.ReadLine());

            areaRetangulo = baseRetangulo * alturaRetangulo;

            perimetroRetangulo = 2 * (baseRetangulo +  alturaRetangulo);

            diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2.0) + Math.Pow(alturaRetangulo, 2.0));

            Console.WriteLine("A área do retângulo é: " + areaRetangulo.ToString("F4"));

            Console.WriteLine("O perimetro do Retângulo é: " + perimetroRetangulo.ToString("F4"));

            Console.WriteLine("A diagonal do retângulo é: " + diagonal.ToString("F4"));
        }
    }
}