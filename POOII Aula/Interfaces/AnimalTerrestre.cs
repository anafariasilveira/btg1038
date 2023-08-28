using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class AnimalTerrestre : IReinoAnimale
    {
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Idade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
