using System;
using ReservaHotel.Entities.Exceptions;

namespace ReservaHotel.Entities
{
    class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        public Reserva(int numeroQuarto, DateTime dataEntrada, DateTime dataSaida)
        {
            if (dataEntrada >= dataSaida)
            {
                throw new DomainException("Digite uma data de entrada menor que data de saída!");
            }

            NumeroQuarto = numeroQuarto;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public int DuracaoReserva()
        {
            TimeSpan duracao = DataSaida.Subtract(DataEntrada);
            return (int)duracao.TotalDays;
        }

        public void AtualizacaoDatas(DateTime dataEntrada, DateTime dataSaida)
        {
            DateTime agora = DateTime.Now;
            if (dataEntrada < agora || dataSaida < agora)
            {
                throw new DomainException("Datas da reserva devem ser datas futuras!");
            }
            if (dataEntrada >= dataSaida)
            {
                throw new DomainException("Digite uma data de entrada menor que data de saída!");
            }

            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public override string ToString()
        {
            return "Quarto: " + NumeroQuarto
                 + ", Data Entrada: " + DataEntrada.ToString("dd/MM/yyyy")
                 + ", Data Saida: " + DataSaida.ToString("dd/MM/yyyy")
                 + ", Duração Reserva: " + DuracaoReserva();
        }
    }
}