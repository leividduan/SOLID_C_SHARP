using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Violacao_Aderente
{
    class CadastrarProduto : IPersistencia
    {
        public void SalvarDataBase()
        {
            Console.WriteLine("Salva dados");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Valida dados");
        }
    }
}
