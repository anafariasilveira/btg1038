using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Exercicios
{
    /*
     * Crie a interface IData que fornece os métodos:
     *      void  setData(DateTime  data), que ajusta a data do objeto;
     *      DateTime  getData(), que retorna a data do objeto;
     *      e string  dataString, que retorna a data do objeto como uma string.
     * 
     * Crie uma classe Produto que possui nome, valor e data de validade.
     * Crie uma classe Venda que possui data e produto.
     * 
     * Produto e Venda implementam a interface IData.
     * 
     * Crie uma classe estática chamada TestarVenda e um método estático chamado DetalhesVenda
     * que recebe uma Venda e retorna uma string com os dados da venda.
     */
    public interface IData
    {
        void setData(DateTime data);
        DateTime getData();
        string dataString();
    }

    public class Produto : IData
    {
        public string nome;
        public decimal valor;
        private DateTime data;

        public void setData(DateTime data)
        {
            this.data = data;
        }

        public DateTime getData()
        {
            return data;
        }

        public string dataString()
        {
            return data.ToString("dd/MM/yyyy");
        }
    }

    public class Venda : IData
    {
        public Produto produto;
        private DateTime data;

        public void setData(DateTime data)
        {
            this.data = data;
        }

        public DateTime getData()
        {
            return data;
        }

        public string dataString()
        {
            return data.ToString("dd/MM/yyyy");
        }
    }

    public static class TestarVenda
    {
        public static string DetalhesVenda(Venda venda)
        {
            return $"Data da venda: {venda.dataString} - Produto: {venda.produto.nome} - Valor do produto: {venda.produto.valor} - Vencimento: {venda.produto.dataString()}";
        }
    }
}
