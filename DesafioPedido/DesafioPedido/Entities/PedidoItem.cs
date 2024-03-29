﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioPedido.Entities.Enums;

namespace DesafioPedido.Entities
{
    class PedidoItem
    {
        public Produto NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        //CONSTRUTORES
        public PedidoItem()
        {
        }

        public PedidoItem(Produto nome, int quantidade, double preco)
        {
            NomeProduto = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        //MÉTODOS DA CLASSE
        public double SubTotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            StringBuilder itemPedido = new StringBuilder();
            itemPedido.Append("Nome: " + NomeProduto);
            itemPedido.Append(", Preço: R$" + Preco);
            itemPedido.Append(", Quantidade: " + Quantidade);
            itemPedido.Append(", SubTotal: " + SubTotal());

            return itemPedido.ToString();
        }
    }
}