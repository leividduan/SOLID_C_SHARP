using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultMemberInterface
{
    interface ILogger
    {
        void Info(string mensagem);
        void Erro(string mensagem)
        {
            System.Console.WriteLine(mensagem);
        }
    }
}
