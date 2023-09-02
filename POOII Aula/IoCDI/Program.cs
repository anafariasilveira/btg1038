using System.Text;

namespace IoCDI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItemPedido item = new();
            item.setItemRepolho(1);

            Pedido pedido = new();
            pedido.AdicionarItem(item);
            pedido.VisualizarItensPedido();
            StringBuilder

            /*
             * Crie um projeto Cinema
             *  Crie uma classe Filme com Titulo, Ano, Duracao
             *  Crie uma classe Sala com quantidadeCadeiras
             *  Crie uma classe Sessao com private Filme, private Sala e private DataHora
             *  No construtor da Exibicao receba a data e a sala // Injeção de dependencia via construtor
             *  Crie um método para receber o Filme
            */
        }
    }
}