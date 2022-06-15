using AreaTriangulo;
using System;
using System.Globalization;

namespace AraTriangulo
{
    class AreaTriangulo
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            double areaX, areaY;

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


            areaX = x.Area();

            areaY = y.Area();

            Console.WriteLine("A área do triangulo X é: " + areaX.ToString("F4"));

            Console.WriteLine("A área do triangulo Y é: " + areaY.ToString("F4"));

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