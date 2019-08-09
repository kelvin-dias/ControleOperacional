﻿using System.Linq;
using Modelo.Entidades;
using Persistencia.Context;

namespace Persistencia.DAL.Entidades
{
    public class OcorrenciaDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Ocorrencia> ObterOcorrenciasClassificadasPorDataHora()
        {
            return context.Ocorrencias.OrderBy(b => b.DataHora);
        }

        public Ocorrencia ObterOcorrenciaPorId(long? id)
        {

            return context.Ocorrencias.Where(p => p.OcorrenciaId == id).First();
        }

        public void GravarOcorrencia(Ocorrencia ocorrencia)
        {

            context.Ocorrencias.Add(ocorrencia);
            context.SaveChanges();
        }


    }
}
