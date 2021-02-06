using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultMemberInterface
{
    class FileLogger : ILogger
    {
        public void Info(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
