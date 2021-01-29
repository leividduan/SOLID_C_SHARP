using System;

namespace Aula_Classe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Deivid";
            pessoa1.idade = 20;
            pessoa1.genero = "Masculino";
            pessoa1.Identificar();

            Pessoa pessoa2 = new Pessoa("Aline", 20, "Feminino");
            pessoa2.Identificar();
        }
    }
}
