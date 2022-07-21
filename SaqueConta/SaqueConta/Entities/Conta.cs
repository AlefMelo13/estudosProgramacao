using SaqueConta.Entities.Exceptions;

namespace SaqueConta.Entities
{
    class Conta : ApplicationException
    {
        public int NumeroConta { get; set; }
        public string TitularConta { get; set; }
        public double SaldoConta { get; set; }
        public double LimiteSaque { get; set; }

        public Conta(int numeroConta, string titularConta, double saldoConta, double limiteSaque)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            SaldoConta = saldoConta;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valorDeposito)
        {
            SaldoConta = valorDeposito;
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

            SaldoConta -= valorSaque;
        }
    }
}