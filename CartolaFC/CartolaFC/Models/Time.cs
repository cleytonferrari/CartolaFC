using System.ComponentModel.DataAnnotations;
using CartolaFC.Infra;

namespace CartolaFC.Models
{
    public class Time
    {
        public int TimeId { get; set; }

        [Required(ErrorMessage = Mensagens.Time.NomeDeveSerpreenchido)]
        [StringLength(50, MinimumLength = 2, ErrorMessage = Mensagens.Time.NomeDeveTerDe2A50Caracteres)]
        [Display(Name = "Nome do Time:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = Mensagens.Time.AnoDeFundacaoDeveSerPreenchido)]
        [StringLength(4, MinimumLength = 4, ErrorMessage = Mensagens.Time.AnoDeFundacaoDeveTer4Caracteres)]
        [Display(Name = "Ano de Fundação:")]
        public string AnoDeFundacao { get; set; }

        public string Descricao { get; set; }

        public Tecnico Tecnico { get; set; }
    }
}