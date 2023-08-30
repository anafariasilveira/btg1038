using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico
{
    public class Pessoa : IHumano, IHumano2
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public void ImprimirDadosHumano()
        {
            Console.WriteLine("Imprimir");
        }

        public override string ToString()
        {
            StringBuilder dadosPessoa = new();
            dadosPessoa.Append($"{Nome} {Sobrenome}");

            return dadosPessoa.ToString();
        }
    }
}
