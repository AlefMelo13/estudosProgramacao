using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //CONSTRUTOR - OBRIGA O OBJETO TER VALORES DE ENTRADA
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //MÉTODOS DE CÁLCULO DA CLASSE
        public double ValorTotalEstoque()
        {
            return (Quantidade * Preco);
        }

        public void AdicionarProduto(int adicionaQuantidade)
        {
            Quantidade += adicionaQuantidade;
        }

        public void RemoverProduto(int removeQuantidade)
        {
            Quantidade -= removeQuantidade;
        }

        //IMPRIME OS DADOS NA TELA SEM PRECISAR CONTATENAR NO CÓDIGO PRINCIPAL
        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2") + ", " + Quantidade + " unidades.";
        }
    }
}
