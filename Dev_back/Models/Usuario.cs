using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Dev_back.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Senha")]
        public Perfil   Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,User
    }
}
