using System;
using Metodos.Utils;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto1 = "curso";
            var texto2 = "teste";

            Console.WriteLine(texto1.CaixaAltaPrimeiraLetra());
            Console.WriteLine(texto2.CaixaAltaPrimeiraLetra());
        }
    }
}
