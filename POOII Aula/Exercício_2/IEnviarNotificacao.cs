using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEmpresas
{
    internal interface IEnviarNotificacao
    {
        void EnviarMensagemWhatsApp();
        void EnviarMensagemTelegram();
    }
}
