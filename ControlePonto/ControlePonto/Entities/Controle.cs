using System;

namespace ControlePonto.Entities
{
    public class Controle
    {
        public DateTime DataHoraEntrada { get; set; }
        public DateTime DataHoraSaida { get; set; }

        public Controle(DateTime dataHoraEntrada, DateTime dataHoraSaida)
        {
            DataHoraEntrada = dataHoraEntrada;
            DataHoraSaida = dataHoraSaida;
        }

        public void Entrada(DateTime dataHoraEntrada)
        {
            DateTime agora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            if(dataHoraEntrada == null)
            {
                throw new DomainException("Data Invalida!");
            }
            else if (dataHoraEntrada < agora)
            {
                throw new DomainException("Digite uma data maior ");
            }
            DataHoraEntrada = dataHoraEntrada;
        }

        public void Saida(DateTime dataHoraSaida)
        {
            DataHoraEntrada = dataHoraSaida;
        }
    }
}