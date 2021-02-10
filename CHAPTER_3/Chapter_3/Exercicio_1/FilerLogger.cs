using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercicio_1
{
    class FilerLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            File.WriteAllText($"{Directory.GetCurrentDirectory()}\\LOG_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}.txt", mensagem);
        }
    }
}
