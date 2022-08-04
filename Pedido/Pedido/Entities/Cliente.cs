using PedidoVenda.Services;

namespace PedidoVenda.Entities
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string CpfCnpjCliente { get; set; }
        public decimal LimiteCreditoCliente { get; set; }

        public Cliente()
        {
        }
        public Cliente(string nomeCliente, string cpfCnpjCliente, decimal limiteCreditoCliente)
        {
            NomeCliente = nomeCliente;
            CpfCnpjCliente = cpfCnpjCliente;
            LimiteCreditoCliente = limiteCreditoCliente;
        }

        public void SetCliente(string nomeCliente)
        {
            if(nomeCliente == null)
            {
                throw new ServicoAlerta("Nome inválido!");
            }
            else if(nomeCliente.Length < 5)
            {
                throw new ServicoAlerta("Quantidade mínima de caracteres 5");
            }
        }

        public override string ToString()
        {
            return "Nome: " + NomeCliente
                 + "\nCPF/CNPJ: " + CpfCnpjCliente
                 + "\nLimite Crédito: " + LimiteCreditoCliente;
        }
    }
}