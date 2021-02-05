using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class GravarJSON : ArquivoBase, IGravar
    {
        public void GravarArquivo()
        {
            throw new NotImplementedException();
        }

        public override void Nome()
        {
            Console.WriteLine("Definir nome em GravarJSON");
        }
    }
}
