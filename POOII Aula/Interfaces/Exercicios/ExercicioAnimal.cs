using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Exercicios
{
    /*
     * Considerando a classe abstrata AnimalBase e a classe Cachorro,
     * realize a conversão da classe abstrata para uma interface chamada IAnimal.
     * Essa nova interface deverá ser implementada pela classe Cachorro.
     */
    public interface IAnimal
    {
        void comer(string comida);
        void dormir();
        string emitirSom();
    }

    public class Cachorro : IAnimal
    {
        public string nome { get; set; }
        public string raca { get; set; }

        public void comer(string comida)
        {
            Console.WriteLine("Cachorro está comendo");
        }
        public void dormir()
        {
            Console.WriteLine("Cachorro está dormindo");
        }
        public string emitirSom()
        {
            return "AuAu";
        }
    }
}
