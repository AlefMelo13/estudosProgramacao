// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace formulaBhaskara
{
    class FormulaBhaskara
    {
        static void Main(string[] args)
        {
            // muitos programadores de java fazem isso, colocam um espaço em branco após o {, o que não faz sentido, já que a barra lá em cima é para reduzir uma linha de código
            Console.WriteLine("---------- FÓRMULA BHASKARA ----------");

            double a, b, c, delta, raiz1, raiz2;

            Console.Write("Digite o valor de A, B e C: ");
            string[] vet = Console.ReadLine().Split(',');

            a = double.Parse(vet[0]);

            b = double.Parse(vet[1]);

            c = double.Parse(vet[2]);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a ==0 || delta < 0.0)
            {
                Console.WriteLine("Impossível Calcular!");
            }
            else
            {
                raiz1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                raiz2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("Raiz 1 = " + raiz1);
                Console.WriteLine("Raiz 2 = " + raiz2);
            }
        }
    }
}