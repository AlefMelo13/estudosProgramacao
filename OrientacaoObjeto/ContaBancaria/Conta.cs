using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Conta
    {
        private string _cliente;
        public double NumeroConta { get; private set; }
        public double ValorDeposito { get; private set; }

        //CONSTRUTOR DA CLASSE CONTA
        public Conta()
        {
        }

        public Conta(string cliente, double numeroConta, double valorDeposito)
        {
            _cliente = cliente;
            NumeroConta = numeroConta;
            ValorDeposito = valorDeposito;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + "; Titular: " + _cliente + "; Saldo: " + ValorDeposito;
        }
    }
}
