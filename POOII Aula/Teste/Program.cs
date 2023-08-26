namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public abstract class Funcionario
        {
            public abstract void getBonificacao();
        }

        public abstract class Secretaria
        {

        }

        public class SecretariaAdministrativa : Secretaria
        {

        }

        public class SecretariaAgencia : Secretaria
        {
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
            public override void getBonificacao()
            {
                //..
            }
        }

        public class Diretor : Gerente
        {

        }
    }
}