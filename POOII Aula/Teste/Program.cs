namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new()
            {
                Nome = "Ada",
                Classificacao = ClassificacaoFiscal.LucroReal
            };

            empresa.ClassificacaoString = "LucroReal";

            Empresa empresa2 = new();
            empresa2.ClassificacaoString = "lucroreal";

            if (empresa.Classificacao == ClassificacaoFiscal.IMEI)
            {

            }

            if (empresa.ClassificacaoString == ClassificacaoFiscal.IMEI.ToString())
            {

            }

            if ((int)empresa.Classificacao == 100)
            {

            }

            Console.WriteLine(empresa.Classificacao);
            Console.WriteLine((int)empresa.Classificacao);

            string valorAnalisado = "Ada";
            string valorPossivel = "Teste";

            switch (empresa.Classificacao)
            {
                case ClassificacaoFiscal.LucroReal:
                    Console.WriteLine("Empresa é Lucro Real");
                    break;
            }
        }
    }
}