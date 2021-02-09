using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Violacao_Aderente
{
    class RecuperarSenha
    {
        private IDataBaseConnection conexaoBanco;

        public RecuperarSenha(IDataBaseConnection _conexao)
        {
            conexaoBanco = _conexao;
        }
    }
}
