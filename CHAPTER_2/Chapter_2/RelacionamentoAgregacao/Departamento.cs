using System;
using System.Collections.Generic;
using System.Text;

namespace RelacionamentoAgregacao
{
    class Departamento : IDisposable
    {
        public string Nome { get; set; }
        public List<Professor> Professores { get; set; }

        public void Dispose()
        {
        }
    }
}
