using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_3
{
    class PromocaoDiaMaes : IPromocao
    {
        public decimal Desconto()
        {
            return 0.20M;
        }
    }
}
