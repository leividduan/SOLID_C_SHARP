using System;

namespace AplicandoPrincipiosSOLID1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metodo Incorreto
            GerDescIncorreto gerDesc = new GerDescIncorreto();
            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%)\n");

            var resultado = gerDesc.Calcular(1000, 2, 10);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {resultado}");

            var resultado1 = gerDesc.Calcular(1000, 3, 10);
            Console.WriteLine($"Cliente tipo 3 o valor do desconto é de : {resultado1}");

            var resultado2 = gerDesc.Calcular(1000, 4, 10);
            Console.WriteLine($"Cliente tipo 4 o valor do desconto é de : {resultado2}\n");

            Console.WriteLine("Valor da compra 1000 e fidelidade 4 anos (4%)\n");
            var resultado3 = gerDesc.Calcular(1000, 2, 4);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {resultado3}");

            var resultado4 = gerDesc.Calcular(1000, 3, 4);
            Console.WriteLine($"Para Cliente tipo 3 o valor do desconto é de : {resultado4}");

            var resultado5 = gerDesc.Calcular(1000, 4, 4);
            Console.WriteLine($"Para Cliente tipo 4 o valor do desconto é de : {resultado5}");

            // Metodo Ajustado

            ICalculaDescontoFidelidade descFide = new CalculaDescontoFidelidade();
            ICalculaDescontoStatusContaFactory descConta = new CalculaDescontoStatusFactory();

            GerenciadorDeDesconto gerDesc2 = new GerenciadorDeDesconto(descFide, descConta);

            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%)\n");

            var resultado6 = gerDesc2.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 10);
            Console.WriteLine($"Cliente tipo {StatusContaCliente.ClienteComum}, 10 anos fidelidade,  = {resultado6}");

            var resultado7 = gerDesc2.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 10);
            Console.WriteLine($"Cliente tipo {StatusContaCliente.ClienteEspecial} o valor do desconto é de : {resultado7}");

            var resultado8 = gerDesc2.AplicarDesconto(1000, StatusContaCliente.ClienteVIP, 10);
            Console.WriteLine($"Cliente tipo {StatusContaCliente.ClienteVIP} o valor do desconto é de : {resultado8}\n");

            Console.WriteLine("Valor da compra 1000 e fidelidade 4 anos (4%)\n");
            var resultado9 = gerDesc2.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 4);
            Console.WriteLine($"Cliente tipo {StatusContaCliente.ClienteComum}, 10 anos fidelidade,  = {resultado9}");

            var resultado10 = gerDesc2.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 4);
            Console.WriteLine($"Para Cliente tipo {StatusContaCliente.ClienteEspecial} o valor do desconto é de : {resultado10}");

            var resultado11 = gerDesc2.AplicarDesconto(1000, StatusContaCliente.ClienteVIP, 4);
            Console.WriteLine($"Para Cliente tipo {StatusContaCliente.ClienteVIP} o valor do desconto é de : {resultado11}");

            Console.ReadLine();
        }
    }
}
