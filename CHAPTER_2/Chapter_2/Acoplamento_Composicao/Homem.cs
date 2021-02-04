using System;
using System.Collections.Generic;
using System.Text;

namespace Acoplamento_Composicao
{
    class Homem
    {
        Animal homem = new Animal();
        ComportamentoAndar andar = new ComportamentoAndar();

        public void Ola()
        {
            Console.WriteLine("Olá!");
        }
    }
}
