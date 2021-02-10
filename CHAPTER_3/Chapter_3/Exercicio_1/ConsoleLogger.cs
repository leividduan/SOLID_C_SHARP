using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_1
{
    class ConsoleLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
