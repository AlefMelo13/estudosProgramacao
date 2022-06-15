// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace consumoCombustivel
{
    class ConsumoCombustivel
    {

        //CONSUMO DE COMBUSTÍVEL POR UM VEÍCULO
        static void Main(string[] args)
        {

            Console.WriteLine("---------- NÚMERO MAIOR ----------");

            double distanciaTotal, consumoTotal, consumoMedio;

            Console.Write("Digite a distância total percorrida: ");
            distanciaTotal = double.Parse(Console.ReadLine());

            Console.Write("Digite o combustível total consumido: ");
            consumoTotal = double.Parse(Console.ReadLine());

            consumoMedio = distanciaTotal / consumoTotal;

            Console.Write("Seu consumo médio de combustível foi: " + consumoMedio.ToString("F3") + "Km/L");
        }
    }
}