using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class NotaFiscalRepository
    {
        private readonly ConexaoBancoMySql _conexao;
        public NotaFiscalRepository(ConexaoBancoMySql conexao)
        {
            _conexao = conexao;
        }

        public NotaFiscal Consultar(string idNotaFiscal)
        {
            return _conexao.Select<NotaFiscal>("SELECT * FROM TABELA");
        }

        public bool Inserir(NotaFiscal nota)
        {
            return true;
        }
        public bool Editar(NotaFiscal nota)
        {
            return true;
        }
        public bool Deletar(NotaFiscal nota)
        {
            return true;
        }
    }
}
