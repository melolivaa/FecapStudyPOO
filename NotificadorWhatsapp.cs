using System;

namespace FecapStudyPOO
{
    public class NotificadorWhatsApp : INotificador
    {
        public string ObterCanal()
        {
            return "WhatsApp";
        }

        public bool EnviarAlerta(string destinatario, string mensagem)
        {
            Console.WriteLine("Enviando WhatsApp para: " + destinatario);
            Console.WriteLine("Mensagem: " + mensagem);

            return true;
        }
    }
}