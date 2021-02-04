using System;
using System.Collections.Generic;
using System.Text;

namespace Acoplamento_Composicao
{
    class Gato
    {
        Animal gato = new Animal();
        ComportamentoAndar andar = new ComportamentoAndar();

        public void Miau()
        {
            Console.WriteLine("Miau!");
        }
    }
}
