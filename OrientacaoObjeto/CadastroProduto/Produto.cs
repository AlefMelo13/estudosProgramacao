﻿using System;
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

        public double ValorTotalEstoque()
        {
            return (Quantidade * Preco);
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2") + ", " + Quantidade + " unidades.";
        }
    }
}