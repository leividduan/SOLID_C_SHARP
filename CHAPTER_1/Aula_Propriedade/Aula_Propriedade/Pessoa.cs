using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_Propriedade
{
    class Pessoa
    {
        private string nome;
        private string genero;
        private int idade;

        public string Nome { get; }
        public string Genero 
        {
            set
            {
                genero = value;
                Console.WriteLine(genero);
            }
        }

        public int Idade 
        {
            get { return idade; }
            set 
            {
                if (value < 18)
                    Console.WriteLine("Idade deve ser maior que 18");
                else
                    this.idade = value;
            } 
        }
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }
    }
}
