using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    interface ICalcularImpostoPais
    {
        decimal TotalRenda { get; set; }
        decimal TotalDeducao { get; set; }
        decimal CalcularValorImposto();
    }
}
