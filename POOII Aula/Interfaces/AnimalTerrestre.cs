using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class AnimalTerrestre : IReinoAnimale
    {
        public void Comer()
        {
            Console.WriteLine("Animal terrestre está comendo");
        }

        public void Movimentar()
        {
            Console.WriteLine("Animal terrestre está andando");
        }

        public void Reproduzir()
        {
            Console.WriteLine("Animal terrestre está gerando um filhote!");
        }

    }
}
