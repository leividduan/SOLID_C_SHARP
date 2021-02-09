using System;

namespace DIP_Violacao_Aderente
{
    internal class MySqlConnection : IDataBaseConnection
    {
        public void Conectar()
        {
            Console.WriteLine("Conexão com o MySQL");
        }
    }
}