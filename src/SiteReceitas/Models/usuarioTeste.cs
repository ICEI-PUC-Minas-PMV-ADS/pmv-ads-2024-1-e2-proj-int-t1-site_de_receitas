using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteReceitas.Models
{
    [Table("Usuarios")] // Nome da tabela no banco de dados
    public class usuarioTeste
    {

        [Key] // Chave primária
        public int Id { set; get; }

        [Required(ErrorMessage = "É necessário informar o nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; } // Nome do usuário

        [Required(ErrorMessage = "É necessário informar o email")]
        [Display(Name = "Email")]
        public string Email { get; set; } // E-mail do usuário

        [Required(ErrorMessage = "É necessário informar a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; } // Senha do usuário

        [Required(ErrorMessage = "É necessário informar o perfil")]
        [Display(Name = "Perfil")]
        public PerfilTeste Perfil { get; set; } // Perfil do usuário
    }
    
    public enum PerfilTeste
    {
        Admin,
        User
    }
}
