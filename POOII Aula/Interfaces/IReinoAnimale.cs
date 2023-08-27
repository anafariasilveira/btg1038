using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IReinoAnimale
    {
        void Comer();
        void Movimentar();
        void Reproduzir();
        virtual void Respirar()
        {
            Console.WriteLine("Estou respirando");
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
