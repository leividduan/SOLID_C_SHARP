using System;
using System.Collections.Generic;
using System.Text;

namespace AplicandoPrincipiosSOLID1
{
    class GerenciadorDeDesconto
    {
        private readonly ICalculaDescontoFidelidade descontoFidelidade;
        private readonly ICalculaDescontoStatusContaFactory descontoStatusConta;

        public GerenciadorDeDesconto(ICalculaDescontoFidelidade _descontoFidelidade, ICalculaDescontoStatusContaFactory _descontoStatusConta)
        {
            descontoFidelidade = _descontoFidelidade;
            descontoStatusConta = _descontoStatusConta;
        }

        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            precoAposDesconto = descontoStatusConta.GetCalculoDescontoStatusConta(statusContaCliente).AplicarDescontoStatusConta(preco);
            precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);

            return precoAposDesconto;
        }
    }
}
