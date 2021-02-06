using System;

namespace LSP_Violacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LSP - Usando a classe base");
            var conta = new Conta();
            conta.Saldo = 100;
            conta.Saque(250);
            Console.WriteLine($"Saldo da Conta: {conta.Saldo}");

            Console.WriteLine("LSP - Usando a classe derivada");
            var conta2 = new Conta();
            conta2.Saldo = 100;
            conta2.Saque(250);
            Console.WriteLine($"Saldo da Conta: {conta2.Saldo}");

            Console.ReadLine();
        }
    }
}
