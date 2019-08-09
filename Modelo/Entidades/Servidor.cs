using Modelo.Enums.Servidor;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public class Servidor
    {
        [DisplayName("ID")]
        public long? ServidorId { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Informe o nome do Servidor")]
        public string Nome { get; set; }

        [DisplayName("Ambiente")]
        [Required(ErrorMessage = "Escolha o Ambiente do Servidor")]
        public AmbienteServidor Ambiente{ get; set; }

        [DisplayName("IP")]
        [Required(ErrorMessage = "Informe o Ip do Servidor")]
        public string ServidorIp { get; set; }
    }
    
}