using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Demo : ITeste, IControle
    {
        public void Desenhar()
        {
            throw new NotImplementedException();
        }

        public void Pintar()
        {
            throw new NotImplementedException();
        }
    }
}
