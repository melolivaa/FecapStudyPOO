using System;
using System.Collections.Generic;
using System.Text;

namespace FecapStudyPOO
{
    internal interface INotificador
    {
        string ObterCanal();
        bool EnviarAlerta(string destinatario, string mensagem);
    }
}
