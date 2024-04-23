using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteReceitas.Models
{
    [Table("Ingredientes")]
    public class Ingrediente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o nome do ingrediente!")]
        public string NomeIngrediente { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a unidade de medida! Exemplo: g, ml ou xícaras.")]
        public string UnidadeMedida { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a Receita!")]
        [Display(Name = "Receita")]
        public int ReceitaId { get; set; }

        [ForeignKey("ReceitaId")]
        public Receita Receita { get; set; }
    }
}
