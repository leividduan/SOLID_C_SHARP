using System;
using System.Collections.Generic;
using System.Text;

namespace AplicandoPrincipiosSOLID1
{
    class ClienteVIP : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco - (Constantes.DESCONTO_CLIENTE_VIP * preco);
        }
    }
}
