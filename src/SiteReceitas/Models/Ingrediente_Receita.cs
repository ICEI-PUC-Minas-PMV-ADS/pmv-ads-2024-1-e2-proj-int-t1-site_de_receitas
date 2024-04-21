using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteReceitas.Models
{
    public class Ingrediente_Receita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Geração automática de Id pelo banco (considerando tirar pq já deu problema)
        public int IdIngredienteReceita { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do ingrediente!")]
        [Range(0.01, double.MaxValue, ErrorMessage = "A quantidade do ingrediente não pode ser 0!")]
        public int QuantidadeIngrediente { get; set; }

        // FK Receita
        public int IdReceita { get; set; }
        public Receita Receita { get; set; }


        //FK Ingrediente
        public int IdIngrediente { get; set; }
        public Ingrediente Ingrediente { get; set; }
    }
}