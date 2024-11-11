using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniMarte.Web.Models
{
    [Table("Perguntas")]
    public class Pergunta
    {
        public Pergunta(string textoPergunta, string tipoResposta)
        {
            TextoPergunta = textoPergunta;
            TipoResposta = tipoResposta;
        }

        [Key]
        public int IdPergunta { get; set; }
        [Required]
        public string TextoPergunta { get; set; }
        [Required]
        public string TipoResposta { get; set; }
        // Relacionamento de um para muitos: Uma Pergunta tem várias Respostas
        public ICollection<Resposta> Respostas { get; set; }
    }
}
