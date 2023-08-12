using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class PessoaBKP
    {
        public string Nome { get; set; }
        internal string Sobrenome { get; set; }
        //private int idade;

        //método set -- substituida pela propriedade 
        //public void setIdade(int idade)
        //{
        //    if (idade < 120)
        //        Idade = idade;
        //    else
        //        throw new Exception("Idade não permitida");
        //}

        //public int getIdade()
        //{
        //    return Idade;
        //}

        // propriedade "manual"
        //public int Idade
        //{
        //    get
        //    {
        //        return Idade;
        //    }
        //    set
        //    {
        //        Idade = value;
        //    }
        //}

        // propriedade automatica
        public int Idade { get; set; }

        //método construtor
        public PessoaBKP()
        {
        }

        public PessoaBKP(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public PessoaBKP(string nome, string sobrenome, int idade) : this(nome, sobrenome)
        {
            //Pessoa(nome, sobrenome);
            this.Idade = idade;
        }
    }
}
