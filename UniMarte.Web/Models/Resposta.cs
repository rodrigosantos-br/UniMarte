using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniMarte.Web.Models
{
    [Table("Respostas")]
    public class Resposta
    {
        [Key]
        public int IdResposta { get; set; }
        public int IdPergunta { get; set; }
        public int IdVisitante { get; set; }
        [Column("Resposta")]
        public string RespostaTexto { get; set; }

        // Construtor que recebe os três parâmetros necessários
        public Resposta(int idPergunta, int idVisitante, string respostaTexto)
        {
            IdPergunta = idPergunta;
            IdVisitante = idVisitante;
            RespostaTexto = respostaTexto;
        }

        // Construtor sem parâmetros (opcional)
        public Resposta() { }
    }

}
