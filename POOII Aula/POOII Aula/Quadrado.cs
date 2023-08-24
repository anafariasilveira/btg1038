using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Aula
{
    public class Quadrado : Forma
    {
        public decimal Lado { get; set; }

        public override decimal Area
        {
            get => minhaArea;
            set => minhaArea = value;
        }

        public override decimal CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
