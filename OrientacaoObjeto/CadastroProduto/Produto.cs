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
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //CONSTRUTOR - OBRIGA O OBJETO TER VALORES DE ENTRADA
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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

        public double GetPreco()
        {
            return Preco;
        }

        public void SetPreco(double preco)
        {
            Preco = preco;
        }

        public int GetQuantidade()
        {
            return Quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
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
            return _nome + ", R$" + Preco.ToString("F2") + ", " + Quantidade + " unidades.";
        }
    }
}
