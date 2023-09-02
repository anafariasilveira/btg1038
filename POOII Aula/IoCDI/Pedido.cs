using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCDI
{
    internal class Pedido
    {
        private List<ItemPedido> Itens { get; set; }
        public Pedido()
        {
            Itens = new();
        }

        public void AdicionarItem(ItemPedido item)
        {
            Itens.Add(item);
        }

        //public void AdicionarTomate(int quantidade)
        //{
        //    Itens.Add(new ItemPedido(TipoItem.Tomate, quantidade));
        //}

        //public void AdicionarBatata(int quantidade)
        //{
        //    Itens.Add(new ItemPedido(TipoItem.Batata, quantidade));
        //}

        //public void AdicionarRepolho(int quantidade)
        //{
        //    Itens.Add(new ItemPedido(TipoItem.Repolho, quantidade));
        //}

        public void VisualizarItensPedido()
        {
            foreach(var item in Itens)
            {
                Console.WriteLine($"{item.Item} - Quantidade: {item.Quantidade}");
            }
        }
    }
}
