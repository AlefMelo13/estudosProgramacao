// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace duracaoJogo
{
    class DuracaoJogo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- MÚLTIPLOS DE DOIS ----------");

            double horaInicio, horaFim, duracaoJogo;

            Console.Write("Digite a hora do início do jogo: ");
            horaInicio = double.Parse(Console.ReadLine());

            Console.Write("Digite a hora do final do jogo: ");
            horaFim = double.Parse(Console.ReadLine());

            if (horaFim > horaInicio)
            {
                duracaoJogo = horaFim - horaInicio;
            }
            else
            {
                duracaoJogo = 24 - horaInicio + horaFim;
            }
            Console.WriteLine("O jogo durou " + duracaoJogo + " hora(s)");
        }
    }
}