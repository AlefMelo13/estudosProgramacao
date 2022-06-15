// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace TabuadaMultiplicacao
{
    class TabuadaMultiplicacao
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- TABUADA MULTIPLICAÇÃO ----------");

            int i, numero, resultado;
            string repetir;

            do
            {
                Console.Write("Digite o valor da tabuada a ser exibida: ");
                numero = int.Parse(Console.ReadLine());

                //PARA i = 1, DE 1 ATÉ 10 FAÇA (i++ ACRESCENTA 1 EM i)
                for (i = 1; i <= 10; i++)
                {
                    resultado = i * numero;
                    Console.WriteLine(i + " x " + numero + " = " + resultado);
                }
                Console.WriteLine();
                Console.Write("Deseja calcular outro número(s/n?) ");
                repetir = Console.ReadLine();

            }
            while (repetir == "s");
        }
    }
}