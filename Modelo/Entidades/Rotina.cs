using Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Entidades
{
    public class Rotina
    {
        public int RotinaId { get; set; }
        public string Nome { get; set; }
        public int OrdemDeServico { get; set; }
        public BancoDeExecucao Execucao { get; set; }
        public string ResponsavelDaRotina { get; set; }
    }
}