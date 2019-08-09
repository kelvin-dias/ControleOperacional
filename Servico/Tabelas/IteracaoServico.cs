using Modelo.Tabelas;
using Persistencia.DAL.Tabela;
using System.Linq;

namespace Servico.Tabelas
{
    public  class IteracaoServico
    {
        IteracaoDAL ocorrenciaDAL = new IteracaoDAL();

        public IQueryable ObterIteracoes(long? Id)
        {
            return ocorrenciaDAL.ObterIteracoes(Id);
        }

        public void GravarIteracao(Iteracao iteracao)
        {
            ocorrenciaDAL.GravarIteracao(iteracao);
        }

    }
}
