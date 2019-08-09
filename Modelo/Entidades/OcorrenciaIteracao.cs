using System;

namespace Modelo.Entidades
{
    public class OcorrenciaIteracao
    {
        public long? OcorrenciaIteracaoId { get; set; }
        public string Iteracao { get; set; }
        public DateTime DataHoraIteracao { get; set; }
        public string Assinatura { get; set; }

        public long? OcorrenciaId { get; set; }
        public  Ocorrencia Ocorrencia { get; set; }
    }
}
