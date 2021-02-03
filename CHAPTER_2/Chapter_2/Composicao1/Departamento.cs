using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao1
{
    class Departamento : IDisposable
    {
        private Escola escola;
        private string nome;

        internal Departamento(Escola escola, string nome)
        {
            this.escola = escola;
            this.nome = nome;
        }

        public void Dispose() 
        {
        
        }
    }
}
