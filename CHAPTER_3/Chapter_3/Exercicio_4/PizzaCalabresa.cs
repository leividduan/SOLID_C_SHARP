using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_4
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa(string nome) : base(nome)
        {

        }
        public override int AssarPizza()
        {
            var tempo = 25;
            Console.WriteLine($"Assando pizza de {Nome} por {tempo} minutos");
            return tempo;
        }
    }
}
