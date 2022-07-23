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
            DateTime agora = DateTime.UtcNow;
            if(dataHoraEntrada.Date == null || dataHoraEntrada.Hour == null)
            {
                throw new DomainException("Data ou Hora Invalidas!");
            }
            else if (dataHoraEntrada.Hour < agora.Hour)
            {
                throw new DomainException("Digite uma data maior ");
            }
            DataHoraEntrada = dataHoraEntrada;
        }

        public void Saida(DateTime dataHoraSaida)
        {
            if(dataHoraSaida.Date == null || dataHoraSaida.Hour == null)
            {
                throw new DomainException("Data ou Hora Inválidas!");
            }
            else if(dataHoraSaida.Date <= DataHoraEntrada.Date || dataHoraSaida.Hour <= DataHoraEntrada.Hour)
            {
                throw new DomainException("Digite uma data e hora maior que a Entrada!");
            }
            DataHoraEntrada = dataHoraSaida;
        }
    }
}