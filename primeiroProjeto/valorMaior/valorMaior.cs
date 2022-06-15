// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace valorMaior
{
    class ValorMaior
    {

        //MAIOR VALOR ENTRE TRÊS NÚMEROS (INCOMPLETO)
        static void Main(string[] args)
        {
            Console.WriteLine("---------- NÚMERO MAIOR ----------");

            int numero1, numero2, numero3, numeroMaior;

            Console.Write("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            numero3 = int.Parse(Console.ReadLine());

            numeroMaior = (numero1 + numero2 + numero3) * (numero1 - numero2) / 2;

            Console.Write("O número maior é: " + numeroMaior);
        }
    }
}