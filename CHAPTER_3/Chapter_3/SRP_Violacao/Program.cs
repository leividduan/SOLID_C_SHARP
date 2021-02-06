using System;

namespace SRP_Violacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            pedido.IncluirPedido();

            Console.ReadLine();
        }
    }
}
