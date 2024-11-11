using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
