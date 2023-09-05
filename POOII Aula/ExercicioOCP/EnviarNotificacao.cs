using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOCP
{
    public class EnviarNotificacao : IEnviarNotificacao
    {
        //public void EnviarMensagemCliente(CanalMensagem canal)
        //{
        //    if (canal == CanalMensagem.WhatsApp)
        //    {
        //        Console.WriteLine("Estou enviando uma mensagem no WhatsApp do Cliente");
        //    }
        //    else if (canal == CanalMensagem.Telegram)
        //    {
        //        Console.WriteLine("Estou enviando uma mensagem no Telegram do Cliente");
        //    }
        //}
        public void EnviarMensagemClienteWhatsApp()
        {
            Console.WriteLine("Estou enviando uma mensagem no WhatsApp do Cliente");
        }
        public void EnviarMensagemClienteTelegram()
        {
            Console.WriteLine("Estou enviando uma mensagem no Telegram do Cliente");
        }
    }
}
