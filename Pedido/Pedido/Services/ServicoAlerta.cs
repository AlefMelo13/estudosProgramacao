using System;

namespace PedidoVenda.Services
{
    public class ServicoAlerta : Exception
    {
        public ServicoAlerta(string message) : base(message)
        {
        }
    }
}