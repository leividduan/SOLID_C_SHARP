using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Violacao_Aderente
{
    class CadastrarCliente : IPersistencia, IMensagemEmail
    {
        public void EnviarEmail()
        {
            Console.WriteLine("Enviar email");
        }

        public void SalvarDataBase()
        {
            Console.WriteLine("Salvar Dados");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Valida dados");
        }
    }
}
