using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Exercicios
{
    public interface IG1
    {
        void mymethod();
    }

    public interface IG2
    {
        void mymethod();
    }

    public class Geeks : IG1, IG2
    {
        //implementação independente da interface
        //implicita
        /*
        public void mymethod()
        {
            Console.WriteLine("Imprimir");
        }
        */

        //para cada interface uma implementação diferente
        // explicita
        void IG1.mymethod()
        {
            Console.WriteLine("Impressão G1");
        }

        void IG2.mymethod()
        {
            Console.WriteLine("Impressão G2");
        }
    }
}
