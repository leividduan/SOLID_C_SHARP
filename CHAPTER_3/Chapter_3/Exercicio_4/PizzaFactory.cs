using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_4
{
    public class PizzaFactory
    {
        public Pizza CriarPizza(string tipo)
        {
            Pizza pizza = null;
            if (tipo.Equals("mussarela"))
            {
                pizza = new PizzaMussarela("Mussarela");
            }
            else if (tipo.Equals("calabresa"))
            {
                pizza = new PizzaCalabresa("Calabresa");
            }
            return pizza;
        }
    }
}
