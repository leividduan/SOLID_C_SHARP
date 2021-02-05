using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAbstratas_Interface
{
    class Triangulo : IFigura
    {
        public Triangulo(string nome)
        {
            Nome = nome;
        }
        public string Nome { get ; set; }

        public void Desenhar()
        {
            Console.WriteLine($"Desenhando {Nome}");
        }

        public void Duplicar()
        {
            Console.WriteLine($"Duplicando {Nome}");
        }

        public void Identificar()
        {
            Console.WriteLine($"Sou o: {Nome}");
        }
    }
}
