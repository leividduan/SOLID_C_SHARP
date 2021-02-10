using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    class CalcularImposto
    {
        public decimal Calcular(ICalcularImpostoPais iCalc)
        {
            return iCalc.CalcularValorImposto();
        }
    }
}
