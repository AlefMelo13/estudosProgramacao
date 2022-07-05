using ProgramaPedidos.Entities;
using ProgramaPedidos.Entities.Enums;

namespace ProgramaPedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
        }
    }
}