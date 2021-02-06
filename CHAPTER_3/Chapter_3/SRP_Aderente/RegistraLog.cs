using System;
using System.Collections.Generic;
using System.Text;

namespace SRP_Aderente
{
    class RegistraLog : ILogger
    {
        public void Info(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

    }
}
