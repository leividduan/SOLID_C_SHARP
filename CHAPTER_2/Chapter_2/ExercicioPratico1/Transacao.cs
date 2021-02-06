using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPratico1
{
    class Transacao : ConectarBancoDados, ITransacao, IRelatorio
    {
        public void Executa()
        {
            Console.WriteLine("Processando Transação");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo");
        }
    }
}
