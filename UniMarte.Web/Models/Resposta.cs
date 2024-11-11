using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniMarte.Web.Models
{
    [Table("Respostas")]
    public class Resposta
    {
        public Resposta(int idPergunta, int idVisitante, string respostaTexto)
        {
            IdPergunta = idPergunta;
            IdVisitante = idVisitante;
            RespostaTexto = respostaTexto;
        }

        [Key]
        public int IdResposta { get; set; }
        public int IdPergunta { get; set; }
        public int IdVisitante { get; set; }
        public string RespostaTexto { get; set; }
        // Relacionamento: uma Resposta está associada a uma Pergunta
        [ForeignKey("IdPergunta")]
        public Pergunta Pergunta { get; set; }

        // Relacionamento: uma Resposta pertence a um Visitante
        [ForeignKey("IdVisitante")]
        public Visitante Visitante { get; set; }
    }
}
