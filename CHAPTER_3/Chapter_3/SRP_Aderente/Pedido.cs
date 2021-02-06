using System;
using System.Collections.Generic;
using System.Text;

namespace SRP_Aderente
{
    class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        private ILogger infoLogger;
        private EnviarEmail enviarEmail;

        public Pedido()
        {
            enviarEmail = new EnviarEmail();
            infoLogger = new RegistraLog();
        }
        public void IncluirPedido()
        {
            try
            {
                infoLogger.Info("Incluindo pedido");
                enviarEmail.EMailFrom = "teste@gmail.com";
                enviarEmail.EMailTo = "teste@gmail.com";
                enviarEmail.EMailSubject = "SRP";
                enviarEmail.EMailBody = "TESTE";
                enviarEmail.Enviar();
            }
            catch (Exception ex)
            {
                infoLogger.Info($"Erro ao enviar email: {ex.Message}");
            }
        }
        public void DeletaPedido()
        {
            try
            {
                infoLogger.Info($"Pedido deletado em: {DateTime.Now}");
            }
            catch (Exception ex)
            {
                infoLogger.Info($"Erro ao deletar email: {ex.Message}");
            }
        }
    }
}
