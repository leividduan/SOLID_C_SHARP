using System;

namespace Heranca_Construtor
{
    public class Veiculo 
    {
        private string numeroChasis;

        public Veiculo(string _numeroChasis)
        {
            numeroChasis = _numeroChasis;
            Console.WriteLine($"Inicializando Veiculo:{_numeroChasis}");
        }
        public Veiculo()
        {
            Console.WriteLine("Inicializando Veiculo");
        }

        public virtual void Teste()
        {
            Console.WriteLine("Acessei TESTE");
        }
    }

    public class Carro : Veiculo
    {
        public Carro(string numeroChasis) : base(numeroChasis)
        {
            Console.WriteLine($"Inicializando Carro:{numeroChasis}");
        }
        public Carro()
        {
            Console.WriteLine("Inicializando Carro");
        }
        public override void Teste()
        {
            base.Teste();
            Console.WriteLine("sobrescrevi TESTE");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("123456");
            carro.Teste();
            Console.ReadLine();
        }
    }
}
