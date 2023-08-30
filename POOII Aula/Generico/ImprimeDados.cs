using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico
{
    //métodos com parametro genéricos!
    //public class ImprimeDados<T> where T : class
    //public class ImprimeDados<T> where T : struct
    //public class ImprimeDados<T> where T : IHumano
    //public class ImprimeDados<T> where T : new()
    //public class ImprimeDados<T> where T : IHumano, IHumano2
    public class ImprimeDados<T>
    {
        public void ImprimeDadosGenericos(T objeto)
        {
            Console.WriteLine(objeto.GetType());
            Console.WriteLine(objeto);
        }
    }
}
