// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace somaValores
{
    class SomaValores
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- SOMA DE DOIS NÚMEROS ----------");

            Console.Write("Digite um número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int numero2 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;

            Console.WriteLine("A soma de " + numero1 + " + " + numero2 + " é: " + soma);
        }
    }
}