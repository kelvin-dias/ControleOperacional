using Modelo.Enums.Ocorrencia;
using Modelo.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public class Ocorrencia
    {
        [DisplayName("ID")]
        public long? OcorrenciaId { get; set; }

        [DisplayName("Número Ocorrência")]
        public long Numero_Ocorrencia { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Informe o Título da Ocorrência")]
        public string Titulo { get; set; }

        [DisplayName("Data e Hora")]
        public DateTime DataHora { get; set; }

        [DisplayName("Status")]
        public Status_Ocorrencia Status { get; set; }

        [DisplayName("Criticidade")]
        [Required(ErrorMessage = "Informe a Criticidade da Ocorrência")]
        public Criticidade_Ocorrencia Criticidade { get; set; }

        [DisplayName("Solução")]
        public string Solucao { get; set; }


        public ICollection<Iteracao> Iteracoes { get; set; }
    }
}
 