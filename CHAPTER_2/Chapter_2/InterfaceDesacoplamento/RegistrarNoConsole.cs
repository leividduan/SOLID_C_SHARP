using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDesacoplamento
{
    class RegistrarNoConsole : IRegistro
    {
        public void RegistraInfo(string mensage)
        {
            Console.WriteLine($"Info: {mensage}");
        }
    }
}
