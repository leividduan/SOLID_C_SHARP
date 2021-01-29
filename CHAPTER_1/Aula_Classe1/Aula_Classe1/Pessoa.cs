using System;
namespace Aula_Classe1
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public string genero;

        public Pessoa()
        {
        }
        public Pessoa(string nome, int idade, string genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }

        public void Identificar()
        {
            Console.WriteLine($"Olá, sou o {nome}, tenho {idade} anos, sou do sexo {genero}");
        }
    }
}
