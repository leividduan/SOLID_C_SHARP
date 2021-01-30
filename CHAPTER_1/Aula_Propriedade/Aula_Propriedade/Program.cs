using System;

namespace Aula_Propriedade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Maria");
            p1.Genero = "Feminino";
            p1.Idade = 19;

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Idade);
        }
    }
}
