using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico
{
    public class ImprimeDados2
    {
        public T ImprimirDadosGenericos<T>(T objeto)
        {
            Console.WriteLine(objeto.GetType());
            Console.WriteLine(objeto);
            return objeto;
        }
    }
}
