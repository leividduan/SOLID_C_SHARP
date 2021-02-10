using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto celularSamsung = new Celular(new PromocaoDiaMaes());
            celularSamsung.Nome = "Celular Galaxy M10";
            celularSamsung.Preco = 1000;
            var precoCelular = celularSamsung.PrecoVenda();
            Console.WriteLine($"{celularSamsung.Nome} (20% OFF): {precoCelular}");

            Produto perfumeChanel = new Perfume(new PromocaoDiaNamorados());
            perfumeChanel.Nome = "Perfume Chanel Blue";
            perfumeChanel.Preco = 500;
            var precoChanel = perfumeChanel.PrecoVenda();
            Console.WriteLine($"{perfumeChanel.Nome} (10% OFF): {precoChanel}");

            Console.ReadLine();
        }
    }
}
