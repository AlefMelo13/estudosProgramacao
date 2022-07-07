using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioPedido.Entities.Enums;

namespace DesafioPedido.Entities
{
    class Pedido
    {
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Clinte { get; set; }
        public List<PedidoItem> ItemPedido { get; set; } = new List<PedidoItem>();

        //CONSTRUTORES
        public Pedido()
        {
        }

        public Pedido(DateTime momento, Cliente cliente, StatusPedido status)
        {
            Momento = momento;
            Status = status;
        }



        //MÉTODOS DA CLASSE
        public void AdicionaItem(PedidoItem itemPedido)
        {
            ItemPedido.Add(itemPedido);
        }

        public void RemoveItem(PedidoItem itemPedido)
        {
            ItemPedido.Remove(itemPedido);
        }

        public double TotalPedido()
        {
            double soma = 0.0;
            foreach (PedidoItem peditem in ItemPedido)
            {
                soma += peditem.SubTotal();
            }

            return soma;
        }

        public override string ToString()
        {
            StringBuilder pedido = new StringBuilder();
            pedido.AppendLine("Momento Pedido: " + DateTime.Now);
            pedido.AppendLine("Status Pedido: " + Status);
            pedido.AppendLine("Cliente: " + Clinte);
            pedido.AppendLine("Itens Pedido:");

            foreach(PedidoItem ped in ItemPedido)
            {
                pedido.AppendLine(ped.ToString());
            }
            pedido.AppendLine("PreçoTotal: " + TotalPedido().ToString("F2"));

            return pedido.ToString();
        }
    }
}