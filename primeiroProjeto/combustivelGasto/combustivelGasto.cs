// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace combustivelGasto
{
    class CombustivelGasto
    {

        //CONSUMO DE COMBUSTÍVEL POR UM VEÍCULO
        static void Main(string[] args)
        {

            Console.WriteLine("---------- CONSUMO DE COMBUSTÍVEL ----------");

            double tempoGasto, velocidadeMedia, combustivelGasto, consumoCarro;

            consumoCarro = 12;

            Console.Write("Digite o tempo gasto na viagem (em horas): ");
            tempoGasto = double.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade média do veículo (em Km/h): ");
            velocidadeMedia = double.Parse(Console.ReadLine());

            consumoCarro = tempoGasto * velocidadeMedia / consumoCarro;

            Console.Write("Seu carro precisa de " + consumoCarro.ToString("F3") + " litros de gasolina para esta viagem!");
            Console.WriteLine();
        }
    }
}