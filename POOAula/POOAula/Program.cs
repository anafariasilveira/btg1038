namespace POOAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new();
            string sair = "N";

            do
            {
                Console.WriteLine("Olá! Qual operação vc deseja realizar?");
                Console.WriteLine("1 - SOMAR");
                Console.WriteLine("2 - SUBTRAIR");
                Console.WriteLine("3 - MULTIPLICAR");
                Console.WriteLine("4 - DIVIDIR");
                string operacao = Console.ReadLine();

                Console.WriteLine("Digite o primeiro numero");
                calc.valor1 = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero");
                calc.valor2 = Decimal.Parse(Console.ReadLine());

                decimal? resultado = operacao switch
                {
                    "1" => calc.Somar(),
                    "2" => calc.Subtrair(),
                    "3" => calc.Multiplicar(),
                    "4" => calc.Dividir(),
                    _ => null //DEFAULT
                };

                if (resultado != null)
                {
                    ImprimirResultado(resultado.GetValueOrDefault());
                }

                Console.WriteLine("Deseja realizar novo cálculo? S - Sim / N - Não");
                sair = Console.ReadLine();

            } while (sair != "N");

        }

        public static void ImprimirResultado(decimal resultado)
        {
            Console.WriteLine($"Resultado é {resultado}");
        }
        
        /*
        static void Main(string[] args)
        {
            Carro carro1 = new();
            carro1.cor = "Preto";
            carro1.ano = 2015;
            carro1.modelo = "Gol";

            carro1.Acelerar();
            carro1.Freiar();
        }
        */
        /*
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com dois numeros para somar");
            
            decimal valor1 = Decimal.Parse(Console.ReadLine());
            decimal valor2 = Decimal.Parse(Console.ReadLine());

            decimal resultadoSoma = Somar(valor1, valor2);

            ImprimirResultado(resultadoSoma);

        }

        // assinatura do método
        // modificador de acesso - retorno - nome metodo - parametros
        public static decimal Somar(decimal numero1, decimal numero2)
        {
            return numero1 + numero2;
        }
        
        public static void ImprimirResultado(decimal resultado)
        {
            Console.WriteLine($"Resultado da soma é {resultado}");
        }

        public static void SomarEImprimir(decimal numero1, decimal numero2)
        {
            decimal resultado = numero1 + numero2;
            ImprimirResultado(resultado);
        }*/

    }
}