using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAbstratas_Interface
{
    interface IFigura
    {
        string Nome { get; set; }

        void Desenhar();
        void Identificar();
        void Duplicar();
    }
}
