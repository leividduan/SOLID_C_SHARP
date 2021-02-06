using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Figura
    {
        public int Lado { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Executando desenhar na classe base");
        }
    }
}
