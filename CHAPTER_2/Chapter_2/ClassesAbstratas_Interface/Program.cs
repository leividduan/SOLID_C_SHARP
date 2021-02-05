using System;

namespace ClassesAbstratas_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var quadrado = new Quadrado("Quadrado");
            quadrado.Desenhar();
            quadrado.Identificar();

            var triangulo = new Triangulo("Triangulo");
            triangulo.Desenhar();
            triangulo.Duplicar();
            triangulo.Identificar();

            Console.ReadLine();
        }
    }
}
