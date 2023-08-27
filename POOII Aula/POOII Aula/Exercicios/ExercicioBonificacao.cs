using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Aula.Exercicios
{
    /*
     * Classes abstratas são úteis para implementar comportamentos comuns a classes derivadas.

      O código a seguir possui um ou mais erros que não permitem sua compilação.
    Identifique e reescreva o código para corrigir o problema.
    */
    public abstract class Funcionario
    {
        public abstract void getBonificacao();
    }

    public abstract class Secretaria
    {

    }

    public class SecretariaAdministrativa : Secretaria
    {
        //não possui override pois classe base não possui virtual
    }

    public class SecretariaAgencia : Secretaria
    {
        //não possui override pois classe base não possui virtual

    }

    public class Presidente : Funcionario
    {
        public override void getBonificacao()
        {
            //..
        }
    }

    public class Gerente : Funcionario
    {
        //deve conter override
        public override void getBonificacao()
        {
            //..
        }
    }

    public class Diretor : Gerente
    {

    }
}
