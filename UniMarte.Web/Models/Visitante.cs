using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UniMarte.Web.Attributes;

namespace UniMarte.Web.Models
{
    [Table("Visitantes")]
    public class Visitante
    {
        [Key]
        public int IdVisitante { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Data em formato incorreto")]
        [IdadeValida(2, 120, ErrorMessage = "Data de Nascimento Inválida.")]
        public DateTime DataNascimento { get; set; }

        public DateTime DataHoraCadastro { get; set; }

        public Visitante(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            DataHoraCadastro = DateTime.Now;
        }

        // Construtor vazio necessário para o EF
        public Visitante() { }
    }
}
