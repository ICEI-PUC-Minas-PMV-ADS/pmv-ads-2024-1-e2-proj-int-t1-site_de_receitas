using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteReceitas.Models
{
    public class Ingrediente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Geração automática de Id pelo banco (considerando tirar pq já deu problema)
        public int IdIngrediente { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o nome do ingrediente!")]
        public string NomeIngrediente { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a unidade de medida! Exemplo: g, ml ou xícaras.")]
        public string UnidadeMedida { get; set; }

        // Relacionamento N:N com Ingrediente_Receita (Ingrediente pode estar em vários ingredientes_receita, e cada ingredientes_receita pode ter vários ingredientes)
        public List<Ingrediente_Receita> IngredientesReceita { get; set; }

    }
}
