using System;
using System.Collections.Generic;
using System.Text;

namespace Acoplamento_Composicao
{
    class Sardinha
    {
        Animal animal = new Animal();
        ComportamentoNadar nadar = new ComportamentoNadar();
    }
}
