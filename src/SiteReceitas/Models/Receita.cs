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

        public ICollection<Ingrediente> Ingredientes { get; set; }
    }
}
