using System;
using ContratoCompra.Entities;

namespace ContratoCompra.Services
{
    public class ServicoContrato
    {
        private IServicoPagamento _servicoPagamento;

        public ServicoContrato(IServicoPagamento servicoPagamento)
        {
            _servicoPagamento = servicoPagamento;
        }

        public void ProcessaContrato(Contrato contrato, int quantidadeParcelas)
        {
            double parcelaBasica = contrato.ValorTotalContrato / quantidadeParcelas;

            for (int i = 1; i <= quantidadeParcelas; i++)
            {
                DateTime dataParcela = contrato.DataContrato.AddMonths(i);
                double atualizaParcela = parcelaBasica + _servicoPagamento.TaxaSimples(parcelaBasica, i);
                double valorParcela = atualizaParcela + _servicoPagamento.TaxaPagamento(atualizaParcela);
                contrato.AddParcela(new Parcela(dataParcela, valorParcela));
            }
        }
    }
}