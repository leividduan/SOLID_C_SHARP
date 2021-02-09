using System;
using System.Collections.Generic;
using System.Text;

namespace AplicandoPrincipiosSOLID1
{
    public interface ICalculaDescontoFidelidade
    {
        decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos);
    }
}
