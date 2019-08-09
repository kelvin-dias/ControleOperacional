using Persistencia.Context;
using Modelo.Entidades;
using System.Linq;

namespace Persistencia.DAL.Entidades
{
    class RotinaDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Rotina> ObterRotinaClassificadasPorNome()
        {
            return context.Rotinas.OrderBy(b => b.Nome);
        }
    }
}
