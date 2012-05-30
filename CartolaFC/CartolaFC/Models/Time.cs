using System.ComponentModel.DataAnnotations;

namespace CartolaFC.Models
{
    public class Time
    {
        public int TimeId { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        [StringLength(50,MinimumLength = 2, ErrorMessage = "O Campo Nome pode ter no máximo 50 caracteres.")]
        [Display(Name = "Nome do Time:")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Preencha este campo!")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "O campo deve ter 4 caracteres. ex.: 2000")]
        [Display(Name = "Ano de Fundação:")]
        public string AnoDeFundacao { get; set; }
        
        public string Descricao { get; set; }
    }
}