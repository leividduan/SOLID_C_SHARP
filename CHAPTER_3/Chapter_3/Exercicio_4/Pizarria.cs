using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_4
{
    class Pizarria
    {
        private Pizza pizza;
        PizzaFactory factory;

        public Pizarria(PizzaFactory factory)
        {
            this.factory = factory;
        }
        public void CriarPizza(string tipo)
        {
            pizza = factory.CriarPizza(tipo);

            pizza.AssarPizza();
            pizza.DeliveryPizza();
        }
    }
}
