using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class CalculosFiscais
    {
        public void CalcularImpostos()
        {
            //calcular icms
            //calcular ipi
            //calcular pis
            CalcularICMS();
        }
        public void CalcularTotaisNota() { }

        private decimal CalcularICMS()
        {
            return 10M;
        }
    }
}
