using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        //CONSTRUTOR - OBRIGA O OBJETO TER VALORES DE ENTRADA
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //EMCAPSULAMENTO DE CLASSE
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        //MÉTODOS DE CÁLCULO DA CLASSE
        public double ValorTotalEstoque()
        {
            return (_quantidade * _preco);
        }

        public void AdicionarProduto(int adicionaQuantidade)
        {
            _quantidade += adicionaQuantidade;
        }

        public void RemoverProduto(int removeQuantidade)
        {
            _quantidade -= removeQuantidade;
        }

        //IMPRIME OS DADOS NA TELA SEM PRECISAR CONTATENAR NO CÓDIGO PRINCIPAL
        public override string ToString()
        {
            return _nome + ", R$" + _preco.ToString("F2") + ", " + _quantidade + " unidades.";
        }
    }
}
