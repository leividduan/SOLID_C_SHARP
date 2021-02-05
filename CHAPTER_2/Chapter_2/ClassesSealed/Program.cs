using System;

namespace ClassesSealed
{
    sealed class CalcularSoma
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            CalcularSoma soma = new CalcularSoma();

            var resultado = soma.Somar(10, 20);
            
            Console.WriteLine("Hello World!");
        }
    }
}
