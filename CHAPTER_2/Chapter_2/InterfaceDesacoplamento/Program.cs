using System;

namespace InterfaceDesacoplamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var registrarOcorrenciasConsole = new RegistraOcorrencias(new RegistrarNoConsole());
            registrarOcorrenciasConsole.Registrar("Registro no console");

            var registrarOcorrenciasArquivo = new RegistraOcorrencias(new RegistrarNoArquivo(@"C:\teste.txt"));
            registrarOcorrenciasArquivo.Registrar("Registro arquivo");

            Console.ReadLine();
        }
    }
}
