using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usando Classe
            GravarXML gravar = new GravarXML();
            gravar.Nome();
            gravar.GravarArquivo();

            //Usando Interface
            IGravar igravar = new GravarXML();
            igravar.GravarArquivo();
            //igravar.Nome();

            Console.ReadLine();
        }
    }
}
