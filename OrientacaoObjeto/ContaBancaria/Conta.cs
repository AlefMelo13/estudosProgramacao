using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Conta
    {
        public string Titular { get; set; }
        public double NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        //CONSTRUTORES DA CLASSE CONTA
        public Conta(string titular, double numeroConta)
        {
            Titular = titular;
            NumeroConta = numeroConta;
        }

        public Conta(string titular, double numeroConta, double valorDeposito) : this (titular, numeroConta)
        {
            Saldo = valorDeposito;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + "; Titular: " + Titular + "; Saldo: R$" + Saldo;
        }

        //ENCAPSULAMENTO DE ATRIBUTOS
        public void SetDeposito(double deposito)
        {
            Saldo += deposito;
        }

        public void SetSaque(double saque)
        {
            Saldo -= saque + 5;
        }
    }
}
