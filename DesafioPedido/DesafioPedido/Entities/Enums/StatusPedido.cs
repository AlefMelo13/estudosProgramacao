using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesafioPedido.Entities.Enums
{
    enum StatusPedido : int
    {
        PendentePagamento = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}