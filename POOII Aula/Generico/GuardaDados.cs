using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico
{
    //propriedades genéricas
    public class GuardaDados<T>
    {
        public T Dados { get; set; }
        public void ImprimeDados()
        {
            Console.WriteLine(Dados.GetType());
            Console.WriteLine(Dados.ToString());
        }

    }
}
