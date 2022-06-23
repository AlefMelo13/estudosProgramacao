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

        //CONSTRUTORES DA CLASSE CONTA
        public Conta(string cliente, double numeroConta, double valorDeposito)
        {
            _cliente = cliente;
            NumeroConta = numeroConta;
            ValorDeposito = valorDeposito;
        }

        public Conta(string cliente, double numeroConta)
        {
            _cliente = cliente;
            NumeroConta = numeroConta;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + "; Titular: " + _cliente + "; Saldo: " + ValorDeposito;
        }

        public void SetDeposito(double deposito)
        {
            ValorDeposito += deposito;
        }
    }
}
