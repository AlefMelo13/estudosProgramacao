using System;
using System.Collections.Generic;

namespace ContratoCompra.Entities
{
    public class Contrato
    {
        public int NumeroContrato { get; set; }
        public DateTime DataContrato { get; set; }
        public double ValorTotalContrato { get; set; }
        public List<Parcela> Parcela { get; set; }

        public Contrato(int numeroContrato, DateTime dataContrato, double valorTotalContrato)
        {
            NumeroContrato = numeroContrato;
            DataContrato = dataContrato;
            ValorTotalContrato = valorTotalContrato;
            Parcela = new List<Parcela>();
        }

        public void AddParcela(Parcela parcela)
        {
            Parcela.Add(parcela);
        }
    }
}