﻿using Modelo.Entidades;
using Persistencia.DAL.Entidades;
using System;
using System.Linq;

namespace Servico.Entidades
{
    public class OcorrenciaServico
    {
        OcorrenciaDAL ocorrenciaDAL = new OcorrenciaDAL();

        public IQueryable ObterOcorrenciasClassificadasPorDataHora()
        {
            return ocorrenciaDAL.ObterOcorrenciasClassificadasPorDataHora();
        }


        public Ocorrencia ObterOcorrenciaPorId(long? id)
        {
            return ocorrenciaDAL.ObterOcorrenciaPorId(id);
        }

        public void GravarServidor(Ocorrencia ocorrencia)
        {
            ocorrenciaDAL.GravarOcorrencia(ocorrencia);
        }

    }
}
