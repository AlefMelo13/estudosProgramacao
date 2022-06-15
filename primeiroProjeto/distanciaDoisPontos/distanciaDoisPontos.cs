// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace distanciaDoisPontos
{
    class DistanciaDoisPontos
    {

        //FÓRMLA VOMULE ESFERA: (4/3) * pi * R3
        static void Main(string[] args)
        {
            Console.WriteLine("---------- DISTÂNCIA ENTRE DOIS PONTOS ----------");

            double x1, x2, y1, y2, distancia, pontox, pontoy, somaPontos;

            Console.Write("Digite o valor de x1: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de y1: ");
            y1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de x2: ");
            x2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de y2: ");
            y2 = double.Parse(Console.ReadLine());

            //FÓRMULA DE CÁLCULO DA DISTÂNCIA ENTRE DOIS PONTOS: RAIZ (x2-x1)² + (y2-y1)²
            //CÁLCULO DOS DOIS PONTOS x E y 
            pontox = (x2 - x1) * 2;
            pontoy = (y2 - y1) * 2;

            somaPontos = pontox + pontoy;

            distancia = Math.Sqrt(somaPontos);

            Console.Write("A distância entre os dois pontos é: " + distancia.ToString("F4"));
        }
    }
}