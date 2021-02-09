using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Violacao_Aderente
{
    interface IPersistencia
    {
        void ValidarDados();
        void SalvarDataBase();
    }
}
