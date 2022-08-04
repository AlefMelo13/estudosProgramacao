namespace Pedido.Entities
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string CpfCnpjCliente { get; set; }
        public decimal LimiteCreditoCliente { get; set; }

        public Cliente(string nomeCliente, string cpfCnpjCliente, decimal limiteCreditoCliente)
        {
            NomeCliente = nomeCliente;
            CpfCnpjCliente = cpfCnpjCliente;
            LimiteCreditoCliente = limiteCreditoCliente;
        }

        public override string ToString()
        {
            return "Nome: " + NomeCliente
                 + "\nCPF/CNPJ: " + CpfCnpjCliente
                 + "\nLimite Crédito: " + LimiteCreditoCliente;
        }
    }
}