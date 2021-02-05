using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAbstratas
{
    abstract class Forma
    {
        public string Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

        public string Descricao()
        {
            return "Sou a clase abstrata";
        }
    }
}
