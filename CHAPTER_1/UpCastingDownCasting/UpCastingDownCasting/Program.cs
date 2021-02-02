using System;

namespace UpCastingDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        private static void UpCasting()
        {
            Circulo circulo = new Circulo();
            Forma f = circulo; //UPCASTING

            Console.WriteLine(f == circulo);

            f.Desenhar();
        }
        private static void DownCasting()
        {
            Circulo circulo = new Circulo();
            Forma f = circulo;

            Circulo c = (Circulo)f; //DOWNCASTING

            Console.WriteLine(c == f);
            Console.WriteLine(c == circulo);

            c.Desenhar();
            c.PintarCirculo();
        }
        private static void DownCasting_As()
        {
            Forma f = new Forma();
            Circulo c = f as Circulo; //Com o operador as, senão for possível o DOWNCASTING ele retorna NULL

            if (c != null)
                c.PintarCirculo();
            else
                Console.WriteLine("Operação inválida");
        }
        private static void DownCasting_Is()
        {
            Circulo circulo = new Circulo();
            Forma f = circulo;

            if (f is Circulo) //Verifica se a conversão é possível
                ((Circulo)f).PintarCirculo();
            else
                Console.WriteLine("A conversão não é possível");
        }
    }
}
