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
    }
}
