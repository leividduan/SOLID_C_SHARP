using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizarria p1 = new Pizarria(new PizzaFactory());
            p1.CriarPizza("mussarela");
            p1.CriarPizza("calabresa");

            Console.ReadLine();
        }
    }
}
