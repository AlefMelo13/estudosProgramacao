// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace PrimeiroProjeto {
    class DiaSemana {
        static void Main(string[] args) {

            Console.WriteLine("---------- DIA DA SEMANA ----------");

            int dia;
            string diaSemana;

            Console.Write("Digite um número para saber o dia da semana: ");
            dia = int.Parse(Console.ReadLine());

            switch (dia) {
                case 1:
                    diaSemana = "Domingo";
                    break;
                case 2:
                    diaSemana = "Segunda";
                    break;
                case 3:
                    diaSemana = "Terça";
                    break;
                case 4:
                    diaSemana = "Quarta";
                    break;
                case 5:
                    diaSemana = "Quinta";
                    break;
                case 6:
                    diaSemana = "Sexta";
                    break;
                case 7:
                    diaSemana = "Sábado";
                    break;
                default:
                    diaSemana = "VALOR INVÁLIDO!";
                    break;
            }

            Console.WriteLine("O dia da semana é " + diaSemana);
        }
    }
}