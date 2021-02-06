using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPratico2
{
    abstract class Animal
    {
        public string Tipo { get; set; }
        public Animal(string tipo)
        {
            Tipo = tipo;
        }

        public abstract void Mover();
    }
}
