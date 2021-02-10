using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_4
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela(string nome) : base(nome)
        {

        }
        public override int AssarPizza()
        {
            var tempo = 20;
            Console.WriteLine($"Assando pizza de {Nome} por {tempo} minutos");
            return tempo;
        }
    }
}
