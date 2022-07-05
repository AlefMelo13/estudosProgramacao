using ProgramaPedidos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPedidos.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        //TOSTRING PARA EXIBIR OS DADOS DO MEU PEDIDO NO PROGRAMA PRINCIPAL
        public override string ToString()
        {
            return "Número Pedido: " + Id
                  +"\r\nData Pedido: " + Moment
                  +"\r\nStatus Pedido: " + Status;
        }
    }
}