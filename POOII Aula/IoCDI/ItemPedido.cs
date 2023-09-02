using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCDI
{
    internal class ItemPedido
    {
        public TipoItem Item { get; private set; }
        public int Quantidade { get; private set; }

        public void setItemBatata(int quantidade)
        {
            this.Item = TipoItem.Batata;
            this.Quantidade = quantidade;
        }

        public void setItemTomate(int quantidade)
        {
            this.Item = TipoItem.Tomate;
            this.Quantidade = quantidade;
        }

        public void setItemRepolho(int quantidade)
        {
            this.Item = TipoItem.Repolho;
            this.Quantidade = quantidade;
        }

    }
}
