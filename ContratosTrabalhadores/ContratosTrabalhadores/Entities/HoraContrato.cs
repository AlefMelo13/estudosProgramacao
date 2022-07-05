namespace ContratosTrabalhadores.Entities
{
    public class HoraContrato
    {
        public DateTime Data { get; set; }
        public double ValorHora { get; set; }
        public int Horas { get; set; }

        //CONSTRUTORES
        public HoraContrato()
        {
        }

        public HoraContrato(DateTime data, double valorHora, int hora)
        {
            Data = data;
            ValorHora = valorHora;
            Horas = hora;
        }

        //MÉTODO QUE RETORNA O VALOR TOTAL DINHEIRO POR HORAS TRABALHADAS
        public double ValorTotalContrato()
        {
            return Horas * ValorHora;
        }
    }
}