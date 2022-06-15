// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace volumeEsfera
{
    class VolumeEsfera
    {

        //FÓRMLA VOMULE ESFERA: (4/3) * pi * R3
        static void Main(string[] args)
        {
            Console.WriteLine("---------- VOLUME DE UMA ESFERA ----------");

            double raio, pi, i, volumeEsfera;

            pi = 3.14159;
            i = 4.0/3;

            Console.Write("Digite o raio da esfera: ");
            raio = double.Parse(Console.ReadLine());

            volumeEsfera = i * pi * Math.Pow(raio, 3);

            Console.Write("O volume da esfera é: " + volumeEsfera.ToString("F2"));
        }
    }
}