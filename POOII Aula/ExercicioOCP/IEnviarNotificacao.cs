using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOCP
{
    public interface IEnviarNotificacao 
    {
        //public int Numero { get; set; }
        void EnviarMensagemCliente(EnviarNotificacao canal)
        {
            canal.EnviarMensagemClienteWhatsApp();
        }
        //void EnviarMensagemCliente(EnviarNotificacao canal)
        //{
        //    canal.EnviarMensagemClienteWhatsApp();
        //}
    }
}
