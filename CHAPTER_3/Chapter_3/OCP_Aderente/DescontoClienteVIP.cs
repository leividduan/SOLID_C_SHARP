using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Aderente
{
    class DescontoClienteVIP : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal - 100;
        }
    }
}
