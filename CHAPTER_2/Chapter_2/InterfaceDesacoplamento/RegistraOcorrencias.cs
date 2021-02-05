using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterfaceDesacoplamento
{
    class RegistraOcorrencias
    {
        private readonly IRegistro _registro;

        //CODIGO FORTEMENTE ACOPLADO
        //public void RegistrarNoConsole(string mensagem)
        //{
        //    Console.WriteLine($"{mensagem} : {DateTime.Now}");
        //}

        //public void RegistraNoArquivo(string arquivo, string mensagem)
        //{
        //    using(var streamWriter = new StreamWriter(arquivo, true))
        //    {
        //        streamWriter.WriteLine($"{mensagem} : {DateTime.Now}");
        //    }
        //}

        //public void RegistrarJSON(string arquivo, string mensagem)
        //{
        //    //CODIGO
        //}

        public RegistraOcorrencias(IRegistro registro)
        {
            _registro = registro;
        }

        public void Registrar(string mensagem)
        {
            _registro.RegistraInfo($"{mensagem} : {DateTime.Now}");
        }
    }
}
