using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteReceitas.Models
{

    [Table("Receitas")]
    public class Receita
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome da receita!")]
        public string NomeReceita { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o modo de preparo!")]
        public string ModoPreparo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ingreditente!")]
        [Display(Name = "Ingrediente")]
        public int IngredienteId { get; set; }

        public Ingrediente Ingrediente { get; set; }

        public ICollection<Avaliacao> Avaliacoes { get; set; }
        [Display(Name = "Imagem")]
        public byte[] Imagem { get; set; }
    }
}
