using System;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado q = new Quadrado();

            Console.WriteLine(q.Descricao());

            Console.WriteLine("Informe a cor da figura");
            q.Cor = Console.ReadLine();

            Console.WriteLine("Informe a lado do quadrado");
            q.Lado = Convert.ToInt32(Console.ReadLine());

            q.CalcularArea();
            q.CalcularPerimetro();

            Console.WriteLine($"A área do quadrado é: {q.Area}m2");
            Console.WriteLine($"O perímetro do quadrado é: {q.Perimetro}m");
            Console.WriteLine($"O quadrado tem a cor: {q.Cor}");
        }
    }
}
