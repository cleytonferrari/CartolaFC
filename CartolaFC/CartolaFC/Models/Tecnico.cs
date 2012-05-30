using System.ComponentModel.DataAnnotations;
using CartolaFC.Infra;

namespace CartolaFC.Models
{
    public class Tecnico
    {
        public int TecnicoId { get; set; }
        
        [Required(ErrorMessage = Mensagens.Tecnico.NomeDeveSerpreenchido)]
        [StringLength(50,MinimumLength = 2, ErrorMessage = Mensagens.Tecnico.NomeDeveTerDe2A50Caracteres)]
        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}