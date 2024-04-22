using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteReceitas.Models
{
    public class Receita //Não coloquei [Table] pq a pluralização deve funcionar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Geração automática de Id pelo banco (considerando tirar pq já deu problema)
        public int IdReceita { get; set; } //Não coloquei [Key] por ser ID, se for fazer alguma PK sem ID no nome lembrar de colocar
        
        [Required(ErrorMessage = "Obrigatório informar o nome da receita!")]
        // Ainda considerando se necessário: [StringLength(100, MinimumLength = 3, ErrorMessage = "Deve ter entre 3 e 100 caracteres!")]
        public string NomeReceita { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o modo de preparo!")]  
        public string ModoPreparo { get; set; }


        // Relacionamento 1:N com Ingrediente_Receita (Receita pode ter vários ingredientes_receita, mas cada ingrediente_receita pertence a apenas uma receita)
        public List<Ingrediente_Receita> IngredientesReceita { get; set; }

        // FK IdUsuario
        public int Id { get; set; }
        public Usuario Usuario { get; set; }

   
    }
}
