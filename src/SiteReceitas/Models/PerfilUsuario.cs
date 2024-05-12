using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteReceitas.Models
{
    [Table("PerfilUsuario")]
    public class PerfilUsuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o sobrenome!")]
        [Display(Name = "Sobrenome")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o perfil!")]
        [Display(Name = "Perfil")]
        public TipoPerfil TipoPerfil { get; set; }
    }

    public enum TipoPerfil
    {
        Autor,
        Leitor
    }
}
