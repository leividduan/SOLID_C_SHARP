﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    class CalculaImpostoBrazil : ICalcularImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 20 / 100;
        }
    }
}
