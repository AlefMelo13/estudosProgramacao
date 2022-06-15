// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace numeroMaior
{
    class NumeroMaior
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- NÚMERO MAIOR ----------");

            //DECLARAÇÃO DE VARIÁVEIS
            int i, n, cont;
            double[] numero;
            double numeroMaior;
            int posicao;

            posicao = 0;

            //LEITURA DOS DADOS DE QUANTIDADE DE PESSOAS
            Console.Write("Digite a quantidade de números a serem lidos: ");
            n = int.Parse(Console.ReadLine());

            numero = new double[n];

            //ATRIBUIÇÃO DE DADOS NOS VETORES nome, idade e altura
            for (i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i} número: ");
                numero[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("---------- LISTA DE NÚMEROS ----------");

            numeroMaior = 0;
            
            for (i = 0; i < n; i++)
            {
                if (numero[i] > numeroMaior)
                {
                    numeroMaior = numero[i];
                    posicao = i;
                }
            }

            Console.WriteLine("O número maior digitado é: " + numeroMaior.ToString("F2"));
            Console.WriteLine($"A posição do número é: {posicao}");
        }
    }
}