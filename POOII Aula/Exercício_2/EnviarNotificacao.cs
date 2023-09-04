using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEmpresas
{
    internal class EnviarNotificacao : IEnviarNotificacao
    {
        public void EnviarMensagemWhatsApp()
        {
            Console.WriteLine("Estou enviando uma mensagem no WhatsApp do Cliente");
        }

        public void EnviarMensagemTelegram()
        {
            Console.WriteLine("Estou enviando uma mensagem no Telegram do Cliente");
        }
    }
}
