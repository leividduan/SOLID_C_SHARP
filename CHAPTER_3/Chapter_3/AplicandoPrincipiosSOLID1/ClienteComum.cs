using System;
using System.Collections.Generic;
using System.Text;

namespace AplicandoPrincipiosSOLID1
{
    class ClienteComum : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco);
        }
    }
}
