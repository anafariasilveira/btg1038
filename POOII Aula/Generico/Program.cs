namespace Generico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<object> lista = new();
            lista.Add(1);
            lista.Add("Teste");
            lista.Add(1.67);

            int valorInteiro = 1;

            object objeto = valorInteiro; // boxing

            int valorInteiro2 = (int)objeto; // unboxing
            */

            List<int> listaInteiro = new();
            Dictionary<string, int> dic = new();


            //propriedades genéricas
            GuardaDados<int> objetoDadoInteiro = new();
            objetoDadoInteiro.Dados = 1;
            //objetoDadoInteiro.Dados = "";

            objetoDadoInteiro.ImprimeDados();

            GuardaDados<string> objetoDadoString = new();
            objetoDadoString.Dados = "Ada";

            objetoDadoString.ImprimeDados();

            Pessoa objetoPessoa = new()
            {
                Nome = "Amanda",
                Sobrenome = "Mantovani"
            };

            GuardaDados<Pessoa> objetoDadoPessoa = new();
            objetoDadoPessoa.Dados = objetoPessoa;

            objetoDadoPessoa.ImprimeDados();

            //métodos com parametro genéricos!
            ImprimeDados<Pessoa> imprimir = new();
            imprimir.ImprimeDadosGenericos(objetoPessoa);


            ImprimeDados<int> imprimir3 = new();
            imprimir3.ImprimeDadosGenericos(10);


            ImprimeDados2 imprimir2 = new();

            imprimir2.ImprimirDadosGenericos<Pessoa>(objetoPessoa);
            imprimir2.ImprimirDadosGenericos<int>(10);
            imprimir2.ImprimirDadosGenericos<string>("Teste Ada");
        }
    }
}