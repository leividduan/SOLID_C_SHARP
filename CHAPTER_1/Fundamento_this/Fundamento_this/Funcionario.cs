using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamento_this
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Funcionario(string Nome, string Email)
        {
            this.Nome = Nome;
            this.Email = Email;
        }
    }
}
