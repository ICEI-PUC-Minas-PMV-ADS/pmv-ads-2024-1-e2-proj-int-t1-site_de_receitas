using Humanizer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteReceitas.Models
{
    [Table("Avaliacoes")]
    public class Avaliacao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar a receita!")]
        [Display(Name ="Receita")]
        public int ReceitaId { get; set; }

        [ForeignKey("ReceitaId")]
        public Receita Receita { get; set; }

        [Display(Name = "Avaliação da receita")]
        public TipoNota Tipo { get; set; }
    }
    public enum TipoNota
    {
        Ruim,
        Bom,
        Ótimo
        
    }
}
