using System;

namespace ReservaHotel.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string mensagem) : base(mensagem)
        {

        }
    }
}