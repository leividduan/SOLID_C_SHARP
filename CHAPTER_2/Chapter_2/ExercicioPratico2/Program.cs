using System;

namespace ExercicioPratico2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Ave("Pato");
            Animal animal2 = new Peixe("Salmão");

            animal1.Mover();
            Console.WriteLine(animal1.Tipo);

            animal2.Mover();
            Console.WriteLine(animal2.Tipo);

            Console.ReadLine();
        }
    }
}
