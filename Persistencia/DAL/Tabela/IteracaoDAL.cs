using Microsoft.EntityFrameworkCore;
using Modelo.Tabelas;
using Persistencia.Context;
using System.Linq;

namespace Persistencia.DAL.Tabela
{
    public class IteracaoDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Iteracao> ObterIteracoes(long? Id)
        {
            return context.Iteracoes.Where(p => p.OcorrenciaId == Id)
                .OrderBy(p => p.DataHoraIteracao);
        }

        public void GravarIteracao(Iteracao iteracao)
        {
            {
                if (iteracao.IteracaoId == null)
                {
                    context.Iteracoes.Add(iteracao);
                }
                else
                {
                    context.Entry(iteracao).State = EntityState.Modified;
                }

                context.SaveChanges();
            }

        }
    }
}
