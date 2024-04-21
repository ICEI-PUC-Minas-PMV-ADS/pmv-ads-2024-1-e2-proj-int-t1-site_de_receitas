using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteReceitas.Models
{
    [Table("Usuarios")]
    public class Usuario
    {

        [Key]
        public int Id { set; get; }

        [Required(ErrorMessage = "É necessário informar o nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É necessário informar o sobrenome")]
        [Display(Name = "Sobrenome")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "É necessário informar o E-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail inválido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "É necessário informar a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }
    }
}
