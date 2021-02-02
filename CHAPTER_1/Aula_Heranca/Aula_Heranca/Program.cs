using System;

namespace Aula_Heranca
{
    class Program
    {
        class Conta
        {
            public int Numero { get; set; }
            public double Saldo { get; set; }

            protected void GetSaldo()
            {
                Console.WriteLine("Saldo: 99,99");
            }
            public Conta()
            {
                Console.WriteLine("Construtor da classe conta");
            }
        }

        class ContaPoupanca : Conta
        {
            public int JurosMensais { get; set; }
            protected new void GetSaldo()
            {
                Console.WriteLine("Saldo: 88,88");
            }
            static void Main(string[] args)
            {
                ContaPoupanca cp = new ContaPoupanca();
                cp.GetSaldo();
            }
        }
    }
}
