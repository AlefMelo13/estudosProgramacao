using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioPedido.Entities.Enums;

namespace DesafioPedido.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        //CONSTRUTORES
        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            StringBuilder produto = new StringBuilder();
            produto.AppendLine("Nome: " + Nome);
            produto.AppendLine("Preço: " + Preco);

            return produto.ToString();
        }
    }
}