using System;
using System.Globalization;

namespace PrimeiroProjetoOO
{
    class PrimeiroProjetoOO
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            double areaX, areaY, maiorArea, pX, pY;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            pX = (x.A + x.B + x.C) / 2;

            pY = (y.A + y.B + y.C) / 2;

            areaX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));

            areaY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));

            Console.WriteLine($"A área do triangulo X é: {areaX}");

            Console.WriteLine($"A área do triangulo Y é: {areaY}");

            if (areaX > areaY)
            {
                Console.WriteLine($"A maior área é X: {areaX}");
            }
            else
            {
                Console.WriteLine($"A maior área é Y: {areaY}");
            }
        }
    }
}