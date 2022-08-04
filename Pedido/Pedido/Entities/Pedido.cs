using System;
using System.Collections.Generic;


namespace Pedido.Entities
{
    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public Cliente Cliente { get; set; }
        public static List<Produto> Produto { get; set; }

        public Pedido(int numeroPedido, DateTime dataPedido, Cliente cliente)
        {
            NumeroPedido = numeroPedido;
            DataPedido = dataPedido;
            Cliente = cliente;
        }



        public override string ToString()
        {
            return "Cliente: " + Cliente.ToString()
                 + "Número Pedido: 1"
                 + "\nData Pedido: " + DateTime.Now
                 + "\nQuantidade Produtos: "
                 + "Total do Pedido: ";
        }
    }
}