// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace ListaNumerosFor
{
    class ListaNumerosFor
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- LISTA DE NÚMEROS ----------");

            int i;

            //PARA i = 1, DE 1 ATÉ 5 FAÇA (i++ ACRESCENTA 1 EM i)
            for (i = 0; i <= 5; i++)
            {
                Console.WriteLine("O valor de i é: " + i);
            }
        }
    }
}