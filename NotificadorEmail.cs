using System;

namespace FecapStudyPOO
{
    public class NotificadorEmail : INotificador
    {
        public string ObterCanal()
        {
            return "E-mail";
        }

        public bool EnviarAlerta(string destinatario, string mensagem)
        {
            Console.WriteLine("Enviando e-mail para: " + destinatario);
            Console.WriteLine("Mensagem: " + mensagem);

            return true;
        }
    }
}