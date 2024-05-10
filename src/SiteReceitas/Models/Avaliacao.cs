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

        [Display(Name = "Avaliação da receita")]
        public Nota Tipo { get; set; }

        [Required(ErrorMessage ="Obrigatório informar a receita!")]
        public int ReceitaId{ get; set; }

        [ForeignKey("ReceitaId")]
        public Receita Receita { get; set;}
    }
    public enum Nota
    {
        Ruim,
        Bom,
        Ótimo
        
    }
}
