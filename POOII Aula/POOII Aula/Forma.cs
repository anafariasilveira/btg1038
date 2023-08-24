using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Aula
{
    public abstract class Forma
    {
        protected decimal minhaArea;

        public abstract decimal Area { get; set; }

        public abstract decimal CalcularArea();

        public virtual void ImprimirArea()
        {
            Console.WriteLine($"A area da forma é {minhaArea}");
        }
    }
}
