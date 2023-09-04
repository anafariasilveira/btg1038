using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class ConexaoBancoMySql
    {
        private readonly string _bancoDeDados;
        private readonly string _usuario;
        private readonly string _senha;
        public ConexaoBancoMySql()
        {
            _bancoDeDados = "bancoNotaFiscal";
            _usuario = "USR_NOTAFISCAL";
            _senha = "password123";
        }

        public T Select<T>(string query) where T : new()
        {
            //abrir conexao
            //executa consulta no banco
            //retorna o objeto q o banco retornou
            return new T();
        }
    }
}
