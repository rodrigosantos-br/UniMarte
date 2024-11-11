using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniMarte.Web.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public Usuario(int idUsuario, string nomeUsuario, string senha, string nomeCompleto, int idade, string email)
        {
            IdUsuario = idUsuario;
            NomeUsuario = nomeUsuario;
            Senha = senha;
            NomeCompleto = nomeCompleto;
            Idade = idade;
            Email = email;
        }

        [Key]
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string NomeCompleto { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
    }
}
