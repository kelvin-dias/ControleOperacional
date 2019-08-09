using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Tabelas
{
    public class Iteracao
    {
        public long? IteracaoId { get; set; }
        public string TextoIteracao { get; set; }
        public DateTime DataHoraIteracao { get; set; }
        public string Assinatura { get; set; }

        public long? OcorrenciaId { get; set; }
        public Ocorrencia Ocorrencia { get; set; }
    }
}
