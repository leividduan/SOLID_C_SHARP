using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalcularImpostoPais calc = new CalculaImpostoBrazil();
            calc.TotalRenda = 1000;
            calc.TotalDeducao = 100;

            CalcularImposto calcImp = new CalcularImposto();
            var valorTotalImposto = calcImp.Calcular(calc);
            Console.WriteLine($"Brasil {valorTotalImposto}");

            Console.ReadLine();
        }
    }
}
