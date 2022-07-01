using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProdutoLista
{
    internal class Produto
    {
        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(int codigo, string nome, double preco, int quantidade)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //CONSTRUTORES PARA PRODUTO
        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        //CLASSE PARA ADICIONAR PRODUTO AO ESTOQUE
        public void AdicionaProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        //CLASSE PARA ALTERAR O PREÇO O PRODUTO
        public void AlteraPreco(double novoPreco)
        {
            Preco = novoPreco;
        }

        //TO STRING PARRA EXIBIR A LISTA DE PRODUTOS NO PROJETO PRINCIPAL
        public override string ToString()
        {
            return "Código: " + Codigo + "| Nome: " + Nome + "| Preço: R$" + Preco.ToString("F2") + "| Quantidade: " + Quantidade;
        }
    }
}
