using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Humano : IReinoAnimale, IExercitar, IHumano//, IHumano com metodo pensar
    {
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Idade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Comer()
        {
            Console.WriteLine("Humano está comendo");
        }

        void IReinoAnimale.Movimentar()
        {
            Console.WriteLine("Estou caminhando");
        }

        void IExercitar.Movimentar()
        {
            Console.WriteLine("Estou correndo");
        }

        public void Reproduzir()
        {
            Console.WriteLine("Estou gerando um filho!!");
            Pensar();
        }

        public void Pensar()
        {
            Console.WriteLine("Estou pensando!");
        }

        public void Casar()
        {
            Console.WriteLine("Casei!! uhuu");
        }


    }
}
