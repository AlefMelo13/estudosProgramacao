using SaqueConta.Entities.Exceptions;

namespace SaqueConta.Entities
{
    class Conta : ApplicationException
    {
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double SaldoConta { get; set; }
        public double LimiteSaque { get; set; }

        public Conta()
        {
        }

        public Conta(int numeroConta, string titularConta, double saldoConta, double limiteSaque)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            SaldoConta = saldoConta;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valorDeposito)
        {
            if(valorDeposito == 0)
            {
                throw new DomainException("Valor de depósito inválido!");
            }

            SaldoConta += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            if (valorSaque > SaldoConta)
            {
                throw new DomainException("Saldo insuficiente!");
            }
            else if (valorSaque > LimiteSaque)
            {
                throw new DomainException("Valor excede limite de saque!");
            }
            else if(valorSaque <= 0)
            {
                throw new DomainException("Digite um valor maior que zero!");
            }

            SaldoConta -= valorSaque;
        }

        public void NumConta(int numeroConta)
        {
            if (numeroConta <= 0 || numeroConta == null)
            {
                Console.Clear();
                throw new DomainException("Digite um número de conta válido!");
                Thread.Sleep(2000);
            }

            NumeroConta = numeroConta;
        }
        public override string ToString()
        {
            return "=================================================================="
                 + "\r\n Conta: " + NumeroConta
                 + ", Titular: " + TitularConta
                 + ", Saldo: R$" + SaldoConta.ToString("F2")
                 + ", Limite Saque: R$"+ LimiteSaque.ToString("F2")
                 + "\r\n==================================================================";
        }
    }
}