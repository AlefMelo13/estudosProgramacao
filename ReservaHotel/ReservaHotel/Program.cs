using System;
using ReservaHotel.Entities;
using ReservaHotel.Entities.Exceptions;

namespace ReservaHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- RESERVA QUARTO ----------");
            Console.WriteLine();

            try
            {
                Console.Write("Digite o número do quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                Console.Write("Digite a data de entrada: ");
                DateTime dataEntrada = DateTime.Parse(Console.ReadLine());

                Console.Write("Digite a data de saída: ");
                DateTime dataSaida = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(numeroQuarto, dataEntrada, dataSaida);
                Console.WriteLine(reserva.ToString());

                Console.WriteLine();
                Console.WriteLine("Atualizar datas de reserva:");
                Console.WriteLine();

                Console.Write("Digite a data de entrada: ");
                dataEntrada = DateTime.Parse(Console.ReadLine());

                Console.Write("Digite a data de saída: ");
                dataSaida = DateTime.Parse(Console.ReadLine());

                reserva.AtualizacaoDatas(dataEntrada, dataSaida);
                Console.WriteLine("Reserva Atualizada: " + reserva.ToString());
            }

            catch (DomainException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}